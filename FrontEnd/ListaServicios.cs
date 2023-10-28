﻿using Negocios;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace FrontEnd
{
    public partial class ListaServicios : Form
    {
        //Listas

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
            //crear Datatable
        {
            dataTable = new DataTable("Servicios");

            dataTable.Columns.Add("Servicio", typeof(string));
            dataTable.Columns.Add("Costo", typeof(string));

        }
        public void CargarServicios()
            //Cargar servicio
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


            DataRow fila1 = dataTable.NewRow();
            fila1["Servicio"] = nombre;
            fila1["Costo"] = valor;

            // Agregar la fila a la tabla
            dataTable.Rows.Add(fila1);
            decimal costoTotal = 0.0m;

            dataGridViewServicio.DataSource = dataTable;
            decimal costoTotalConIVA = Convert.ToDecimal(valor) * 0.13m; // 2% iva

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string subfolder = "XMLFiles";
                string filename = "Factura.xml";
                string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);
                string rutaArchivo = Path.Combine(baseDirectory, subfolder, "Consecutivo.txt");
                int NumeroFactura = 0;
                // Verifica si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Con StreamReader podemos leer el archivo
                    using (StreamReader sr = new StreamReader(rutaArchivo))
                    {
                        string contenido = sr.ReadToEnd();
                        contenido = contenido.Replace(Environment.NewLine, "").Replace(" ", "");
                        NumeroFactura = Convert.ToInt32(contenido);

                    }
                    using (StreamWriter wr = new StreamWriter(rutaArchivo, false))
                    {
                        string factura = (NumeroFactura + 1).ToString();
                        wr.WriteLine((""));
                        wr.WriteLine((factura));
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");

                }



                DataTable dtServicios = new DataTable();
                dtServicios.Columns.Add("Servicio", typeof(string));
                dtServicios.Columns.Add("Costo", typeof(string));


                // Calcular el monto total con IVA (0.013)
                double montoSinIva = 0;
                foreach (DataRow fila in dtServicios.Rows)
                {
                    double costo = Convert.ToDouble(fila["Costo"]);
                    montoSinIva += costo;
                }
                double iva = montoSinIva * 0.013;
                double montoConIva = montoSinIva + iva;


                // Actualizar las etiquetas para mostrar el monto con IVA y el estado
                lblSubtotal.Text = "Monto con IVA: " + montoConIva.ToString("C"); // Logra dar el monto como moneda
                lblEstadoServicio.Text = "Estado del Servicio: Cancelado";

                Facturas Facturasninio = new Facturas();
                Factura Fact = new Factura();
                xmlFacturaNueva xml = new xmlFacturaNueva();
                XmlFactura xmlFactura = new XmlFactura();


                if (File.Exists(xmlFilePath))
                {
                    using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(XmlFactura));
                        xmlFactura = (XmlFactura)serializer.Deserialize(fileStream);
                    }
                }

                List<Servicio> servicios = new List<Servicio>();

                foreach (DataGridViewRow row in dataGridViewServicio.Rows)
                {
                    if (!row.IsNewRow) // Lo usé para evitar que la fila este en blanco
                    {
                        Servicio s = new Servicio();
                        s.servicioNombre = row.Cells["Servicio"].Value.ToString();
                        s.ServicioCostonSinIva = row.Cells["Costo"].Value.ToString();

                        servicios.Add(s);
                    }
                }

                Fact.NombreNinio = txtNombre.Text;
                Fact.ApellidoNinio = txtApellido.Text;
                Fact.Identificacion = txtIdentificacion.Text;
                Fact.costoTotal = lblCostoTotall.Text;
                Fact.NumeroFactura = NumeroFactura.ToString();
                Fact.FechaFactura = DateTime.Now;
                xml.servicios = servicios;
                xml.Facturaxml = Fact;
                xmlFactura.Facturaxml.Add(xml);



                Facturasninio.RegistroFactura(xmlFactura);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo una excepción: " + ex.Message);

            }

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            //XML
            NinnoXML ninnoXML = new NinnoXML();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string subfolder = "XMLFiles";
            string filename = "ninnno.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(NinnoXML));
                    ninnoXML = (NinnoXML)serializer.Deserialize(fileStream);
                }
            }






        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Xml
            NinnoXML ninnoXML = new NinnoXML();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string subfolder = "XMLFiles";
            string filename = "ninnno.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(NinnoXML));
                    ninnoXML = (NinnoXML)serializer.Deserialize(fileStream);
                }
            }
            //Columnas
            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("Servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));
            dtServicios.Columns.Add("Niño", typeof(string));

            var resultado = from persona in ninnoXML.ninnoxml
                            where persona.Identificacion.ToString() == txtIdentificacion.Text.ToString()
                            select new { persona.Identificacion, persona.Nombre, persona.Apellido };
            foreach (var persona in resultado)
            {
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;



            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ventanaPrincipal.Show();
        }
    }//fin main 

}//fin class

