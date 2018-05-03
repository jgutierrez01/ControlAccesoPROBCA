using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class EntradaDePersonal : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        /*CONEXION IBIX*/
        SqlConnection conexionIBIX = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionIBIX"].ConnectionString);
        
        public string DepartamentoBLA = "";
        public string DepaText = "";
        public string DepaID = "";

        public bool EsEdicion = false;
        public EntradaDePersonal()
        {
            InitializeComponent();
            if (!EsEdicion)
            {
                txtGafete.Focus();
                //LlenaComboAsunto();
                LlenaComboDepartamento();
                LlenaComboCompania();
            }            
        }
        
        
        private void ToUpper(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LlenaComboAsunto()
        {
            SqlCommand _sql = new SqlCommand("SELECT Asunto FROM RegistroAccesoSteelgo WHERE Asunto IS NOT NULL AND Asunto <> '' GROUP BY Asunto ORDER BY Asunto ASC", conexion);
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
        private void LlenaComboDepartamento()
        {
            try
            {
                if (conexionIBIX != null)
                {
                    if (conexionIBIX.State == ConnectionState.Closed)
                        conexionIBIX.Open();
                    SqlCommand _sql = new SqlCommand("SELECT Depto DepartamentoID, Nombre Departamento FROM tblDepto WHERE Activo = 1 AND Emp = 1 ", conexionIBIX);                    
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

        private void LlenaComboCompania()
        {
            SqlCommand _sql = new SqlCommand("SELECT Compania FROM RegistroAccesoSteelgo WHERE Compania IS NOT NULL AND Compania <> '' GROUP BY Compania", conexion);
            conexion.Open();
            SqlDataReader reader = _sql.ExecuteReader();
            AutoCompleteStringCollection elementos = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                cmbCompania.Items.Add(reader["Compania"].ToString());
                elementos.Add(reader["Compania"].ToString());
            }
            cmbCompania.AutoCompleteCustomSource = elementos;
            cmbCompania.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCompania.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            reader.Close();
            conexion.Close();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            dtpFechaEntrada.Value = DateTime.Now;
            dtpHoraEntrada.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (this.txtGafete.Text.Trim() == "" && !chkEmpleado.Checked)
            {
                MessageBox.Show("Por favor ingrese gafete de la persona a ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtGafete.Focus();
            }
            else if (this.txtNombre.Text.Trim() == "" && !chkEmpleado.Checked)
            {
                MessageBox.Show("Por favor ingrese nombre de la persona a ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNombre.Focus();                
            }
            else if ((cmbAsunto.Text.Trim() == "" || !Asuntocorrecto()) && !chkEmpleado.Checked)
            {
                MessageBox.Show("Por favor seleccione el asunto de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbAsunto.Focus();
            }
            else if ((this.cmbDepartamento.Text.Trim() == "" || this.cmbDepartamento.SelectedValue == null) && !chkEmpleado.Checked)
            {
                MessageBox.Show("Por favor ingrese el departemento al que se dirije la persona a ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbDepartamento.Focus();
            }
            else
            {
                if (!EsEdicion)
                {
                    string FechaEntrada = dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss"), nombre = this.txtNombre.Text.Trim(), gafete = this.txtGafete.Text.Trim(), asunto = this.cmbAsunto.Text, compania = this.cmbCompania.Text, descripcion = this.txtDescripcion.Text;
                    try
                    {
                        string depaID = chkEmpleado.Checked && DepartamentoBLA != "" ? DepartamentoBLA : GetIDDepto(cmbDepartamento.Text.Trim());
                        int IdentityRegistroAcceso = InsertaAccesoSteelgo(FechaEntrada, depaID, asunto, descripcion, compania, nombre);                        
                        if (IdentityRegistroAcceso != 0)
                        {
                            string _sql = "INSERT INTO RegistroAccesoPersonas (RegistroAccesoID, Nombre, Gafete, FechaEntrada, Chofer, EsEmpleado) VALUES (@RegistroAccesoID, @Nombre, @Gafete, @FechaEntrada, 0, " + (chkEmpleado.Checked ? 1 : 0) + ")";
                            SqlCommand cmd = new SqlCommand(_sql, conexion);
                            cmd.Parameters.AddWithValue("@RegistroAccesoID", IdentityRegistroAcceso);
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@Gafete", gafete);
                            cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
                            conexion.Open();
                            int affected = cmd.ExecuteNonQuery();
                            if (affected > 0)
                            {
                                MessageBox.Show("Se completo el registro correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un problema en el registro de entrada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            if (conexion.State == System.Data.ConnectionState.Open)
                                conexion.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un problema al insertar el acceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else //ES EDICION DE DATOS
                {
                    try
                    {
                        //VERIFICO SI ES CHOFER
                        string sql = "";
                        sql = "SELECT COUNT(*) Result FROM RegistroAccesoPersonas WHERE RegistroPersonasID = " + txtRegistroPersonasID.Text.Trim() + " AND Chofer = 1 AND Salida = 0 AND Activo = 1";
                        SqlCommand exe = new SqlCommand(sql, conexion);
                        if (conexion.State == ConnectionState.Closed)
                            conexion.Open();
                        SqlDataReader result = exe.ExecuteReader();
                        bool EsChofer = false;
                        if (result.Read())
                        {
                            if(Convert.ToInt32(result["Result"].ToString()) > 0) { EsChofer = true; }
                        }
                        result.Close();
                        conexion.Close();
                        if (EsChofer)
                        {
                            //SI ES CHOFER Y SI ESTA ACTIVO ACTUALIZO LOS DATOS
                            sql = "";                            
                            sql = "UPDATE RegistroAccesoSteelgo SET " +
                                        " Conductor = '" + txtNombre.Text.Trim() + "', " +
                                        " Asunto = '" + cmbAsunto.Text + "', " +
                                        " DepartamentoID = '" + cmbDepartamento.SelectedValue + "', " +
                                        " Departamento = '" + cmbDepartamento.Text  + "', " +
                                        " Compania = '" + cmbCompania.Text + "', " +
                                        " Comentarios = '" + txtDescripcion.Text + "' " +
                                " WHERE " +
                                        " RegistroAccesoID = " + txtRegistroAccesoID.Text.Trim() + " AND Activo = 1 AND TieneSalida = 0; " +
                                " UPDATE RegistroAccesoPersonas SET " +
                                        " Nombre = '" + txtNombre.Text.Trim() + "', " +
                                        " Gafete = '" + txtGafete.Text.Trim() + "' " +
                                " WHERE " +
                                        " RegistroPersonasID = " + txtRegistroPersonasID.Text.Trim() + " AND RegistroAccesoID = " + txtRegistroAccesoID.Text.Trim() + " AND Activo = 1 AND Salida = 0;";
                            
                            if (conexion.State == ConnectionState.Closed)
                                conexion.Open();
                            SqlCommand exe2 = new SqlCommand(sql, conexion);
                            int res = exe2.ExecuteNonQuery();
                            if(res > 0)
                            {
                                MessageBox.Show("Datos Actualizados Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Por Favor Verifique la informacion y vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }                            
                        }
                        else
                        {
                            sql = "";
                            sql = "UPDATE RegistroAccesoSteelgo SET " +
                                        " Asunto = '" + cmbAsunto.Text + "', " +
                                        " DepartamentoID = '" + cmbDepartamento.SelectedValue + "', " +
                                        " Departamento = '" + cmbDepartamento.Text.Trim() + "', " +
                                        " Compania = '" + cmbCompania.Text + "', " +
                                        " Comentarios = '" + txtDescripcion.Text + "' " +
                                " WHERE " +
                                        " RegistroAccesoID = " + txtRegistroAccesoID.Text.Trim() + " AND Activo = 1; " +

                                " UPDATE RegistroAccesoPersonas SET " +
                                            " Nombre = '" + txtNombre.Text.Trim() + "', " +
                                            " Gafete = '" + txtGafete.Text.Trim() + "' " +
                                    " WHERE " +
                                            " RegistroPersonasID = " + txtRegistroPersonasID.Text.Trim() + " AND RegistroAccesoID = " + txtRegistroAccesoID.Text.Trim() + " AND Activo = 1 AND Salida = 0;";
                                                      
                            SqlCommand cmd2 = new SqlCommand(sql, conexion);
                            if (conexion.State == System.Data.ConnectionState.Closed)
                                conexion.Open();
                            int rowAffected = cmd2.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Datos Actualizados Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Por Favor Verifique la informacion y vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }                            
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }            
        }

        private int InsertaAccesoSteelgo(string FechaEntrada, string departamentoID, string asunto, string descripcion, string compania, string nombre)
        {
            int RegistroAccesoID = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO RegistroAccesoSteelgo (FechaHoraEntrada, Departamento, DepartamentoID, Asunto, TieneSalida, Comentarios, Conductor, Compania) OUTPUT inserted.RegistroAccesoID VALUES (@FechaEntrada, @txtDepa, @Departamento, @Asunto, @TieneSalida, @Comentarios, @Conductor, @Compania)", conexion))
                {
                    cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
                    if(departamentoID == "BLA")
                    {
                        cmd.Parameters.AddWithValue("@txtDepa", departamentoID);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@txtDepa", cmbDepartamento.Text.Trim().ToUpper());
                    }                    
                    cmd.Parameters.AddWithValue("@Departamento", departamentoID);
                    cmd.Parameters.AddWithValue("@Asunto", asunto);
                    cmd.Parameters.AddWithValue("@TieneSalida", 0);
                    cmd.Parameters.AddWithValue("@Comentarios", descripcion);
                    cmd.Parameters.AddWithValue("@Conductor", nombre);
                    cmd.Parameters.AddWithValue("@Compania", compania);
                    conexion.Open();
                    RegistroAccesoID = (int)cmd.ExecuteScalar();
                    if (conexion.State == System.Data.ConnectionState.Open)
                        conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RegistroAccesoID;
        }

        private bool Asuntocorrecto()
        {
            bool result = false;
            try
            {
                if (cmbAsunto.Text != "")
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

        internal void EditarDatos(int RegistroAccesoID, int RegistroPersonaID, string Gafete)
        {                        
            ActivarCampos();
            LlenarInformacion(RegistroAccesoID, RegistroPersonaID, Gafete);
        }
        private void ActivarCampos()
        {
            this.txtNombre.Enabled = true;
            this.txtGafete.Enabled = true;
            this.cmbAsunto.Enabled = true;
            this.cmbDepartamento.Enabled = true;
            this.cmbCompania.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.Reloj.Enabled = false;
            this.dtpFechaEntrada.Enabled = false;
            this.dtpHoraEntrada.Enabled = false;
        }

        private void LlenarInformacion(int RegistroAccesoID, int RegistroPersonaID, string Gafete)
        {
            try
            {
                string query = "SELECT TOP 1 " +
                                " R.RegistroAccesoID, " +
                                " CONVERT(BIT, ISNULL(RP.EsEmpleado, 0)) EsEmpleado," +                                 
                                " RP.RegistroPersonasID, " +
                                " RP.Nombre, " +
                                " RP.Gafete, " +
                                " R.Asunto, " +
                                " D.Depto DepartamentoID, " +
                                " CASE WHEN R.Departamento = 'BLA' THEN '' ELSE R.Departamento END Departamento, " +
                                " R.Compania, " +
                                " R.Comentarios Descripcion, " +
                                " RP.FechaEntrada " +
                            " FROM " +
                                " RegistroAccesoSteelgo R WITH(NOLOCK) " +
                                " INNER JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroAccesoID = R.RegistroAccesoID AND RP.Activo = 1 " +
                                " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D WITH(NOLOCK) ON D.Depto = R.DepartamentoID AND D.Emp = 1   " +
                            " WHERE " +                            
                            " R.RegistroAccesoID = " + RegistroAccesoID + " AND RP.RegistroPersonasID = " + RegistroPersonaID + " AND Gafete = '" + Gafete + "' AND R.Activo = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chkEmpleado.Checked = Convert.ToBoolean(reader["EsEmpleado"].ToString());
                    this.txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                    this.txtRegistroPersonasID.Text = reader["RegistroPersonasID"].ToString();
                    this.txtNombre.Text = reader["Nombre"].ToString();
                    this.txtGafete.Text = reader["Gafete"].ToString();
                    this.cmbAsunto.Text = reader["Asunto"].ToString();
                    cmbDepartamento.SelectedValue = reader["DepartamentoID"].ToString();
                    this.cmbDepartamento.Text = reader["Departamento"].ToString();
                    this.cmbCompania.Text = reader["Compania"].ToString();
                    this.txtDescripcion.Text = reader["Descripcion"].ToString();
                    dtpFechaEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                    dtpHoraEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();

                if (chkEmpleado.Checked)
                {
                    BloquearCampos(1);
                }else
                {
                    BloquearCampos(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarGafete(object sender, KeyPressEventArgs e)
        {            
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {                    
                    if (this.txtGafete.Text.Trim() != "")
                    {
                        //SI ES EMPLEADO
                        if (chkEmpleado.Checked)
                        {
                            int i;
                            if (!int.TryParse(txtGafete.Text.Trim(), out i))
                            {
                                MessageBox.Show("No Se Encontró Información Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimpiarCampos();
                                txtGafete.Text = "";
                                txtGafete.Focus();
                            }
                            else
                            {
                                if (!ExisteGafeteActivoEmpleado(txtGafete.Text.Trim()))
                                {
                                    ObtenerInfoTrabajadorIBIX(txtGafete.Text.Trim());
                                }
                                else
                                {
                                    MessageBox.Show("Ya Existe Una Persona Con El Mismo Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LimpiarCampos();
                                    txtGafete.Text = "";
                                    txtGafete.Focus();
                                }
                            }                            
                        }else
                        {
                            //VALIDO CODIGO DE GAFETE
                            if (CodigoGafeteCorrecto(txtGafete.Text.Trim().ToUpper()))
                            {
                                string _sql = "";
                                if (EsEdicion)
                                {
                                    _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + this.txtGafete.Text.Trim() + "' AND Activo = 1 AND RegistroPersonasID <> " + Convert.ToInt32(txtRegistroPersonasID.Text.Trim());
                                }
                                else
                                {
                                    _sql = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + this.txtGafete.Text.Trim() + "' AND Activo = 1 ";
                                }
                                if (conexion.State == ConnectionState.Closed)
                                    conexion.Open();
                                SqlCommand cmd = new SqlCommand(_sql, conexion);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    if (int.Parse(reader["TotalRegistros"].ToString()) > 0)
                                    {
                                        MessageBox.Show("Este gafete esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.txtGafete.Text = "";
                                        this.txtGafete.Focus();
                                    }
                                    else
                                    {
                                        txtNombre.Focus();
                                    }
                                }
                                reader.Close();
                                if (conexion.State == ConnectionState.Open)
                                    conexion.Close();
                            }
                            else
                            {
                                MessageBox.Show("Codigo De Gafete Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafete.Text = "";
                                txtGafete.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }         
        }

        private void BorrarGafete(object sender, EventArgs e)
        {
            if (!EsEdicion)
            {
                txtGafete.Text = "";
            }            
        }

        private void SoloTextoCampoNombre(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidaCodigoGafete(object sender, KeyEventArgs e)
        {
            BeginInvoke(new Action(delegate {
                if (txtGafete.Text.Contains("\'"))
                {
                    txtGafete.Text = txtGafete.Text.Trim().Replace("\'", "-");
                    txtGafete.SelectionStart = txtGafete.Text.Length;
                    txtGafete.ScrollToCaret();
                }
            }));
        }
        private bool CodigoGafeteCorrecto(string gafete)
        {
            bool status = true;
            string Leyenda = "ADM-";
            try
            {
                if (gafete != "")
                {
                    if (!gafete.Trim().ToUpper().StartsWith(Leyenda))
                        status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Codigo de Gafete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        private void ValidarCodigoGafeteLeave(object sender, EventArgs e)
        {
            try
            {

                int txtRegistroPersonasID = 0;
                if (this.txtRegistroPersonasID.Text != "")
                    txtRegistroPersonasID = int.Parse(this.txtRegistroPersonasID.Text.Trim());

                if (this.txtGafete.Text != "")
                {
                    //SI ES EMPLEADO
                    if (chkEmpleado.Checked)
                    {
                        int i;
                        if (!int.TryParse(txtGafete.Text.Trim(), out i))
                        {
                            MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpiarCampos();
                            txtGafete.Text = "";
                            txtGafete.Focus();
                        }
                        else
                        {
                            if (!ExisteGafeteActivoEmpleado(txtGafete.Text.Trim()))
                            {
                                ObtenerInfoTrabajadorIBIX(txtGafete.Text.Trim());
                            }else
                            {
                                MessageBox.Show("Ya Existe Una Persona Con El Mismo Gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimpiarCampos();
                                txtGafete.Text = "";
                                txtGafete.Focus();
                            }                            
                        }
                    }
                    else
                    {
                        //VALIDO CODIGO DE GAFETE
                        if (CodigoGafeteCorrecto(txtGafete.Text.Trim().ToUpper()))
                        {
                            string _sqlGafete = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + this.txtGafete.Text.Trim() + "' AND RegistroPersonasID <> " + txtRegistroPersonasID + " AND Activo = 1";
                            SqlCommand cmd = new SqlCommand(_sqlGafete, conexion);
                            if (conexion.State == ConnectionState.Closed)
                                conexion.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                if (int.Parse(reader["TotalRegistros"].ToString()) > 0)
                                {
                                    MessageBox.Show("Este gafete esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.txtGafete.Text = "";
                                    this.txtGafete.Focus();
                                }
                                else
                                {
                                    txtNombre.Focus();
                                }
                            }
                            reader.Close();
                            conexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Codigo De Gafete Incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafete.Text = "";
                            txtGafete.Focus();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            if(txtRegistroPersonasID.Text != "")
            {
                if (MessageBox.Show("Realmente Desea Eliminar El Registro?", "Eliminar Registro Peatón", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (TieneGafeteActivoEnOperador(txtGafete.Text.Trim()))
                    {
                        MessageBox.Show("La Persona: [" + txtNombre.Text.Trim() + "] Con Gafete: [" + txtGafete.Text.Trim() + "] Tiene Asignado Gafete En Caseta Operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        EliminarPeaton();
                    }
                }
            }else
            {
                MessageBox.Show("El Registro No Existe, No Hay Elementos que Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (Convert.ToInt32(dr["TotalRegistros"].ToString()) > 0) { res = true; }
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

        private void EliminarPeaton()
        {
            try
            {
                string query = "UPDATE RegistroAccesoPersonas SET Activo = 0 WHERE RegistroPersonasID = " + Convert.ToInt32(txtRegistroPersonasID.Text.Trim());
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                int Result = cmd.ExecuteNonQuery();
                if (Result > 0)
                {
                    MessageBox.Show("Registro Eliminado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Eliminando Registro De Peatón: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void BloquearCampos(int Opc)
        {
            if(Opc == 1)
            {
                if (EsEdicion)
                {
                    chkEmpleado.Enabled = false;
                }
                else
                {
                    chkEmpleado.Enabled = true;
                }                
                txtNombre.Enabled = false;
                cmbAsunto.Enabled = false;
                cmbDepartamento.Enabled = false;
                cmbCompania.Enabled = false;
                txtDescripcion.Enabled = true;
            }else
            {
                if (EsEdicion)
                {
                    chkEmpleado.Enabled = false;
                }
                else
                {
                    chkEmpleado.Enabled = true;
                }                
                txtNombre.Enabled = true;
                cmbAsunto.Enabled = true;
                cmbDepartamento.Enabled = true;
                cmbCompania.Enabled = true;
                txtDescripcion.Enabled = true;
            }
        }


        private void ObtenerInfoTrabajadorIBIX(string Gafete)
        {
            try
            {
                string query = " SELECT " +
                    " ISNULL(RS.RegistroAccesoID, 0) RegistroAccesoID, " +
                    " ISNULL(RP.RegistroPersonasID, 0) RegistroPersonasID, " +                    
                    " T.Trabajador Gafete, " +
                    " ISNULL(RS.Asunto, '') Asunto , " +
                    " ISNULL(RS.Comentarios, '') Descripcion, " +
                    " T.Nombre, " +
                    " D.Depto DepartamentoID, " +
                    " CASE WHEN D.Depto = 'BLA' THEN D.Depto ELSE D.Nombre END  Departamento, " +
                    " E.NombreCorto Compania " +
                " FROM " +
                    " IBIX.IBIXLocal.dbo.tblTrabajador T WITH(NOLOCK) " +
                    " INNER JOIN IBIX.IBIXLocal.dbo.tblDepto D WITH(NOLOCK) ON T.Depto = D.Depto COLLATE Modern_Spanish_CS_AS AND D.Emp = 1 " +
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
                    txtGafete.Text = reader["Gafete"].ToString();
                    txtNombre.Text = reader["Nombre"].ToString();
                    if (reader["Departamento"].ToString() != "BLA")
                    {
                        cmbDepartamento.Text = reader["Departamento"].ToString();                        
                        DepartamentoBLA = "";                   
                    }
                    else
                    {
                        DepartamentoBLA = reader["Departamento"].ToString();
                        cmbDepartamento.Text = "";
                    }                    
                    cmbCompania.Text = reader["Compania"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                }
                else
                {
                    MessageBox.Show("No Se Encontró Informacion Con Este Gafete, Verifique Que El Trabajador Esta Activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                    txtGafete.Text = "";
                    txtGafete.Focus();
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Obteniendo Informacion Empleado IBIX: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbAsunto.Text = "";
            cmbDepartamento.Text = "";
            cmbCompania.Text = "";
            txtDescripcion.Text = "";
        }

        private void chkEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (chkEmpleado.Checked)
            {                
                BloquearCampos(1);
            }else
            {
                BloquearCampos(0);                
            }
            txtGafete.Text = "";
            txtGafete.Focus();
        }

        private bool ExisteGafeteActivoEmpleado(string Gafete)
        {
            bool result = false;
            try
            {
                string _sqlGetActivo = "SELECT COUNT(*) TotalRegistros FROM RegistroAccesoPersonas WHERE Salida = 0 AND Gafete = '" + Gafete + "' AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sqlGetActivo, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if(Convert.ToInt32(reader["TotalRegistros"].ToString()) > 0)
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
