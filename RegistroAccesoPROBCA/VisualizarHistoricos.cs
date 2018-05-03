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
    public partial class VisualizarHistoricos : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public VisualizarHistoricos()
        {
            InitializeComponent();
        }

        internal void LoadOrders(int RegistAccesoID)
        {
            if(conexion.State == ConnectionState.Closed)            
                conexion.Open();
            string query = "select top 1 * from RegistroAccesoSteelgo where RegistroAccesoID = " + RegistAccesoID.ToString();
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            da.Fill(ds1, "Encabezado");
            this.txtClaveRegistro.Text = RegistAccesoID.ToString();
            this.txtPlacasVehiculo.Text = ds1.Tables[0].Rows[0]["Placa"].ToString();
            this.txtCondutor.Text = ds1.Tables[0].Rows[0]["Conductor"].ToString();
            this.cmbAsunto.Text = ds1.Tables[0].Rows[0]["Asunto"].ToString();
            this.cmbDepartamento.Text = ds1.Tables[0].Rows[0]["Departamento"].ToString() == "BLA" ? "" : ds1.Tables[0].Rows[0]["Departamento"].ToString();
            this.dtpFechaEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpHoraEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpFechaSalida.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraSalida"].ToString());
            this.dtpHoraSalida.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraSalida"].ToString());
            this.txtDescripcion.Text = ds1.Tables[0].Rows[0]["Comentarios"].ToString();

            DataSet ds = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("select RegistroAccesoID, Placa, Nombre, Gafete, FechaEntrada, FechaSalida from RegistroAccesoPersonas where RegistroAccesoID = "
                                + RegistAccesoID.ToString() + " AND Salida = 1 ", conexion);
            da2.Fill(ds, "RegistrosPersonas");            
            dataGridView1.DataSource = ds.Tables[0];
            conexion.Close();
            lblCantidadPersonas.Text = "visitan: " + Convert.ToString(dataGridView1.Rows.Count - 1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
