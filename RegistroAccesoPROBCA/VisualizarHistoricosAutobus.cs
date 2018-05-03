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
    public partial class VisualizarHistoricosAutobus : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public VisualizarHistoricosAutobus()
        {
            InitializeComponent();
        }

        internal void LoadOrders(int RegistAccesoID)
        {
            //ordersTableAdapter.FillByCustomerID(northwindDataSet.Orders, CustomerID);
            //dataGridView1.DataSource = bindingSource1;
            //string Query = "";
            //GetData("select RegistroPersonasID, Placa, Nombre from RegistroAccesoPersonas where RegistroAccesoID = 3");

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
            //this.cmbAsunto.Text = ds1.Tables[0].Rows[0]["Asunto"].ToString();
            //this.cmbDepartamento.Text = ds1.Tables[0].Rows[0]["Departamento"].ToString();
            this.dtpFechaEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpHoraEntrada.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraEntrada"].ToString());
            this.dtpFechaSalida.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraSalida"].ToString());
            this.dtpHoraSalida.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["FechaHoraSalida"].ToString());
            this.txtDescripcion.Text = ds1.Tables[0].Rows[0]["Comentarios"].ToString();

            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
