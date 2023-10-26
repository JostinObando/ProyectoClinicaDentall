using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocios;
namespace FrontEnd
{
    public partial class ListaServicios : Form
    {
        //private ListaServicios servicioMan;
        ListaServicio servicioMan = new ListaServicio();
        private PantallaPrincipal ventanaPrincipal;
        DataTable dataTable = new DataTable("Servisios");
        private List<string> servicios = new List<string>();

        private List<Ninno> listaNiño = new List<Ninno>();
        private PantallaPrincipal principal;

        private Mantenimiento mantenimiento;




        public ListaServicios(PantallaPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            // this.principal = principal;
            CargarServicios();
            CrearDataTable();
            this.ventanaPrincipal = ventanaPrincipal;

        }
        public void CrearDataTable()
        {
            dataTable = new DataTable("Servicios");

            dataTable.Columns.Add("Servicio", typeof(string));
            dataTable.Columns.Add("Costo", typeof(string));

        }
        public void CargarServicios()
        {
            try
            {
                ServicioModel servicio = new ServicioModel();
                ServicioModelList ser = new ServicioModelList();

                servicio.Nombre = "Limpieza Dental";
                servicio.Precio = 50000.00m;

                ser.listServicioModel.Add(servicio);
                servicio = new ServicioModel();
                servicio.Nombre = "Extracción de muelas";
                servicio.Precio = 40000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Extracción de dientes";
                servicio.Precio = 35000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Cirugía de cordales";
                servicio.Precio = 110000.00m;

                ser.listServicioModel.Add(servicio);

                servicio = new ServicioModel();
                servicio.Nombre = "Ortodoncial";
                servicio.Precio = 650000.00m;
                ser.listServicioModel.Add(servicio);

                try
                {
                    comboBoxServicios.DataSource = ser.listServicioModel;
                    comboBoxServicios.DisplayMember = "Nombre";
                    comboBoxServicios.ValueMember = "Precio";
                }
                catch (Exception ex)
                {
                    string a = ex.Message;
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {



            if (comboBoxServicios.SelectedItem != null)
            {
                servicios.Add(comboBoxServicios.Text.ToString());
                ActualizarDataGridView(comboBoxServicios.Text.ToString(), comboBoxServicios.SelectedValue.ToString());
            }
        }
        private void ActualizarDataGridView(string nombre, string valor)
        {
            //dataGridViewServicio.Rows.Clear();


            DataRow fila1 = dataTable.NewRow();
            fila1["Servicio"] = nombre;
            fila1["Costo"] = valor;

            // Agregar la fila a la tabla
            dataTable.Rows.Add(fila1);
            decimal costoTotal = 0.0m;

            dataGridViewServicio.DataSource = dataTable;
            decimal costoTotalConIVA = Convert.ToDecimal(valor) * 0.13m;

            if (string.IsNullOrEmpty(lblCostoTotall.Text))
                costoTotal = Convert.ToDecimal(valor);
            else
                costoTotal = Convert.ToDecimal(lblCostoTotall.Text) + Convert.ToDecimal(valor);


            lblCostoTotall.Text = (costoTotal + costoTotalConIVA).ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void ListaServicios_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaPrincipal.Show();

        }



    }

}

