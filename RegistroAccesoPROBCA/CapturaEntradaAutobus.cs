using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class CapturaEntradaAutobus : Form
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        public bool EsEdicion = false;
        private int PassedRegistroAccesoID = 0;
        private string tmpPlaca = "";
        public CapturaEntradaAutobus()
        {
            InitializeComponent();            
        }

        public void LlenarComboRutas()
        {            
            SqlCommand _sql = new SqlCommand("SELECT RutaID, UPPER(Nombre) Ruta FROM Ruta WHERE activo = 1", conexion);
            conexion.Open();
            SqlDataReader reader = _sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RutaID", typeof(int));
            dt.Columns.Add("Ruta", typeof(string));
            dt.Rows.Add();
            dt.Load(reader);
            cmbRutas.ValueMember = "RutaID";
            cmbRutas.DisplayMember = "Ruta";
            cmbRutas.DataSource = dt;
            reader.Close();
            conexion.Close();
        }
        
        internal void EditarDatos(int RegistroAccesoID)
        {
            PassedRegistroAccesoID = RegistroAccesoID;
            ActivarCampos();
            LlenarInformacion(RegistroAccesoID);
        }
        private void LlenarInformacion(int RegistroAccesoID) 
        {
            try
            {
                string query = "SELECT " +
                                " RS.RegistroAccesoID, " +
                                " RS.FechaHoraEntrada, " +
                                " RS.Placa, " +
                                " RS.Asunto, " +
                                " RS.Comentarios Descripcion, " +
                                " RS.Conductor, " +
                                " R.Nombre Ruta, " +
                                " R.RutaID, " +
                                " RS.CantidadPersonas " +
                            " FROM " +
                                " RegistroAccesoSteelgo RS " +
                                " INNER JOIN Ruta R ON R.RutaID = RS.RutaID AND R.Activo = 1 " +
                            " WHERE " +
                                " RS.RegistroAccesoID = "+RegistroAccesoID+" AND TieneSalida = 0 AND RS.Activo = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.txtClaveRegistro.Text = reader["RegistroAccesoID"].ToString();
                    this.txtPlacasVehiculo.Text = reader["Placa"].ToString();
                    this.txtCondutor.Text = reader["Conductor"].ToString();
                    this.txtCantidadPersonas.Text = reader["CantidadPersonas"].ToString();
                    this.cmbRutas.Text = reader["Ruta"].ToString();
                    this.dtpFechaEntrada.Value = Convert.ToDateTime(reader["FechaHoraEntrada"].ToString());
                    this.dtpHoraEntrada.Value = Convert.ToDateTime(reader["FechaHoraEntrada"].ToString());
                    this.txtDescripcion.Text = reader["Descripcion"].ToString();
                    tmpPlaca = reader["Placa"].ToString();
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActivarCampos()
        {
            this.txtPlacasVehiculo.Enabled = true;
            this.txtCondutor.Enabled = true;
            this.txtCantidadPersonas.Enabled = true;
            this.cmbRutas.Enabled = true;
            this.dtpFechaEntrada.Enabled = false;
            this.dtpHoraEntrada.Enabled = false;
            this.Reloj.Enabled = false;
            LlenarComboRutas();
            this.txtDescripcion.Enabled = true;
        }

        private void CapturaEntradaAutobus_Load(object sender, EventArgs e)
        {                         
            if (!EsEdicion)
            {
                LlenarComboRutas();
                txtClaveRegistro.Visible = false;
            }else
            {
                txtClaveRegistro.Visible = true;
            }
            this.txtPlacasVehiculo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(EsEdicion) //Edicion
            {
                try
                {
                    if(txtPlacasVehiculo.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese numero de placas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else if(txtCondutor.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese nombre del conductor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else if(txtCantidadPersonas.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese numero de personas a ingresar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else if(cmbRutas.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese la ruta ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }else
                    {
                        string _sql = "UPDATE RegistroAccesoSteelgo SET " +
                                " Placa = '" + this.txtPlacasVehiculo.Text.Trim() + "', " +
                                " Comentarios = '" + txtDescripcion.Text + "'," +
                                " Conductor = '" + txtCondutor.Text + "'," +
                                " Ruta = '" + cmbRutas.Text + "', " +
                                " RutaID = '" + cmbRutas.SelectedIndex.ToString() + "', " +
                                " CantidadPersonas = '" + txtCantidadPersonas.Text.Trim() + "' " +
                                " WHERE RegistroAccesoID = " + this.txtClaveRegistro.Text.Trim() + " AND EsAutobus = 1;";
                        SqlCommand cmd = new SqlCommand(_sql, conexion);
                        conexion.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al actualizar, por favor revise los datos y reitente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (conexion.State == System.Data.ConnectionState.Open)
                            conexion.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Edicion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                if (this.txtPlacasVehiculo.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor captura la Placa del vehiculo");
                    return;
                }               
                if (this.txtCantidadPersonas.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor capture la cantidad de personas del autobús");
                    return;
                }
                if (this.txtCondutor.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor capture el conductor.");
                    return;
                }
                if (this.cmbRutas.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor capture la ruta del autobús");
                    return;
                }

                conexion.Open();
                String query = "INSERT INTO RegistroAccesoSteelgo VALUES ('" +
                                this.dtpFechaEntrada.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                                this.txtPlacasVehiculo.Text + "', null, " + "'ENTRADA DE PERSONAL'" + ", 0, null, '" +
                                this.txtDescripcion.Text + "', '" +
                                this.txtCondutor.Text.Trim() + "', 1, '" +
                                this.cmbRutas.Text + "', " +
                                this.txtCantidadPersonas.Text.Trim() + ", 1, null, null, null, null, "+this.cmbRutas.SelectedIndex+")";
                SqlCommand cmd = new SqlCommand(query, conexion);
                //cmd.Parameters.AddWithValue("@RegistroID", RegistroAccesoID);
                cmd.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Se ingreso correctamente el nuevo registro", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            
        }

        private void txtCantidadPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPlacasVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '/' || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            this.dtpFechaEntrada.Value = DateTime.Now;
            this.dtpHoraEntrada.Value = DateTime.Now;
        }

        private void ValidarPlacas(object sender, EventArgs e)
        {
            try
            {               
                string sql = "SELECT COUNT(*) Total FROM RegistroAccesoSteelgo WHERE Placa = '"+txtPlacasVehiculo.Text.Trim()+"' AND TieneSalida = 0 AND Activo = 1 AND RegistroAccesoID <> " + PassedRegistroAccesoID;
                SqlCommand cmd = new SqlCommand(sql, conexion);
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (int.Parse(reader["Total"].ToString()) > 0)
                    {
                        if (EsEdicion)
                        {
                            MessageBox.Show("Ya Existe Registrado Este Número De Placas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPlacasVehiculo.Text = tmpPlaca;
                            txtPlacasVehiculo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Ya Existe Registrado Este Número De Placas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPlacasVehiculo.Text = "";
                            txtPlacasVehiculo.Focus();
                        }                        
                    }
                }                    
                reader.Close();
                conexion.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Placas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRutas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }
    }    
}
