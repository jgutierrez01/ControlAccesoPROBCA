using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class Form1 : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        /*CONEXION IBIX*/
        //SqlConnection conexionIBIX = new SqlConnection(@"Data Source=192.168.1.41;Initial Catalog=IBIXLocal;User ID=IBIXChecador;Password=ibixchecamos");
        SqlConnection conexionIBIX = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionIBIX"].ConnectionString);

        public Form1()
        {
            InitializeComponent();
            radioTarjeton.CheckedChanged += new EventHandler(ActivarCheck);
            radioGafete.CheckedChanged += new EventHandler(ActivarCheck);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarGridRegistros();                        
            this.txtTarjeton.Focus();                     
        }

        public void LlenarGridRegistros()
        {            
            DataSet ds = new DataSet();
            string query = " SELECT " +
                               " R.RegistroAccesoID, " +
                               " ISNULL(RP.RegistroPersonasID, 0) RegistroPersonasID, " +
                               " CASE WHEN R.Placa IS NULL THEN 'SI' WHEN R.Placa IS NOT NULL AND RP.Chofer = 0 THEN 'SI' ELSE 'NO' END EsPeaton, " +
                               " CASE WHEN R.EsAutobus = 1 THEN 'SI' WHEN R.Placa IS NOT NULL AND (RP.Chofer = 1 AND R.TieneSalida = 0) THEN 'SI' ELSE 'NO' END EsConductor, " +
                               " CASE WHEN R.Tarjeton IS NULL OR R.TieneSalida = 1 THEN 'NA' WHEN RP.Chofer = 0 THEN 'NA' ELSE R.Tarjeton END Tarjeton, " +
                               " CASE WHEN R.Placa IS NULL OR R.TieneSalida = 1 THEN 'NA' WHEN RP.Chofer = 0 THEN 'NA' ELSE R.Placa END Placa,     " +
                               " RP.FechaEntrada AS FechaEntrada, " +
                               " RP.FechaEntrada AS HoraEntrada, " +
                               " CASE R.EsAutobus WHEN 1 THEN 'SI' ELSE 'NO' END AS EsAutobus, " +
                               " CASE WHEN R.Departamento IS NULL OR R.Departamento = 'BLA' THEN 'NA' ELSE R.Departamento END Departamento, " +
                               " R.Asunto, " +
                               " CASE WHEN EsAutobus = 1 THEN R.Conductor ELSE RP.Nombre END Conductor, " +
                               " ISNULL(RP.Gafete, 'NA') Gafete " +
                            " FROM " +
                                " RegistroAccesoSteelgo R " +
                                " LEFT JOIN RegistroAccesoPersonas RP ON RP.RegistroAccesoID = R.RegistroAccesoID AND RP.Activo = 1 AND RP.Salida = 0 " +
                            " WHERE " +
                                " R.Activo = 1 AND (R.TieneSalida = 0 OR RP.Salida = 0)";
            if (this.txtTarjeton.Text != "")
            {
                query += " AND R.Tarjeton LIKE '%" + this.txtTarjeton.Text.Trim() + "%' ";
            }else if( txtGafeteBuscar.Text != "")
            {
                query += " AND RP.Gafete LIKE '%" + txtGafeteBuscar.Text.Trim() + "%' ";
            }
            query = query + "ORDER BY FechaHoraEntrada DESC";
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds, "Registros");                       
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {            
            CapturaEntrada FormEntrada = new CapturaEntrada();
            FormEntrada.ShowDialog();            
            LlenarGridRegistros();
            FiltrarRegistrosHistoricos();
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if(!(dataGridView1.CurrentRow == null)) //Se comprueba que el registro actual no sea nulo.
            {
                int RegistroAccesoID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RegistroAccesoID"].Value);
                int RegistroPersonasID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RegistroPersonasID"].Value);
                string EsAutobus = dataGridView1.CurrentRow.Cells["EsAutobus"].Value.ToString();
                string EsPeaton = dataGridView1.CurrentRow.Cells["EsPeaton"].Value.ToString();

                if (EsAutobus == "NO")
                {                                            
                    if(dataGridView1.CurrentRow.Cells["EsConductor"].Value.ToString() == "NO")
                    {
                        MessageBox.Show("Esta Opción es unicamente para Salida de Carros Ó Autobuses, Para Salida Individual Ingrese A La Ventana De Salida Peatonal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else
                    {
                        CapturaSalida FormSalida = new CapturaSalida();
                        FormSalida.LoadOrders(RegistroAccesoID);
                        FormSalida.ShowDialog();
                        LlenarGridRegistros();
                    }                    
                }else
                {
                    CapturaSalidaAutobus FormSalidaAutobus = new CapturaSalidaAutobus();
                    FormSalidaAutobus.LoadOrders(RegistroAccesoID);
                    FormSalidaAutobus.ShowDialog();
                    LlenarGridRegistros();
                }
                
            }            
        }

        public void FiltrarRegistrosHistoricos()
        {            
            DataSet ds = new DataSet();
            String query = "SELECT RegistroAccesoID, CASE WHEN Tarjeton IS NULL THEN 'SI' ELSE 'NO' END EsPeaton1, ISNULL(Tarjeton, 'NA') Tarjeton1, ISNULL(Placa, 'NA') Placa, CASE WHEN Departamento = 'BLA' THEN '' ELSE Departamento END Departamento, Asunto, FechaHoraEntrada AS FechaEntrada, FechaHoraEntrada As HoraEntrada, " +
                            "FechaHoraSalida AS FechaSalida, FechaHoraSalida As HoraSalida, CASE EsAutobus WHEN 1 THEN 'SI' ELSE 'NO' END AS EsAutobus " +
                            "FROM RegistroAccesoSteelgo WHERE TieneSalida = 1 AND Activo = 1 ";

            if (this.dtpFechaInicial.Checked == true && this.dtpFechaFinal.Checked == true)
            {
                if(dtpFechaInicial.Value < dtpFechaFinal.Value || (dtpFechaInicial.Value.ToString() == dtpFechaFinal.Value.ToString()))
                {
                    query = query + "AND FechaHoraEntrada BETWEEN '" +
                            dtpFechaInicial.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }else
                {
                    MessageBox.Show("La fecha incial no debe ser mayor a la fecha final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (this.dtpFechaInicial.Checked == true && this.dtpFechaFinal.Checked == false)
            {
                query = query + "AND FechaHoraEntrada >= '" +
                            dtpFechaInicial.Value.ToString("yyyy-MM-dd") + " 00:00:00' ";
            }
            else if (this.dtpFechaInicial.Checked == false && this.dtpFechaFinal.Checked == true)
            {
                query = query + "AND FechaHoraEntrada <= '" +
                            dtpFechaFinal.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
            }

            if (this.cmbAsunto.Text != "" && this.cmbAsunto.Text.Trim() != "(TODOS)")
            {
                query = query + "AND Asunto = '" + this.cmbAsunto.Text.Trim() + "' ";
            }

            if (this.cmbDepartamento.Text != "" && this.cmbDepartamento.Text.Trim() != "(TODOS)")
            {
                query = query + "AND Departamento = '" + this.cmbDepartamento.Text.Trim() + "' ";
            }

            if (this.txtTarjetonHistorico.Text != "")
            {
                query = query + "AND Tarjeton LIKE '%" + this.txtTarjetonHistorico.Text.Trim() + "%' ";
            }

            query = query + "ORDER BY FechaHoraEntrada DESC";
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds, "Registros");

            if (ds.Tables[0].Rows.Count > 0)
            {
                //dataGridView1.Columns[0].DataPropertyName = ArchivoEntradaDT.Columns[0].ColumnName;
                //dataGridView1.Columns[1].DataPropertyName = ArchivoEntradaDT.Columns[1].ColumnName;
            }
            dataGridView2.DataSource = ds.Tables[0];
            if(conexion.State == ConnectionState.Open)
                conexion.Close();
        }



        public void CargarHistoricoIngresosPersonas()
        {
            conexion.Open();
            DataSet ds = new DataSet();
            String query = "SELECT RegistroAccesoID, Placa, CASE WHEN Departamento = 'BLA' THEN '' ELSE Departamento END Departamento, Asunto, FechaHoraEntrada AS FechaEntrada, FechaHoraEntrada As HoraEntrada, " +
                            "FechaHoraSalida AS FechaSalida, FechaHoraSalida As HoraSalida, CASE EsAutobus WHEN 1 THEN 'SI' ELSE 'NO' END AS EsAutobus " +
                            "FROM RegistroAccesoSteelgo WHERE TieneSalida = 1 AND Activo = 1 ";

            if (this.dtpFechaInicial.Checked == true && this.dtpFechaFinal.Checked == true)
            {
                query = query + "AND FechaHoraEntrada BETWEEN '" +
                            dtpFechaInicial.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
            }
            else if (this.dtpFechaInicial.Checked == true && this.dtpFechaFinal.Checked == false)
            {
                query = query + "AND FechaHoraEntrada >= '" +
                            dtpFechaInicial.Value.ToString("yyyy-MM-dd") + " 00:00:00' ";
            }
            else if (this.dtpFechaInicial.Checked == false && this.dtpFechaFinal.Checked == true)
            {
                query = query + "AND FechaHoraEntrada <= '" +
                            dtpFechaFinal.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
            }

            if (this.cmbAsunto.Text.Trim() != "" && this.cmbAsunto.Text.Trim() != "(TODOS)")
            {
                query = query + "AND Asunto = '" + this.cmbAsunto.Text.Trim() + "' ";
            }

            if (this.cmbDepartamento.Text.Trim() != "" && this.cmbDepartamento.Text.Trim() != "(TODOS)")
            {
                query = query + "AND Departamento = '" + this.cmbDepartamento.Text.Trim() + "' ";
            }

            if (this.txtTarjetonHistorico.Text.Trim() != "")
            {
                query = query + "AND Placa LIKE '%" + this.txtTarjetonHistorico.Text.Trim() + "%' ";
            }

            query = query + "ORDER BY FechaHoraEntrada DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds, "Registros");
            dataGridView2.DataSource = ds.Tables[0];
            conexion.Close();
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarRegistrosHistoricos();
        }

        private void btnEntradaAutobus_Click(object sender, EventArgs e)
        {
            CapturaEntradaAutobus FormEntradaAutobus = new CapturaEntradaAutobus();
            FormEntradaAutobus.ShowDialog();
            LlenarGridRegistros();
            FiltrarRegistrosHistoricos();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView2.CurrentRow == null)) //Se comprueba que el registro actual no sea nulo.
            {
                int RegistroAccesoID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["RegistroAccesoID1"].Value);
                string EsAutobus = dataGridView2.CurrentRow.Cells["EsAutobus1"].Value.ToString();

                if (EsAutobus == "NO")
                {
                    VisualizarHistoricos FormHistoricos = new VisualizarHistoricos();
                    FormHistoricos.LoadOrders(RegistroAccesoID);
                    FormHistoricos.ShowDialog();
                }
                else
                {
                    VisualizarHistoricosAutobus FormHistoricosAutobus = new VisualizarHistoricosAutobus();
                    FormHistoricosAutobus.LoadOrders(RegistroAccesoID);
                    FormHistoricosAutobus.ShowDialog();
                }
            }
        }

        private void btnFiltrarActuales_Click(object sender, EventArgs e)
        {
            LlenarGridRegistros();
        }

        private void ClickEntradaDePersonal(object sender, EventArgs e)
        {            
            EntradaDePersonal FormEntradaPersonal = new EntradaDePersonal();
            FormEntradaPersonal.ShowDialog();
            LlenarGridRegistros();
            FiltrarRegistrosHistoricos();
        }

        private void btnSalidaPersonal_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.CurrentRow == null)) //Se comprueba que el registro actual no sea nulo.
            {                
                int RegistroPersonasID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RegistroPersonasID"].Value);
                int RegistroAccesoID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RegistroAccesoID"].Value);
                if (dataGridView1.CurrentRow.Cells["EsAutobus"].Value.ToString().Trim().ToUpper() == "NO")
                {
                    SalidaDePersonal FormSalidaConID = new SalidaDePersonal();
                    FormSalidaConID.SalidaDesdeGrid(RegistroPersonasID);
                    FormSalidaConID.ShowDialog();
                    LlenarGridRegistros();
                }else
                {
                    MessageBox.Show("Registre La Salida En La Ventana De Salida Vehiculo/Autobus", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void BuscarPorTarjetonEvento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }else
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }            
        }

        private void EditarDatosPantallaPrincipal(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null) //Se comprueba que el registro actual no sea nulo.
                {
                    int RegistroAccesoID = int.Parse(dataGridView1.CurrentRow.Cells["RegistroAccesoID"].Value.ToString().Trim());
                    int RegistroPersonasID = int.Parse(dataGridView1.CurrentRow.Cells["RegistroPersonasID"].Value.ToString());
                    string Gafete = dataGridView1.CurrentRow.Cells["Gafete"].Value.ToString().Trim();
                    string EsCamion = dataGridView1.Rows[e.RowIndex].Cells["EsAutobus"].Value.ToString().Trim();
                    string Tarjeton = dataGridView1.Rows[e.RowIndex].Cells["Tarjeton"].Value.ToString().Trim();
                    string Placas = dataGridView1.Rows[e.RowIndex].Cells["Placa"].Value.ToString().Trim();
                    bool EsConductor = dataGridView1.Rows[e.RowIndex].Cells["EsConductor"].Value.ToString().Trim().ToUpper() == "SI" ? true : false;
                    if (EsCamion == "SI")
                    {
                        CapturaEntradaAutobus FormAutobus = new CapturaEntradaAutobus();
                        FormAutobus.EsEdicion = true;
                        FormAutobus.EditarDatos(RegistroAccesoID);
                        FormAutobus.ShowDialog();
                        LlenarGridRegistros();
                    }
                    else if ((Tarjeton != "" && Tarjeton != "NA") || EsConductor)
                    {                        
                        CapturaEntrada FormEntrada = new CapturaEntrada();
                        FormEntrada.EsEdicion = true;
                        FormEntrada.EditarDatos(RegistroAccesoID);                        
                        FormEntrada.ShowDialog();

                        LlenarGridRegistros();                        
                    }
                    else
                    {
                        EntradaDePersonal FormPersonal = new EntradaDePersonal();
                        FormPersonal.EsEdicion = true;
                        FormPersonal.EditarDatos(RegistroAccesoID, RegistroPersonasID, Gafete);
                        FormPersonal.ShowDialog();
                        LlenarGridRegistros();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar(object sender, EventArgs e)
        {
            LlenarGridRegistros();
        }

        private void ValidaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LlenaComboDepartamento()
        {
            try
            {
                if (conexionIBIX != null)
                {
                    if (conexionIBIX.State == ConnectionState.Closed)
                        conexionIBIX.Open();
                    SqlCommand _sql = new SqlCommand("SELECT Depto DepartamentoID, Nombre Departamento FROM tblDepto WHERE Activo = 1 AND Emp = 1", conexionIBIX);                    
                    SqlDataReader reader = _sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("DepartamentoID", typeof(string));
                    dt.Columns.Add("Departamento", typeof(string));
                    DataRow r = dt.NewRow();
                    r[0] = "";
                    r[1] = "(TODOS)";
                    dt.Rows.Add(r);
                    dt.Load(reader);
                    cmbDepartamento.ValueMember = "DepartamentoID";
                    cmbDepartamento.DisplayMember = "Departamento";
                    cmbDepartamento.DataSource = dt;
                    reader.Close();
                    conexionIBIX.Close();
                }
                else
                {
                    MessageBox.Show("Imposible Conectar Con Base De Datos: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Mostrando Departamentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenaComboAsunto()
        {           
            SqlCommand _sql = new SqlCommand("SELECT Asunto FROM RegistroAccesoSteelgo WHERE Asunto IS NOT NULL AND Asunto <> '' GROUP BY Asunto ORDER BY Asunto ASC", conexion);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            SqlDataReader reader = _sql.ExecuteReader();
            DataTable dt = new DataTable();                                       
            dt.Load(reader);
            cmbAsunto.Items.Add("(TODOS)");            
            cmbAsunto.DisplayMember = "Asunto";            
            List<string> Lista = new List<string>();
            foreach(DataRow row in dt.Rows)
            {
                Lista.Add(row.Field<string>("Asunto"));
            }
            cmbAsunto.Items.AddRange(Lista.ToArray());
            cmbAsunto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAsunto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAsunto.SelectedIndex = 0;
            reader.Close();
            conexion.Close();            
        }

        private void RelojRefrescaGrid_Tick(object sender, EventArgs e)
        {
            //LlenarGridRegistros();
        }

        private bool EstuvoEnCarro(int RegistroPersonasID, int RegistroAcceso)
        {
            bool res = false;
            try
            {
                string sql = "SELECT " +
                                " COUNT(*) Result " +
                            " FROM " +
                                " RegistroAccesoSteelgo R " +
                                " INNER JOIN RegistroAccesoPersonas RP ON RP.RegistroAccesoID = R.RegistroAccesoID AND R.Activo = 1 " +
                            " WHERE " +
                               " (RP.RegistroPersonasID = " + RegistroPersonasID + " AND R.RegistroAccesoID = " + RegistroAcceso + ") AND RP.Salida = 0 ";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Result"].ToString()) > 0) { res = true; }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Verificando si estuvo en carro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        private void TempoRefrescaHistorico_Tick(object sender, EventArgs e)
        {
            //FiltrarRegistrosHistoricos();
        }
        
        private void ActivarCheck(object sender, EventArgs e)
        {
            if (radioTarjeton.Checked)
            {
                lblTitleBusqueda.Text = "Tarjetón";
                txtGafeteBuscar.Visible = false;
                txtTarjeton.Visible = true;
                txtTarjeton.Text = "";
                txtTarjeton.Focus();
            }
            else
            {
                lblTitleBusqueda.Text = "Gafete";
                txtTarjeton.Visible = false;
                txtGafeteBuscar.Visible = true;
                txtGafeteBuscar.Text = "";
                txtGafeteBuscar.Focus();
            }
        }

        private void ValidaCodigoGafete(object sender, EventArgs e)
        {

        }

        private void CargarHistoricos(object sender, EventArgs e)
        {
            if (tabHistoricoPersonas.SelectedIndex == 1)
            {
                cmbAsunto.SelectedIndex = 0;
                //cmbAsunto.Items.Clear();
                //LlenaComboAsunto();
                LlenaComboDepartamento();
                FiltrarRegistrosHistoricos();
            }
        }

        private void MayusculasComboBox(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }            
        }

        private void btnActualizarInfoGrid1_Click(object sender, EventArgs e)
        {
            LlenarGridRegistros();
        }

        private void btnActualizarInfoGrid2_Click(object sender, EventArgs e)
        {
            FiltrarRegistrosHistoricos();
        }
    }
}
