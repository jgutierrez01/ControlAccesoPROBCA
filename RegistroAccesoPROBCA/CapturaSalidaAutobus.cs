using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAccesoPROBCA
{
    public partial class CapturaSalidaAutobus : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public CapturaSalidaAutobus()
        {
            InitializeComponent();
        }

        internal void LoadOrders(int RegistAccesoID)
        {
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();    
            String query = "select top 1 * from RegistroAccesoSteelgo where RegistroAccesoID = " + RegistAccesoID.ToString();
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds1, "Encabezado");

            this.txtClaveRegistro.Text = RegistAccesoID.ToString();
            this.txtPlacasVehiculo.Text = ds1.Tables[0].Rows[0]["Placa"].ToString();
            this.txtCondutor.Text = ds1.Tables[0].Rows[0]["Conductor"].ToString();
            this.txtCantidadPersonas.Text = ds1.Tables[0].Rows[0]["CantidadPersonas"].ToString();
            this.cmbRutas.Text = ds1.Tables[0].Rows[0]["Ruta"].ToString();            
            this.dtpFechaEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpHoraEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());            
            this.txtDescripcion.Text = ds1.Tables[0].Rows[0]["Comentarios"].ToString();
            conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();
            string query = "update RegistroAccesoSteelgo set TieneSalida = 1, FechaHoraSalida = '" + this.dtpFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss")
                            + "' where RegistroAccesoID = " + this.txtClaveRegistro.Text.Trim();
            SqlCommand cmd = new SqlCommand(query, conexion);            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se guardo correctamente la salida", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();
            this.Close();
        }
    }
}
