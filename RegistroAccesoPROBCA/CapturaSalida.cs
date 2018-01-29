using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class CapturaSalida : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        private Dictionary<string, string> Persona;
        private Dictionary<int, string> DicSalida;        
        
        public CapturaSalida()
        {
            InitializeComponent();            
        }

        private void GetData(string selectCommand)
        {
            try
            {                
                dataAdapter = new SqlDataAdapter(selectCommand, conexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);                
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocuurio un error al cargar los datos de la pantalla", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapturaSalida_Load(object sender, EventArgs e)
        {            
        }

        internal void LoadOrders(int RegistAccesoID)
        {            
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();
            string query = "select top 1 * from RegistroAccesoSteelgo where RegistroAccesoID = " + RegistAccesoID.ToString() + " AND TieneSalida = 0 and Activo = 1";            
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds1, "Encabezado");
            this.txtClaveRegistro.Text = RegistAccesoID.ToString();
            this.txtPlacasVehiculo.Text = ds1.Tables[0].Rows[0]["Placa"].ToString();
            this.txtCondutor.Text = ds1.Tables[0].Rows[0]["Conductor"].ToString();
            this.cmbAsunto.Text = ds1.Tables[0].Rows[0]["Asunto"].ToString();
            this.cmbDepartamento.Text = ds1.Tables[0].Rows[0]["Departamento"].ToString();
            this.dtpFechaEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpHoraEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());            
            this.txtDescripcion.Text = ds1.Tables[0].Rows[0]["Comentarios"].ToString();

            DataSet ds = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT RegistroAccesoID, Placa, Nombre, RegistroPersonasID, Gafete, Salida FROM RegistroAccesoPersonas WHERE RegistroAccesoID = " + RegistAccesoID.ToString() + " AND Salida = 0 AND Activo = 1", conexion);
            da2.Fill(ds, "RegistrosPersonas");            
            dataGridView1.DataSource = ds.Tables[0];                       
            conexion.Close();            
            lblCantidadPersonas.Text = "visitan: " + Convert.ToString(dataGridView1.Rows.Count);            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {                
                string sql = "";
                DicSalida = new Dictionary<int, string>();
                Persona = new Dictionary<string, string>();                
                sql = "";
                int cuentaSalida = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {                    
                    if (Convert.ToBoolean(row.Cells["Salida"].Value))
                    {
                        if (EstaActivoEnCasetaOperador(row.Cells["Gafete"].Value.ToString(), Convert.ToInt32(row.Cells["RegistroPersonasID"].Value)))
                        {
                            Persona.Add(row.Cells["Nombre"].Value.ToString(), row.Cells["Gafete"].Value.ToString());
                        }else
                        {
                            DicSalida.Add(Convert.ToInt32(row.Cells["RegistroPersonasID"].Value), row.Cells["Nombre"].Value.ToString());
                        }                            
                    }
                    if (Convert.ToBoolean(row.Cells["Salida"].Value)) //Contador de Salidas
                    {
                        cuentaSalida++;
                    }
                }                
                if(cuentaSalida > 0)
                {
                    //MUESTRA LAS PERSONAS QUE AUN TIENE GAFETE ACTIVO EN CASETA OPERADOR
                    if (Persona.Count > 0)
                    {
                        string result = "";
                        foreach (var item in Persona)
                        {
                            result += "[ Nombre: " + item.Key + " - Gafete: " + item.Value + " ] " + Environment.NewLine;
                        }
                        MessageBox.Show("Las Siguientes Personas Aún Tienen Gafete Activo En Caseta Operador: \n\n " + result + "\n\n No Se Autoriza Salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //SE LE DA SALIDA A LAS PERSONAS QUE NO ESTAN EN CASETA OPERADOR
                    if (DicSalida.Count > 0)
                    {
                        string text = "";
                        foreach (var item in DicSalida)
                        {
                            text += "[ Nombre: " + item.Value + " ] " + Environment.NewLine;
                            sql += "UPDATE RegistroAccesoPersonas SET Chofer = 0 WHERE RegistroAccesoID = " + txtClaveRegistro.Text.Trim() + ";";
                            if (EsConductor(item.Value))
                            {
                                //DEJO SALIR A EL CHOFER EN REGISTRO STEELGO Y PERSONAS
                                sql += "UPDATE RegistroAccesoPersonas SET Salida = 1, FechaSalida = '" + dtpFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE RegistroPersonasID = " + item.Key.ToString() + " AND Salida = 0 AND Activo = 1; ";
                                sql += "UPDATE RegistroAccesoSteelgo SET TieneSalida = 1, FechaHoraSalida = '" + dtpFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE RegistroAccesoID = '" + txtClaveRegistro.Text.Trim() + "' AND TieneSalida = 0 AND Activo = 1;";
                            }
                            else
                            {
                                sql += "UPDATE RegistroAccesoPersonas SET Salida = 1, FechaSalida = '" + dtpFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', Chofer = 0 WHERE RegistroPersonasID = " + item.Key.ToString() + " AND Salida = 0 AND Activo = 1; ";
                            }
                        }
                        SqlCommand cmd2 = new SqlCommand(sql, conexion);
                        if (conexion.State == ConnectionState.Closed)
                            conexion.Open();
                        int res = cmd2.ExecuteNonQuery();
                        if (res > 0)
                        {
                            MessageBox.Show("A Las Siguientes Personas: \n\n " + text + "\n\n Se Guardó Correctamente La Salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        if (conexion.State == ConnectionState.Open)
                            conexion.Close();
                    }
                }else
                {
                    MessageBox.Show("Marque A Las Personas Que Dará Salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Otorgando Salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        private void ReplicaSalidaGrid(object sender, EventArgs e)
        {
            try
            {                   
                for(int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells["Salida"].Value = this.checkSalidaTodos.Checked;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.dtpFechaSalida.Value = DateTime.Now;
            this.dtpHoraSalida.Value = DateTime.Now;
        }

        private bool EstaActivoEnCasetaOperador(string Gafete, int RegistroPersonaID)
        {
            try
            {
                bool res = false;
                string query = "SELECT COUNT(*) Total FROM AsignacionGafete WHERE Gafete1 = '" + Gafete + "' AND TieneSalida = 0 AND RegistroPersonaID = " + RegistroPersonaID + " AND Activo = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if(Convert.ToInt32( reader["Total"].ToString() ) > 0) { res =  true; } 
                }
                reader.Close();
                conexion.Close();
                return res;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Salida Operador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool EsConductor(string Nombre)
        {
            bool res = false;
            try
            {
                string sql = "  SELECT TOP 1 " +
                                    " COUNT(*) Result " +
                                " FROM " +
                                    " RegistroAccesoPersonas RP " +
                                    " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = RP.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +
                                " WHERE " +
                                    " RS.Conductor = '" + Nombre + "' AND RP.Salida = 0 AND RP.Activo = 1 AND RP.Chofer = 1 ";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (Convert.ToInt32(read["Result"].ToString()) == 1) res = true;                    
                }
                read.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Verificando si es conductor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );                
            }
            return res;
        }        
    }    
}
