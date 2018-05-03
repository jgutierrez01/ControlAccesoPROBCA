using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class SalidaDePersonal : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);     
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public SalidaDePersonal()
        {
            InitializeComponent();
            this.txtGafete.Focus();
        }

        internal void SalidaDesdeGrid(int RegistroPersonaID)
        {
            try
            {
                BloquerCampos();
                LlenarDatosPersona(RegistroPersonaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error En Salida Desde Grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarDatosPersona(int RegistroPersonaID)
        {
            try
            {                
                string query = "SELECT " +
                                       "RP.RegistroPersonasID, " +
                                       "RP.RegistroAccesoID,  " +
                                       "RP.Nombre,  " +
                                       "RP.Gafete,  " +
                                       "RP.Salida,  " +
                                       "RP.FechaEntrada, " +
                                       "RS.Asunto, " +
                                       "CASE WHEN RS.Departamento = 'BLA' OR RS.Departamento IS NULL THEN '' ELSE RS.Departamento END Departamento, " +
                                       "ISNULL(RS.Comentarios, 'NA') Descripcion, " +
                                       "ISNULL(RS.Compania, 'NA') Compania " +
                                   "FROM " +
                                       " RegistroAccesoPersonas RP " +
                                       " LEFT JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = RP.RegistroAccesoID AND RS.Activo = 1 AND TieneSalida = 0 " +
                                       " LEFT JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 " +                                       
                                   " WHERE " +
                                       " RP.RegistroPersonasID = " + RegistroPersonaID + " AND RP.Salida = 0 AND RP.Activo = 1";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlCommand _sql = new SqlCommand(query, conexion);                
                SqlDataReader reader = _sql.ExecuteReader();                
                if (reader.Read())
                {
                    txtClaveRegistroPersona.Text = reader["RegistroPersonasID"].ToString();
                    txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                    txtGafete.Text = reader["Gafete"].ToString();
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtAsunto.Text = reader["Asunto"].ToString();
                    txtDepartamento.Text = reader["Departamento"].ToString();
                    txtCompania.Text = reader["Compania"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                    txtFechaEntrada.Text = DateTime.Parse(reader["FechaEntrada"].ToString(), null).ToString("dd/MM/yyyy");
                    txtHoraEntrada.Text = DateTime.Parse(reader["FechaEntrada"].ToString(), null).ToString("hh:mm:ss tt");
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Obteniendo Datos De Persona : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   
        }
        
        private void BuscarPersonaEnter(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    LimpiarCampos();
                    if (this.txtGafete.Text != "")
                    {
                        string query = "SELECT " +
                                        "RP.RegistroPersonasID, " +
                                        "RP.RegistroAccesoID,  " +
                                        "RP.Nombre,  " +
                                        "RP.Gafete,  " +
                                        "RP.Salida,  " +
                                        "RP.FechaEntrada, " +
                                        "RS.Asunto, " +
                                        "D.Depto DepartamentoID, " +
                                        "D.Nombre Departamento, " +
                                        "ISNULL(RS.Comentarios, 'NA') Descripcion, " +
                                        "ISNULL(RS.Compania, 'NA') Compania " +
                                    "FROM " +
                                        " RegistroAccesoPersonas RP " +
                                        " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = RP.RegistroAccesoID AND RS.Activo = 1 " +                                        
                                        " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D WITH(NOLOCK) ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 " +
                                    " WHERE " +
                                        " RP.Gafete = '"+txtGafete.Text.Trim()+"' AND RP.Salida = 0 AND RP.Activo = 1";

                        SqlCommand _sql = new SqlCommand(query, conexion);
                        conexion.Open();
                        SqlDataReader reader = _sql.ExecuteReader();
                        if (reader.Read())
                        {
                            this.txtClaveRegistroPersona.Text = reader["RegistroPersonasID"].ToString();
                            this.txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                            this.txtNombre.Text = reader["Nombre"].ToString();
                            this.txtAsunto.Text = reader["Asunto"].ToString();
                            this.txtDepartamento.Text = reader["Departamento"].ToString();
                            this.txtCompania.Text = reader["Compania"].ToString();
                            this.txtDescripcion.Text = reader["Descripcion"].ToString();
                            this.txtFechaEntrada.Text = DateTime.Parse(reader["FechaEntrada"].ToString(), null).ToString("dd/MM/yyyy");
                            this.txtHoraEntrada.Text = DateTime.Parse(reader["FechaEntrada"].ToString(), null).ToString("hh:mm:ss tt");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró coincidencias con este gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtGafete.Text = "";
                            this.txtGafete.Focus();
                        }
                        reader.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese el numero del gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
          
            if(txtGafete.Text == "")
            {
                LimpiarCampos();
            }          
        }
        private void LimpiarCampos()
        {
            this.txtClaveRegistroPersona.Text = "";
            this.txtNombre.Text = "";
            this.txtAsunto.Text = "";
            this.txtDepartamento.Text = "";
            this.txtCompania.Text = "";
            this.txtDescripcion.Text = "";
            this.txtFechaEntrada.Text = "";
            this.txtHoraEntrada.Text = "";
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.dtFechaSalida.Value = DateTime.Now;
            this.dtHoraSalida.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.txtGafete.Text != ""){
                try
                {
                    string query = "";     
                    string FechaSalida = this.dtFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    int RegistroPersonaID = int.Parse(this.txtClaveRegistroPersona.Text.Trim());
                    int RegistroAccesoID = int.Parse(this.txtRegistroAccesoID.Text.Trim());

                    //VERIFICO SI TIENE GAFETE ACTIVO EN CASETA OPERADOR
                    if(EstaActivoEnCasetaOperador(txtGafete.Text.Trim(), RegistroPersonaID))
                    {
                        MessageBox.Show("La Persona Tiene Gafete Activo En Caseta Operador, Por Favor Registrar Salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }else
                    {
                        //VERIFICO SI LA PERSONA ES CHOFER, SI LO ES SE DEBE ASIGNAR A UN PASAJERO DEL LO CONTRARIO NO PERMITIR SALIDA POR ESTE MEDIO
                        //Y DEBE SALIR CON EL VEHICULO EN LA OTRA PANTALLA
                        if (EsChofer(RegistroPersonaID))
                        {
                            //OBTENGO NUMERO DE PASAJEROS
                            query = " SELECT " +
                                       " COUNT(*) NumPasajeros	 " +                                       
                                    " FROM " +
                                        " RegistroAccesoSteelgo RS WITH(NOLOCK) " +
                                        " INNER JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroAccesoID = RS.RegistroAccesoID AND RP.Salida = 0 AND RP.Activo = 1 AND Chofer = 0 " +
                                    " WHERE " +
                                        " RS.RegistroAccesoID = " + RegistroAccesoID;
                            if (conexion.State == ConnectionState.Closed)
                                conexion.Open();
                            SqlCommand cm = new SqlCommand(query, conexion);
                            SqlDataReader re = cm.ExecuteReader();
                            int NumPasajeros = 0;
                            if (re.Read())
                            {
                                NumPasajeros = Convert.ToInt32(re["NumPasajeros"].ToString());
                            }
                            re.Close();                            
                            if(NumPasajeros > 0)
                            {
                                //ASIGNO EL CARRO A UN PASAJERO
                                query = "";
                                query = " SELECT TOP 1 " +
                                           " RP.RegistroPersonasID,	 " +
                                           " RP.Nombre " +
                                        " FROM " +
                                            " RegistroAccesoSteelgo RS WITH(NOLOCK) " +
                                            " INNER JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroAccesoID = RS.RegistroAccesoID AND RP.Salida = 0 AND RP.Activo = 1 AND Chofer = 0 " +
                                        " WHERE " +
                                            " RS.RegistroAccesoID = " + RegistroAccesoID;
                                cm = null;
                                if (conexion.State == ConnectionState.Closed)
                                    conexion.Open();
                                cm = new SqlCommand(query, conexion);
                                if (re.IsClosed)
                                    re = cm.ExecuteReader();
                                int IdNuevoChofer = 0;
                                string NombreNuevoChofer = "";
                                if (re.Read())
                                {
                                    IdNuevoChofer = Convert.ToInt32(re["RegistroPersonasID"].ToString());
                                    NombreNuevoChofer = re["Nombre"].ToString();
                                }
                                re.Close();
                                //DOY SALIDA AL CHOFER
                                query = "";
                                query = "UPDATE RegistroAccesoPersonas SET Salida = 1, Chofer = 0, FechaSalida = '" + dtFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE RegistroPersonasID = " + RegistroPersonaID + " AND Chofer = 1 AND Activo = 1";
                                cm = null;
                                if (conexion.State == ConnectionState.Closed)
                                    conexion.Open();
                                cm = new SqlCommand(query, conexion);
                                int rowA = cm.ExecuteNonQuery();
                                if(rowA > 0)
                                {
                                    //ACTUALIZO DATOS DEL NUEVO CHOFER
                                    query = "";
                                    query += "UPDATE RegistroAccesoPersonas SET Chofer = 1 WHERE RegistroPersonasID = " + IdNuevoChofer + " AND Salida = 0 AND Activo = 1; ";
                                    query += "UPDATE RegistroAccesoSteelgo SET Conductor = '" + NombreNuevoChofer + "' WHERE RegistroAccesoID = " + RegistroAccesoID + " AND TieneSalida = 0 AND Activo = 1;";
                                    cm = null;
                                    if (conexion.State == ConnectionState.Closed)
                                        conexion.Open();
                                    cm = new SqlCommand(query, conexion);
                                    rowA = 0;
                                    rowA = cm.ExecuteNonQuery();
                                    if(rowA > 0)
                                    {
                                        MessageBox.Show("Salida guardada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LimpiarCampos();
                                        this.Close();
                                    }else
                                    {
                                        MessageBox.Show("No se actualizaron los registros, reintente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }else
                                {
                                    MessageBox.Show("No se actualizaron los registros, reintente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por Favor Registre La Salida del Vehiculo En La Ventana de Salida De Vehiculo/Autobus", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            if (conexion.State == ConnectionState.Open)
                                conexion.Close();
                        }else
                        {
                            query = "";
                            if (EsConductor(txtNombre.Text.Trim().ToUpper()))
                            {
                                query += "UPDATE RegistroAccesoPersonas SET Salida = 1, FechaSalida = '" + FechaSalida + "' WHERE RegistroPersonasID = " + RegistroPersonaID + " AND Salida = 0 AND Activo = 1";
                                query += "UPDATE RegistroAccesoSteelgo SET TieneSalida = 1, FechaHoraSalida = '" + FechaSalida + "' WHERE RegistroAccesoID = " + RegistroAccesoID + " AND TieneSalida = 0 AND Activo = 1";
                            }
                            else
                            {
                                query += "UPDATE RegistroAccesoPersonas SET Salida = 1, FechaSalida = '" + FechaSalida + "' WHERE RegistroPersonasID = " + RegistroPersonaID + " AND Salida = 0 AND Activo = 1";
                            }
                            SqlCommand _sql = new SqlCommand(query, conexion);
                            conexion.Open();
                            int rowAffected = _sql.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Salida guardada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se actualizaron los registros, reintente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            if (conexion.State == System.Data.ConnectionState.Open)
                                conexion.Close();
                        }                                                
                    }                                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Por favor ingrese numero de gafete de la persona a salir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    if (Convert.ToInt32(reader["Total"].ToString()) > 0) { res = true; }
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
                                    " CASE WHEN RS.Conductor = RP.Nombre THEN 1 ELSE 0 END Result " +
                                " FROM " +
                                    " RegistroAccesoPersonas RP " +
                                    " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = RP.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +
                                " WHERE " +
                                    " (RS.Conductor = '" + Nombre + "' AND RS.Conductor = RP.Nombre) AND RP.Salida = 0 AND RP.Activo = 1 ";
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
                MessageBox.Show("Error Verificando si es conductor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }
        private void BloquerCampos()
        {
            txtGafete.Enabled = false;
            txtNombre.Enabled = false;
            txtAsunto.Enabled = false;
            txtDepartamento.Enabled = false;
            txtCompania.Enabled = false;
            txtDescripcion.Enabled = false;
            txtFechaEntrada.Enabled = false;
            txtHoraEntrada.Enabled = false;
        }
        private bool EsChofer(int RegistroPersonasID)
        {
            bool res = false;
            try
            {
                string query = "SELECT COUNT(*) Result FROM RegistroAccesoPersonas WHERE RegistroPersonasID = " + RegistroPersonasID + " AND Salida = 0 AND Chofer = 1 AND Activo = 1";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Result"].ToString()) > 0) { res = true; }
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Verificando Si Es Chofer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

    }
}
