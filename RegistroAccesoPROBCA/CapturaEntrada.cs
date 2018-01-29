using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class CapturaEntrada : Form
    {        
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        /*CONEXION IBIX PRODUCCION*/
        //SqlConnection conexionIBIX = new SqlConnection(@"Data Source=192.168.1.41;Initial Catalog=IBIXLocal;User ID=IBIXChecador;Password=ibixchecamos");
        /*CONEXION IBIX TEST*/
        SqlConnection conexionIBIX = new SqlConnection(@"Data Source=192.168.1.41;Initial Catalog=IBIXLocal;User ID=sa;Password=TISt33lgo2014**Sys");
        /*CONEXION IBIX LOCAL*/
        //SqlConnection conexionIBIX = new SqlConnection(@"Data Source=DESKTOP-TCCMQI0\SAM2;Initial Catalog=IBIXLocal;User ID=sa;Password=maftec09");
        private static DataGridView tmpGrid = new DataGridView();
        public bool EsEdicion = false;
        public static bool ActivarMetodos = true;
        public string DepartamentoBLA = "";
        public CapturaEntrada()
        {
            InitializeComponent();
            tmpGrid = dataGridView1;
        }

        private void CapturaEntrada_Load(object sender, EventArgs e)
        {            
            if (!EsEdicion)
            {
                this.txtTarjeton.Focus();
                cmbAsunto.SelectedIndex = 0;
                //LlenaComboAsunto();
                LlenaComboDepartamento();
                dataGridView1.Columns["Eliminar"].Visible = false;
                this.btnEliminar.Visible = true;                   
            }else
            {
                dataGridView1.Columns["Eliminar"].Visible = true;
                this.btnEliminar.Visible = false;
                ValidarCheckGrid();      
            }            
        }

        private void LockOrUnlockFields(int key)
        {
            if(key == 1) //BLOQUEAR
            {
                chkEmpleado.Enabled = false;
                txtCondutor.Enabled = false;
                cmbAsunto.Enabled = false;
                cmbDepartamento.Enabled = false;
                txtCompania.Enabled = false;
                txtDescripcion.Enabled = false;
            }else
            {
                chkEmpleado.Enabled = false;
                txtCondutor.Enabled = true;
                cmbAsunto.Enabled = true;
                cmbDepartamento.Enabled = true;
                txtCompania.Enabled = true;
                txtDescripcion.Enabled = true;
            }
        }

        internal void LoadOrders(int RegistAccesoID)
        {            
        }      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!EsEdicion)
            {                
                if ((this.txtTarjeton.Text.Trim() == "") && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor captura el numero de Tarjetón", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTarjeton.Focus();
                    return;
                }
                else if ((this.txtPlacasVehiculo.Text.Trim() == "") && !chkEmpleado.Checked)
                {                       
                    MessageBox.Show("Por favor captura la Placa del vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPlacasVehiculo.Focus();
                    return;
                }
                else if ((cmbAsunto.Text.Trim() == "" || !Asuntocorrecto()) && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor seleccione un asunto de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbAsunto.Focus();
                    return;
                }
                else if ((this.cmbDepartamento.Text.ToString().Trim() == "" || this.cmbDepartamento.SelectedValue == null) && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor seleccione el departamento al que se dirige al persona que ingresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbDepartamento.Focus();
                    return;
                }
                else if (this.txtCondutor.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor capture el conductor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtCondutor.Focus();
                    return;
                }
                else if (this.txtGafeteChofer.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor captura el gafete del conductor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtGafeteChofer.Focus();
                    return;
                }
                else if (this.txtCompania.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor captura la compañia de procedencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtCompania.Focus();
                    return;
                }
                else if (this.dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Por favor capture al menos el nombre de una persona que ingresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (HayFilasIncompletas() > 0)
                {
                    MessageBox.Show("Existen Filas Incompletas, Por Favor Complete Los Registros Faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else
                {
                    string depa = chkEmpleado.Checked && DepartamentoBLA != "" ? DepartamentoBLA : cmbDepartamento.Text;
                    string depaID = chkEmpleado.Checked && DepartamentoBLA != "" ? DepartamentoBLA : GetIDDepto(cmbDepartamento.Text.Trim());
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    string query = " INSERT INTO RegistroAccesoSteelgo " +
                                    " VALUES ('" +
                                                this.dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                                                this.txtPlacasVehiculo.Text + "', '" +                                                
                                                //this.cmbDepartamento.Text  + "', '" +
                                                depa + "', '" +
                                                this.cmbAsunto.Text + "', 0, null, '" +
                                                this.txtDescripcion.Text + "', '" +
                                                this.txtCondutor.Text.Trim() + "', 0, null, null,1,null, '" +
                                                this.txtTarjeton.Text.Trim() + "', '" +
                                                this.txtCompania.Text.Trim() + "', '" +
                                                depaID + "', null)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                    string condicionDepa = chkEmpleado.Checked && DepartamentoBLA != "" ? "Departamento = '" + DepartamentoBLA + "' " : "Departamento = '" + cmbDepartamento.Text + "' ";
                    //query = "SELECT * FROM RegistroAccesoSteelgo WHERE Placa = '" + this.txtPlacasVehiculo.Text + "' AND Departamento = '" + this.cmbDepartamento.Text + "' AND Asunto = '" +
                    query = "SELECT * FROM RegistroAccesoSteelgo WHERE Placa = '" + this.txtPlacasVehiculo.Text + "' AND " + condicionDepa + " AND Asunto = '" +
                        this.cmbAsunto.Text + "' AND FechaHoraEntrada = '" + this.dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'  AND Activo = 1";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    da.Fill(ds, "Registros");
                    int IDIngresado = Convert.ToInt32(ds.Tables[0].Rows[0]["RegistroAccesoID"].ToString());
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Nombre"].Value != null)
                        {
                            string PersonaActual = row.Cells["Nombre"].Value.ToString();
                            string gafete = row.Cells["Gafete"].Value == null ? "" : row.Cells["Gafete"].Value.ToString();
                            DataGridViewCheckBoxCell checkEmpleado = (DataGridViewCheckBoxCell)row.Cells["EsEmpleado"];
                            bool EsEmpleado = (null != checkEmpleado && null != checkEmpleado.Value && true == (bool)checkEmpleado.Value);
                            if (row.Cells["Nombre"].Value.ToString() == txtCondutor.Text.Trim().ToUpper())
                            {
                                query += "INSERT INTO RegistroAccesoPersonas VALUES ('" + this.txtPlacasVehiculo.Text + "', " + IDIngresado.ToString() + ", UPPER('" + PersonaActual.Trim() + "'), UPPER('" + gafete + "'), 0, '" + this.dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', null, 1, 1, " + (EsEmpleado == true ? 1 : 0) + " )";
                            }
                            else
                            {
                                query += "INSERT INTO RegistroAccesoPersonas VALUES ('" + this.txtPlacasVehiculo.Text + "', " + IDIngresado.ToString() + ", UPPER('" + PersonaActual.Trim() + "'), UPPER('" + gafete + "'), 0, '" + this.dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', null, 1, 0, " + (EsEmpleado == true ? 1 : 0) + " )";
                            }                                                        
                        }
                    }
                    SqlCommand cmd2 = new SqlCommand(query, conexion);
                    cmd2.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se ingreso correctamente el nuevo registro", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                                                 
            }
            else //ES EDICION
            {                
                if (this.txtTarjeton.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Ingrese Tarjeton", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txtPlacasVehiculo.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Ingrese Placas del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((cmbAsunto.Text.Trim() == "" || !Asuntocorrecto()) && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Por favor Seleccione Un Asunto De La Lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((this.cmbDepartamento.Text.Trim() == "" || this.cmbDepartamento.SelectedValue == null) && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Seleccione a que Departamento viene", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txtCondutor.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Ingrese Nombre del Conductor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txtGafeteChofer.Text.Trim() == "" && !chkEmpleado.Checked)
                {
                    MessageBox.Show("Ingrese Gafete del chofer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (HayFilasIncompletas() > 0)
                    {
                        MessageBox.Show("Existen Filas Incompletas, Por Favor Complete Los Registros Faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }else
                    {
                        int RegistroAccesoID = 0;
                        if (this.txtRegistroAccesoID.Text != "")
                        {
                            RegistroAccesoID = int.Parse(this.txtRegistroAccesoID.Text.Trim());
                            string query = "";
                            if (chkEmpleado.Checked)
                            {                                
                                query += "UPDATE RegistroAccesoSteelgo SET " +
                                            " Tarjeton = '" + this.txtTarjeton.Text.Trim().ToUpper() + "'," +
                                            " Placa = '" + this.txtPlacasVehiculo.Text.Trim().ToUpper() + "'," +                                            
                                            " Conductor = '" + this.txtCondutor.Text.Trim().ToUpper() + "' " +
                                            " WHERE RegistroAccesoID = " + RegistroAccesoID + "  AND Activo = 1";
                            }
                            else
                            {                                
                                query += "UPDATE RegistroAccesoSteelgo SET " +
                                            " Tarjeton = '" + this.txtTarjeton.Text.Trim().ToUpper() + "'," +
                                            " Placa = '" + this.txtPlacasVehiculo.Text.Trim().ToUpper() + "'," +
                                            " Asunto = '" + this.cmbAsunto.Text.Trim().ToUpper() + "', " +
                                            " DepartamentoID = '" + this.cmbDepartamento.SelectedValue + "'," +
                                            " Departamento = '" + this.cmbDepartamento.Text + "', " +
                                            " Conductor = '" + this.txtCondutor.Text.Trim().ToUpper() + "', " +
                                            " Compania = '" + this.txtCompania.Text.Trim().ToUpper() + "'," +
                                            " Comentarios = '" + this.txtDescripcion.Text.ToUpper() + "' " +
                                            " WHERE RegistroAccesoID = " + RegistroAccesoID + "  AND Activo = 1";
                            }
                            query += "UPDATE RegistroAccesoPersonas SET Nombre = '" + txtCondutor.Text.Trim().ToUpper() + "' WHERE RegistroPersonasID = " + Convert.ToInt32(txtRegistroPersonasID.Text.Trim());

                            SqlCommand cmd = new SqlCommand(query, conexion);
                            if (conexion.State == ConnectionState.Closed)
                                conexion.Open();
                            int rowAffected = cmd.ExecuteNonQuery();
                            int OK = 0;
                            if (rowAffected > 0)
                            {
                                OK = 1;
                            }
                            if (conexion.State == ConnectionState.Open)
                                conexion.Close();

                            //ACTUALIZO INFORMACION DE GRID                       
                            DataTable dtTabla = new DataTable();
                            dtTabla = (DataTable)(dataGridView1.DataSource);
                            int cont = 0;
                            foreach (DataRow dr in dtTabla.Rows) // search whole table
                            {
                                if (dr["Gafete"].ToString() == "")
                                {
                                    cont++;
                                }
                            }
                            if (cont == 0)
                            {
                                string stored = "dbo.InsertaOActualiza";
                                SqlCommand cmd2 = new SqlCommand(stored, conexion);
                                if (conexion.State == ConnectionState.Closed)
                                    conexion.Open();
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.Add(new SqlParameter("@Tabla", dtTabla));
                                cmd2.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                                cmd2.ExecuteNonQuery();
                                int result = Convert.ToInt32(cmd2.Parameters["@result"].Value);
                                if (conexion.State == ConnectionState.Open)
                                    conexion.Close();
                                if (OK == 1 && result == 1)
                                {
                                    MessageBox.Show("Registros Actualizados Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Existen personas que no tienen gafetes asignados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Imposible Editar, No se Encontro El RegistroAccesoID, Cierre esta ventana y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                                            
                }               
            }
        }

        private bool Asuntocorrecto()
        {
            bool result = false;
            try
            {
                if(cmbAsunto.Text != "")
                {
                    foreach (var item in cmbAsunto.Items)
                    {
                        if (cmbAsunto.Text == item.ToString())
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Recorriendo Items Asunto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.CurrentRow == null))
            {
                if (dataGridView1.CurrentRow.Cells["Nombre"].Value != null)
                {
                    if (dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString() == txtCondutor.Text.Trim())
                    {
                        MessageBox.Show("No es posible eliminar al conductor de las lista de personas que ingresan.");
                        return;
                    }

                    if (MessageBox.Show("Esta Seguro que desea eliminar el registro seleccionado", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                       == DialogResult.Yes)
                    {
                        if (dataGridView1.Rows.Count > 0)
                        {
                            //Se elimina el registro del DataGridView                            
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        }
                    }
                } else
                {
                    MessageBox.Show("No existen Registros a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No existen Registros a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPlacasVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '/' || e.KeyChar == ' ' || e.KeyChar == '\'')
            {
                e.Handled = true;
            }
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                string query = "";
                int Result = 0;
                try
                {
                    query = "SELECT COUNT(*) Existe FROM RegistroAccesoSteelgo WHERE Placa = '" + txtPlacasVehiculo.Text.Trim() + "' AND Activo = 1 AND TieneSalida = 0";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Result = Convert.ToInt32(reader["Existe"].ToString());
                    }
                    reader.Close();
                    query = "";
                    conexion.Close();
                    if (Result > 0)
                    {
                        MessageBox.Show("La placa del vehiculo ya se encuentra capturada y no tiene salida.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtPlacasVehiculo.Text = "";
                        this.txtPlacasVehiculo.Focus();
                    }
                    else
                    {
                        query = "SELECT TOP 1 Conductor, Asunto, Departamento, Comentarios, Compania FROM RegistroAccesoSteelgo WHERE Placa = '" + txtPlacasVehiculo.Text.Trim() + "' AND Activo = 1 ORDER BY RegistroAccesoID DESC";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                        if (conexion.State == ConnectionState.Closed)
                            conexion.Open();
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Datos");
                        conexion.Close();
                        if (ds.Tables["Datos"].Rows.Count > 0)
                        {
                            txtCondutor.Text = ds.Tables["Datos"].Rows[0]["Conductor"].ToString();
                            cmbAsunto.Text = ds.Tables["Datos"].Rows[0]["Asunto"].ToString();
                            cmbDepartamento.Text = ds.Tables["Datos"].Rows[0]["Departamento"].ToString();
                            txtDescripcion.Text = ds.Tables["Datos"].Rows[0]["Comentarios"].ToString();
                            txtCompania.Text = ds.Tables["Datos"].Rows[0]["Compania"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al validar placa ya capturada. Puede continuar la captura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCondutor_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells["Nombre"].Value = txtCondutor.Text.Trim();
        }


        private void txtPlacasVehiculo_Leave(object sender, EventArgs e)
        {
            string query = "";
            int Result = 0;
            try
            {
                query = "SELECT COUNT(*) Existe FROM RegistroAccesoSteelgo WHERE Placa = '" + txtPlacasVehiculo.Text.Trim() + "' AND Activo = 1 AND TieneSalida = 0";
                SqlCommand cmd = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Result = Convert.ToInt32(reader["Existe"].ToString());
                }
                reader.Close();                
                query = "";
                conexion.Close();
                if(Result > 0)
                {
                    MessageBox.Show("La placa del vehiculo ya se encuentra capturada y no tiene salida.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPlacasVehiculo.Text = "";
                    this.txtPlacasVehiculo.Focus();                    
                }
                else
                {
                    query = "SELECT TOP 1 Conductor, Asunto, Departamento, Comentarios, Compania FROM RegistroAccesoSteelgo WHERE Placa = '" + txtPlacasVehiculo.Text.Trim() + "' AND Activo = 1 ORDER BY RegistroAccesoID DESC";                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();                    
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Datos");
                    conexion.Close();
                    if(ds.Tables["Datos"].Rows.Count > 0)
                    {
                        txtCondutor.Text = ds.Tables["Datos"].Rows[0]["Conductor"].ToString();
                        cmbAsunto.Text = ds.Tables["Datos"].Rows[0]["Asunto"].ToString();
                        cmbDepartamento.Text = ds.Tables["Datos"].Rows[0]["Departamento"].ToString();
                        txtDescripcion.Text = ds.Tables["Datos"].Rows[0]["Comentarios"].ToString();
                        txtCompania.Text = ds.Tables["Datos"].Rows[0]["Compania"].ToString();
                    }                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar placa ya capturada. Puede continuar la captura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCantidadPersonas.Text = "visitan: " + Convert.ToString(dataGridView1.Rows.Count - 1);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblCantidadPersonas.Text = "visitan: " + Convert.ToString(dataGridView1.Rows.Count - 1);
        }

        private void ValidaTarjeton(object sender, EventArgs e)
        {
            try
            {
                int registroAcceso = 0;
                if (this.txtRegistroAccesoID.Text != "")
                    registroAcceso = int.Parse(this.txtRegistroAccesoID.Text.Trim());

                if (this.txtTarjeton.Text != "")
                {
                    string _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoSteelgo WHERE TieneSalida = 0 AND Tarjeton = '" + this.txtTarjeton.Text.Trim() + "' AND RegistroAccesoID <> " + registroAcceso + " AND Activo = 1";
                    SqlCommand cmd = new SqlCommand(_sql, conexion);
                    if(conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (int.Parse(reader["TotalRegistros"].ToString()) > 0)
                        {
                            MessageBox.Show("Existe un vehiculo con este tarjeton asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtTarjeton.Text = "";
                            this.txtTarjeton.Focus();
                        }
                    }
                    reader.Close();                    
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaGafeteForm(object sender, EventArgs e)
        {
            BeginInvoke(new Action(delegate {
                if (txtGafeteChofer.Text != "")
                {                    
                    if (chkEmpleado.Checked)
                    {                        
                        int i;
                        if (!int.TryParse(txtGafeteChofer.Text.Trim(), out i))
                        {
                            MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpiarCampos();
                            txtGafeteChofer.Text = "";
                            txtGafeteChofer.Focus();
                        }
                        else
                        {
                            if (!ExisteGafeteActivoEmpleado(txtGafeteChofer.Text.Trim()))
                            {
                                ObtenerInfoTrabajadorIBIX(txtGafeteChofer.Text.Trim().ToUpper());
                            }
                            else
                            {
                                MessageBox.Show("Ya Existe Una Persona Con El Mismo Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimpiarCampos();
                                txtGafeteChofer.Text = "";
                                txtGafeteChofer.Focus();
                            }                            
                        }
                    }
                    else 
                    {
                        if (!CodigoGafeteCorrecto(txtGafeteChofer.Text.Trim()))
                        {
                            MessageBox.Show("Codigo De Gafete Incorrecto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafeteChofer.Text = "";
                            txtGafeteChofer.Focus();
                        }
                        else if (ChecaGafeteActivoGrid(txtGafeteChofer.Text.Trim()))
                        {
                            MessageBox.Show("Este Gafete ya esta ocupado por otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafeteChofer.Text = "";
                            txtGafeteChofer.Focus();
                        }
                    }                    
                }else
                {
                    MessageBox.Show("Ingrese Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }               
            }));            
        }

        private void ToUpper(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.dtpFechaEntrada.Value = DateTime.Now;
            this.dtpHoraEntrada.Value = DateTime.Now;
        }        

        internal void EditarDatos(int RegistroAccesoID)
        {
            //ActivarCampos();
            LlenaComboDepartamento();                        
            //dataGridView1.Columns["EsEmpleado"].ReadOnly = true;
            ValidarCheckGrid();
            LlenarInformacion(RegistroAccesoID);
        }

        private void LlenaComboDepartamento()
        {
            try
            {
                if (conexionIBIX != null)
                {
                    SqlCommand _sql = new SqlCommand("SELECT Depto DepartamentoID, Nombre Departamento FROM tblDepto WITH(NOLOCK) WHERE Emp = 1  ", conexionIBIX); //AND Nombre <> ''
                    if (conexionIBIX.State == ConnectionState.Closed)
                        conexionIBIX.Open();
                    SqlDataReader reader = _sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("DepartamentoID", typeof(string));
                    dt.Columns.Add("Departamento", typeof(string));
                    dt.Rows.Add();
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
            SqlCommand _sql = new SqlCommand("SELECT Asunto FROM RegistroAccesoSteelgo WHERE Asunto IS NOT NULL  AND Activo = 1 GROUP BY Asunto", conexion);
            conexion.Open();
            SqlDataReader reader = _sql.ExecuteReader();
            AutoCompleteStringCollection elementos = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                cmbAsunto.Items.Add(reader["Asunto"].ToString());
                elementos.Add(reader["Asunto"].ToString());
            }
            cmbAsunto.AutoCompleteCustomSource = elementos;
            cmbAsunto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbAsunto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            reader.Close();            
            conexion.Close();
        }

        private void ActivarCampos()
        {
            this.txtTarjeton.Enabled = true;
            this.txtPlacasVehiculo.Enabled = true;
            this.txtCondutor.Enabled = true;
            this.cmbAsunto.Enabled = true;
            this.cmbDepartamento.Enabled = true;
            this.txtGafeteChofer.Enabled = true;
            this.txtCompania.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.Reloj.Enabled = false;
            this.dtpFechaEntrada.Enabled = false;
            this.dtpHoraEntrada.Enabled = false;
        }
        private void LlenarInformacion(int RegistroAccesoID)
        {
            try
            {
                //MUESTRO INFORMACION DE VEHICULO Y CONDUCTOR
                string query = "SELECT " +
                                    " R.RegistroAccesoID, " +
                                    " RP.RegistroPersonasID, " +
                                    " R.Tarjeton, " +
                                    " CONVERT(BIT, ISNULL(RP.EsEmpleado, 0)) EsEmpleado, " +
                                    " R.Placa, " +
                                    " ISNULL(R.Asunto,'') Asunto, " +
                                    " D.Depto DepartamentoID, " +
                                    " D.Nombre Departamento, " +                                    
                                    " R.Conductor, " +
                                    " RP.Gafete, " +
                                    " R.Compania, " +
                                    " R.Comentarios Descripcion, " +
                                    " R.FechaHoraEntrada " +
                                " FROM " +
                                    " RegistroAccesoSteelgo R WITH(NOLOCK) " +
                                    " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D WITH(NOLOCK) ON D.Depto = R.DepartamentoID AND D.Emp = 1 " + // AND D.Nombre <> ''
                                    //" INNER JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroAccesoID = R.RegistroAccesoID AND Salida = 0 AND RP.Activo = 1" +
                                    " INNER JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroAccesoID = R.RegistroAccesoID AND R.Conductor = RP.Nombre COLLATE Modern_Spanish_CI_AI AND Salida = 0 AND RP.Activo = 1" +
                                " WHERE " +
                                    " R.RegistroAccesoID = " + RegistroAccesoID + "  AND R.Activo = 1 AND TieneSalida = 0";
                SqlCommand cmd = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chkEmpleado.Checked = Convert.ToBoolean(reader["EsEmpleado"].ToString());
                    this.txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                    txtRegistroPersonasID.Text = reader["RegistroPersonasID"].ToString();
                    this.txtPlacasVehiculo.Text = reader["Placa"].ToString();
                    this.txtTarjeton.Text = reader["Tarjeton"].ToString();
                    this.txtCondutor.Text = reader["Conductor"].ToString();
                    this.cmbAsunto.Text = reader["Asunto"].ToString();
                    this.cmbDepartamento.Text = reader["Departamento"].ToString();
                    this.txtGafeteChofer.Text = reader["Gafete"].ToString();
                    this.txtCompania.Text = reader["Compania"].ToString();
                    this.dtpFechaEntrada.Value = Convert.ToDateTime(reader["FechaHoraEntrada"].ToString());
                    this.dtpHoraEntrada.Value = Convert.ToDateTime(reader["FechaHoraEntrada"].ToString());
                    this.txtDescripcion.Text = reader["Descripcion"].ToString();
                }
                reader.Close();                
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                if (chkEmpleado.Checked == chkEmpleado.ThreeState)
                {
                    LockOrUnlockFields(1);
                }
                //MUESTRO INFORMACION DE PASAJEROS                                     
                string _sql = "SELECT " +
                                " R.RegistroAccesoID, " +
                                " CONVERT(BIT, ISNULL(RP.EsEmpleado, 0)) EsEmpleado, " + //agregado
                                " RP.RegistroPersonasID, " +
                                " R.Placa, " +
                                " RP.Nombre, " +
                                " RP.Gafete, " +
                                " RP.FechaEntrada, 0 Eliminar " +
                            " FROM " +
                                " RegistroAccesoSteelgo R " +
                                " INNER JOIN RegistroAccesoPersonas RP ON RP.RegistroAccesoID = R.RegistroAccesoID AND Salida = 0 AND RP.Activo = 1 " +
                            " WHERE " +
                                " R.RegistroAccesoID = " + RegistroAccesoID + " AND R.Activo = 1";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();    
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(_sql, conexion);
                da.Fill(ds, "RegistrosPersonas");
                dataGridView1.DataSource = ds.Tables[0];
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                this.lblCantidadPersonas.Text = "visitan: " + dataGridView1.Rows.Count.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Mostrando Informacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplicaGafeteFormToGrid(object sender, EventArgs e)
        {                             
            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells["Gafete"].Value = txtGafeteChofer.Text.Trim();            
        }

       private void ValidarGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                //OBTENGO VALOR DE CHECKBOX EMPLEADO GRID
                DataGridViewCheckBoxCell checkEmpleado = (DataGridViewCheckBoxCell)dataGridView1.CurrentRow.Cells["EsEmpleado"];
                //bool valueCheckEmpleado = (checkEmpleado.Value != null && checkEmpleado.Value == checkEmpleado.TrueValue);
                bool valueCheckEmpleado = (checkEmpleado.Value != null && (Boolean)checkEmpleado.Value);
                string tmpNombre = "";
                if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Gafete" && dataGridView1.Columns[e.ColumnIndex].DataPropertyName != null)
                {
                    if (dataGridView1.CurrentCell.Value != null)
                    {
                        //VERIFICO SI ESTA ACTIVADO EL CHECK, DE SER CORRECTO OBTENER NOMBRE DEL EMPLEADO
                        if (valueCheckEmpleado && !dataGridView1.CurrentRow.IsNewRow)
                        {
                            //VALIDO SI YA EXISTE ENTRADA DEL EMPLEADO
                            if (!ExisteGafeteActivoEmpleado(dataGridView1.CurrentCell.Value.ToString()))
                            {
                                bool existe = dataGridView1.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToString(x.Cells["Gafete"].Value) == dataGridView1.CurrentCell.Value.ToString() && x.Index != dataGridView1.CurrentRow.Index);
                                if (existe)
                                {
                                    MessageBox.Show("Este Gafete ya existe en el grid", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (dataGridView1.CurrentRow.Index == 0)
                                    {
                                        dataGridView1.CurrentCell.Value = "";
                                    }
                                    else
                                    {
                                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                    }
                                    return;
                                }else
                                {
                                    tmpNombre = GetInforEmpleadoGrid(dataGridView1.CurrentCell.Value.ToString());
                                    if (tmpNombre == "" || tmpNombre == "ERROR")
                                    {
                                        MessageBox.Show("No Existe Información Con Este Gafete, Por Favor Verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (dataGridView1.CurrentRow.Index == 0)
                                        {
                                            dataGridView1.CurrentCell.Value = "";
                                        }
                                        else
                                        {
                                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                        }
                                        return;
                                    }
                                    else
                                    {
                                        dataGridView1.CurrentRow.Cells["Nombre"].Value = tmpNombre;
                                    }
                                }                                
                            }else
                            {
                                MessageBox.Show("Este Gafete Ya Tiene Entrada Activa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (dataGridView1.CurrentRow.Index == 0)
                                {
                                    dataGridView1.CurrentCell.Value = "";
                                }
                                else
                                {
                                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                }
                                return;
                            }                            
                        }else
                        {
                            //REEMPLAZAR APOSTROFE POR GUION                        
                            dataGridView1.CurrentCell.Value = ValidaCodigoGafeteGrid(dataGridView1.CurrentCell.Value.ToString());
                            if (CodigoGafeteCorrectoGRID(dataGridView1.CurrentCell.Value.ToString(), valueCheckEmpleado))
                            {
                                bool existe = dataGridView1.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToString(x.Cells["Gafete"].Value) == dataGridView1.CurrentCell.Value.ToString() && x.Index != dataGridView1.CurrentRow.Index);
                                if (existe)
                                {
                                    MessageBox.Show("Este Gafete ya existe en el grid", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (dataGridView1.CurrentRow.Index == 0)
                                    {
                                        dataGridView1.CurrentCell.Value = "";
                                    }
                                    else
                                    {
                                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                    }
                                    return;
                                }
                                else
                                {
                                    if (ChecaGafeteActivoGrid(dataGridView1.Rows[e.RowIndex].Cells["Gafete"].Value.ToString().ToUpper()))
                                    {
                                        MessageBox.Show("Este Gafete ya esta ocupado por otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (dataGridView1.CurrentRow.Index == 0)
                                        {
                                            dataGridView1.CurrentCell.Value = "";
                                        }
                                        else
                                        {
                                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                        }
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Codigo De Gafete Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error En Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
             
        private bool ChecaGafeteActivoGrid(string Gafete)
        {
            bool ok = false;
            string query = "SELECT COUNT(*) Total FROM RegistroAccesoPersonas WHERE Gafete = '" + Gafete + "' AND Salida = 0 AND Activo = 1";
            SqlCommand cmd = new SqlCommand(query, conexion);            
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if(Convert.ToInt32(reader["Total"].ToString() ) > 0) { ok = true; }                
            }
            reader.Close();            
            conexion.Close();
            return ok;
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {                     
            e.Control.KeyPress += Control_KeyPress;                               
        }
        private static void Control_KeyPress(object sender, KeyPressEventArgs e)
        {             
           
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (tmpGrid.CurrentCell.ColumnIndex == 3)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }            
        }

        private void EliminarPasajeros(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                BeginInvoke(new Action(delegate {                   
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataGridView1.CurrentRow.Cells["Eliminar"];
                    DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                    if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                    {
                        if (TieneGafeteActivoEnOperador(dataGridView1.CurrentRow.Cells["Gafete"].Value.ToString().Trim())){                        
                            MessageBox.Show("La Persona: ["+dataGridView1.CurrentRow.Cells["Nombre"].Value+"] Con Gafete: ["+dataGridView1.CurrentRow.Cells["Gafete"].Value+"] Tiene Asignado Gafete En Caseta Operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                      
                            check.Value = false;
                            check.ReadOnly = true;
                            cell.ReadOnly = true;                        
                        }
                        else
                        {
                            if (dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString() == txtCondutor.Text.Trim())
                            {                            
                                MessageBox.Show("No es posible eliminar al conductor de las lista de personas que ingresan", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                            
                                check.Value = false;
                                check.ReadOnly = true;
                                cell.ReadOnly = true;                            
                            }
                        }                    
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Eliminando Pasajeros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool TieneGafeteActivoEnOperador(string Gafete)
        {
            bool res = false;
            try
            {
                string query = "SELECT COUNT(*) TotalRegistros FROM AsignacionGafete WHERE Gafete1 = '" + Gafete + "' AND TieneSalida = 0 AND Activo = 1";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if(Convert.ToInt32(dr["TotalRegistros"].ToString()) > 0) { res = true; }
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio Un Error Al Intentar Validar Gafete Activo En Operador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            return res;
        }

        private void ValidaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPlacasVehiculo.Focus();
            }
        }            

        private int HayFilasIncompletas()
        {
            int res = 0;
            try
            {                
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {                    
                    if((row.Cells["Nombre"].Value == null || row.Cells["Gafete"].Value == null) && !row.IsNewRow)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FEA592");
                        res++;
                    }                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Mostrando Filas Incompletas: " + ex.Message);
            }
            return res;
        }

        private void BorraDatosTarjeton(object sender, EventArgs e)
        {
            if (!EsEdicion)
            {
                txtTarjeton.Text = "";
            }            
        }

        private void BorrarCampoGafete(object sender, EventArgs e)
        {
            txtGafeteChofer.Text = "";
        }

        private void txtGafeteChofer_KeyPress(object sender, KeyPressEventArgs e)
        {          
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    int registroAcceso = 0;
                    if (txtRegistroAccesoID.Text != "")
                        registroAcceso = int.Parse(txtRegistroAccesoID.Text.Trim());
                    
                    if(!EsEdicion)
                    {
                        if (this.txtGafeteChofer.Text.Trim() != "")
                        {
                            if (chkEmpleado.Checked)
                            {
                                int i;
                                if (!int.TryParse(txtGafeteChofer.Text.Trim(), out i))
                                {
                                    MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LimpiarCampos();
                                    txtGafeteChofer.Text = "";
                                    txtGafeteChofer.Focus();
                                }
                                else
                                {
                                    if (!ExisteGafeteActivoEmpleado(txtGafeteChofer.Text.Trim()))
                                    {
                                        ObtenerInfoTrabajadorIBIX(txtGafeteChofer.Text.Trim().ToUpper());
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya Existe Una Persona Con El Mismo Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        LimpiarCampos();
                                        txtGafeteChofer.Text = "";
                                        txtGafeteChofer.Focus();
                                    }
                                }                                    
                            }
                            else //CONTINUA PROCESO COMO ESTABA NORMALMENTE
                            {
                                //VALIDO SI LA NOMENCLATURA DEL GAFETE ES CORRECTA
                                if (CodigoGafeteCorrecto(txtGafeteChofer.Text.Trim().ToUpper()))
                                {
                                    string _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + txtGafeteChofer.Text.Trim() + "' AND RegistroAccesoID <> " + registroAcceso + " AND Activo = 1";
                                    SqlCommand cmd = new SqlCommand(_sql, conexion);
                                    if (conexion.State == ConnectionState.Closed)
                                        conexion.Open();
                                    SqlDataReader reader = cmd.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        if (int.Parse(reader["TotalRegistros"].ToString()) > 0)
                                        {
                                            MessageBox.Show("Este gafete esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            this.txtGafeteChofer.Text = "";
                                            this.txtGafeteChofer.Focus();
                                        }
                                        else
                                        {
                                            txtCondutor.Focus();
                                        }
                                    }
                                    reader.Close();                                    
                                    conexion.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Codigo De Gafete Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                    
                                    txtGafeteChofer.Text = "";
                                    txtGafeteChofer.Focus();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Gafete!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                            
                        }
                    }else //ES EDICION
                    {
                        if (txtGafeteChofer.Text.Trim() != "")
                        {
                            if (chkEmpleado.Checked) //HABILITAR VALIDACIONES PARA EMPLEADOS
                            {
                                int i;
                                if (int.TryParse(txtGafeteChofer.Text.Trim(), out i))
                                {                                    
                                    ObtenerInfoTrabajadorIBIX(txtGafeteChofer.Text.Trim().ToUpper());
                                }
                                else
                                {
                                    MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LimpiarCampos();
                                    txtGafeteChofer.Text = "";
                                    txtGafeteChofer.Focus();
                                }
                            }else
                            {
                                //VALIDO SI LA NOMENCLATURA DEL GAFETE ES CORRECTA
                                if (CodigoGafeteCorrecto(txtGafeteChofer.Text.Trim().ToUpper()))
                                {
                                    string _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + txtGafeteChofer.Text.Trim() + "' AND RegistroAccesoID <> " + registroAcceso + " AND Activo = 1";
                                    SqlCommand cmd = new SqlCommand(_sql, conexion);
                                    if (conexion.State == ConnectionState.Closed)
                                        conexion.Open();
                                    SqlDataReader reader = cmd.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        if (int.Parse(reader["TotalRegistros"].ToString()) > 0)
                                        {
                                            MessageBox.Show("Este gafete esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            this.txtGafeteChofer.Text = "";
                                            this.txtGafeteChofer.Focus();
                                        }
                                        else
                                        {
                                            txtCondutor.Focus();
                                        }
                                    }
                                    reader.Close();
                                    if (conexion.State == ConnectionState.Open)
                                        conexion.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Codigo De Gafete Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                    
                                    txtGafeteChofer.Text = "";
                                    txtGafeteChofer.Focus();
                                }
                            }
                        }                    
                        else
                        {
                            MessageBox.Show("Ingrese Gafete!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                            
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }

        private void ObtenerInfoTrabajadorIBIX(string Gafete)
        {
            try
            {
                string query = " SELECT " +
                    " ISNULL(RS.RegistroAccesoID, 0) RegistroAccesoID, " +
                    " ISNULL(RP.RegistroPersonasID, 0) RegistroPersonasID, " +
                    " ISNULL(RP.Gafete, '') GafeteRP, " +
                    " T.Trabajador Gafete, " +
                    " ISNULL(RS.Asunto, '') Asunto , " +
                    " ISNULL(RS.Comentarios, '') Descripcion, " +
                    " T.Nombre, " +                    
                    " D.Depto DepartamentoID, " +
                    " CASE WHEN D.Nombre = '' THEN 'BLA' ELSE D.Nombre END Departamento, " +
                    " E.NombreCorto Compania " +
                " FROM " + 
                    " IBIX.IBIXLocal.dbo.tblTrabajador T WITH(NOLOCK) " +
                    " INNER JOIN IBIX.IBIXLocal.dbo.tblDepto D WITH(NOLOCK) ON T.Depto = D.Depto COLLATE Modern_Spanish_CS_AS AND D.Emp = 1 " + //-- AND D.Nombre <> ''
                    " INNER JOIN IBIX.IBIXLocal.dbo.tblEmpresa E WITH(NOLOCK) ON T.Emp = E.Emp " +
                    " LEFT JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON CAST(T.Trabajador AS VARCHAR) = RP.Gafete AND RP.Salida = 0 AND RP.Activo = 1 " +
                    " LEFT JOIN RegistroAccesoSteelgo RS WITH(NOLOCK) ON RP.RegistroAccesoID = RS.RegistroAccesoID " +
                " WHERE " +
                    " T.Trabajador = '" + Gafete + "' "; 
                        
                SqlCommand cmd = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();                                                
                if (reader.Read())
                {
                    BloquearCampos(1);
                    txtGafeteChofer.Text = reader["Gafete"].ToString();
                    txtCondutor.Text = reader["Nombre"].ToString();
                    if(reader["Departamento"].ToString() != "BLA")
                    {
                        cmbDepartamento.SelectedValue = reader["DepartamentoID"].ToString();
                        cmbDepartamento.Text = reader["Departamento"].ToString();
                        DepartamentoBLA = "";
                    }
                    else
                    {
                        DepartamentoBLA = reader["Departamento"].ToString();
                        cmbDepartamento.Text = "";
                    }
                    //cmbDepartamento.Text = reader["Departamento"].ToString();                    
                    //cmbDepartamento.SelectedIndex = cmbDepartamento.FindStringExact(reader["DepartamentoID"].ToString());
                    txtCompania.Text = reader["Compania"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                }else
                {
                    MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                    txtGafeteChofer.Text = "";
                    txtGafeteChofer.Focus();                    
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Obteniendo Informacion Empleado IBIX: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }    
        

        private string GetInforEmpleadoGrid(string Gafete)
        {
            string nombre = "";
            try
            {
                int i;
                if (int.TryParse(Gafete.Trim(), out i))
                {
                    string query = " SELECT Nombre FROM IBIX.IBIXLocal.dbo.tblTrabajador WITH(NOLOCK) WHERE Trabajador = '" + Gafete + "' "; //AND Activo = 1
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        nombre = reader["Nombre"].ToString();
                    }
                    reader.Close();
                    conexion.Close();
                }else
                {
                    nombre = "ERROR";
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Obteniendo Informacion Empleado IBIX (GRID): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombre;
        }


        private void BloquearCampos(int Opc)
        {
            if(Opc == 1) //bloquear
            {
                txtCondutor.Enabled = false;
                cmbDepartamento.Enabled = false;
                txtCompania.Enabled = false;
                cmbAsunto.Enabled = false;
                txtDescripcion.Enabled = false;
            }
            else
            {
                txtCondutor.Enabled = true;
                cmbDepartamento.Enabled = true;
                txtCompania.Enabled = true;
                cmbAsunto.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            
        }
       private void LimpiarCampos()
        {
            txtCondutor.Text = "";
            cmbDepartamento.Text = "";
            txtCompania.Text = "";
            cmbAsunto.Text = "";
            txtDescripcion.Text = "";
        }
        private void ValidaTextoConductor(object sender, KeyPressEventArgs e)
        {                        
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReplicaNombreGafeteGridToForm(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > -1 && !dataGridView1.CurrentRow.IsNewRow)
                {
                    if (dataGridView1.CurrentRow.Index == 0) //DATOS DE CHOFER
                    {
                        BeginInvoke(new Action(delegate {
                            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Nombre" || dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Gafete")
                            {
                                if (dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value != null)
                                {
                                    txtCondutor.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                                }
                                if (dataGridView1.Rows[e.RowIndex].Cells["Gafete"].Value != null)
                                {
                                    txtGafeteChofer.Text = dataGridView1.Rows[e.RowIndex].Cells["Gafete"].Value.ToString();
                                }
                            }
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Replicando Nombre Y Gafete de Grid a TextBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaCodigoGafete(object sender, KeyEventArgs e)
        {
            BeginInvoke(new Action(delegate {
                if (txtGafeteChofer.Text.Contains("\'"))
                {
                    txtGafeteChofer.Text = txtGafeteChofer.Text.Trim().Replace("\'", "-");
                    txtGafeteChofer.SelectionStart = txtGafeteChofer.Text.Length;
                    txtGafeteChofer.ScrollToCaret();
                }                                        
            }));
        }
        private string ValidaCodigoGafeteGrid(string Gafete)
        {
            
            if (Gafete.Contains("\'"))
            {
                Gafete = Gafete.Trim().Replace("\'", "-");                                        
            }
            return Gafete;
        }

        private bool CodigoGafeteCorrecto(string gafete)
        {
            bool status = true;
            string Leyenda = "ADM-";            
            try
            {
                if (chkEmpleado.Checked)
                {
                    int i;
                    if (!int.TryParse(gafete.Trim(), out i))
                    {
                        MessageBox.Show("Codigo De Trabajador Incorrecto, Por Favor Verifique Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGafeteChofer.Text = "";
                        txtGafeteChofer.Focus();
                        return false;
                    }
                }
                else
                {
                    if(gafete != "")
                {
                    if (!gafete.Trim().ToUpper().StartsWith(Leyenda))
                        status = false;                    
                }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Codigo de Gafete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        private bool CodigoGafeteCorrectoGRID(string gafete, bool check)
        {
            bool status = true;
            string Leyenda = "ADM-";
            try
            {
                if (check)
                {
                    int i;
                    if (!int.TryParse(gafete.Trim(), out i))
                    {
                        MessageBox.Show("Codigo De Trabajador Incorrecto, Por Favor Verifique Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                                
                        status = false;
                    }
                }
                else
                {
                    if (gafete != "")
                    {
                        if (!gafete.Trim().ToUpper().StartsWith(Leyenda))
                            status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Codigo de Gafete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.Add();
            }                            
            if (chkEmpleado.Checked)
            {
                BloquearCampos(1);
                txtGafeteChofer.Text = "";
                dataGridView1.Rows[0].Cells["EsEmpleado"].Value = true;                
            }
            else
            {
                BloquearCampos(0);
                txtGafeteChofer.Text = "";
                dataGridView1.Rows[0].Cells["EsEmpleado"].Value = false;                
            }         
        }

        private void ValidaCheckEmpleado(object sender, DataGridViewCellEventArgs e)
        {            
        }

        private void DataGridViewError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is 
            // commited, display an error message.
            if (e.Exception != null && e.ThrowException)
            {
                MessageBox.Show("Ocurrió Un Error Inesperado en el DataGrid: " + e.Exception.Message);
            }
        }

        private void ValidarCheckGrid()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Gafete"].Value != null && row.Cells["Nombre"].Value != null)
                {
                    row.Cells["EsEmpleado"].ReadOnly = true;
                }
                else
                {
                    row.Cells["EsEmpleado"].ReadOnly = false;
                }
            }
        }
        private bool ExisteGafeteActivoEmpleado(string Gafete)
        {
            bool result = false;            
            try
            {               
                string _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + Gafete + "' AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sql, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["TotalRegistros"].ToString()) > 0)
                    {
                        result = true;
                    }
                }
                reader.Close();
                conexion.Close();                            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Verficando Gafete Duplicado De Empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public string GetIDDepto(string DeptoText)
        {
            string queryGetDepaID = "SELECT TOP 1 Depto FROM IBIX.IBIXLocal.dbo.tblDepto WHERE Nombre = '" + DeptoText + "' ";
            string depaIdDB = "";
            SqlCommand cmdGetDepaID = new SqlCommand(queryGetDepaID, conexion);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            SqlDataReader leeDepaID = cmdGetDepaID.ExecuteReader();
            if (leeDepaID.Read())
            {
                depaIdDB = leeDepaID["Depto"].ToString();
            }
            leeDepaID.Close();
            conexion.Close();
            return depaIdDB;
        }
    }   
}

