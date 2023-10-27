using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FrontEnd
{
    public partial class ConsultaCita : Form
    {

        private PantallaPrincipal principal;
        private PantallaPrincipal ventanaPrincipal;
        private List<string> servicioss = new List<string>();
        private List<Factura> facturas = new List<Factura>();
        DataTable dtServicios;
        public ConsultaCita(PantallaPrincipal pantalla)
        {
            InitializeComponent();

        }
        List<Servicio> servicios = new List<Servicio>();
        List<Facturas> fact = new List<Facturas>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ListaServicio listaServi = new ListaServicio();
            xmlFactura factuxml = new xmlFactura();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string subfolder = "XMLFiles";
            string filename = "Factura.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(xmlFactura));
                    factuxml = (xmlFactura)serializer.Deserialize(fileStream);
                }
            }
            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("Identificacion", typeof(string));
            dtServicios.Columns.Add("NombreNinio", typeof(string));
            dtServicios.Columns.Add("FechaFactura", typeof(string));


            var resultado = from persona in factuxml.Facturaxml
                            where persona.Identificacion.ToString() == txtIdentificacionNinno.Text.ToString()
                            select new { persona.Identificacion, persona.NombreNinio, persona.FechaFactura };// persona.Nombre, persona.Apellido };


            foreach (var persona in resultado)
            {

                DataRow fila1 = dtServicios.NewRow();
                fila1["Identificacion"] = persona.Identificacion.ToString();
                fila1["NombreNinio"] = persona.NombreNinio.ToString();
                fila1["FechaFactura"] = persona.FechaFactura.ToString();
                dtServicios.Rows.Add(fila1);

            }



            dataGridViewFactura.DataSource = dtServicios;



            //NinnoXML ninnoXML = new NinnoXML();
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string subfolder = "XMLFiles";
            //string filename = "ninnno.xml";
            //string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            //if (File.Exists(xmlFilePath))
            //{
            //    using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(NinnoXML));
            //        ninnoXML = (NinnoXML)serializer.Deserialize(fileStream);
            //    }
            //}




            //DataTable dtServicios = new DataTable();
            //dtServicios.Columns.Add("Servicio", typeof(string));
            //dtServicios.Columns.Add("Costo", typeof(string));
            //dtServicios.Columns.Add("Niño", typeof(string));


            //// Realizar una consulta SELECT utilizando LINQ
            //var resultado = from persona in ninnoXML.ninnoxml
            //                where persona.Identificacion.ToString() == txtIdentificacionNinno.Text.ToString()
            //                select new { persona.Identificacion, persona.Nombre };

            //// foreach (var persona in resultado)
            ////{
            //foreach (var persona in resultado)
            //{
            //    DataRow fila1 = dtServicios.NewRow();
            //    //fila1["Servicio"] = persona.servicioNombre.ToString();
            //    //fila1["Costo"] = persona.ServicioCostonSinIva.ToString();
            //    fila1["Niño"] = persona.Nombre.ToString();
            //    dtServicios.Rows.Add(fila1);

            //    //}
            //}

            //dataGridViewFactura.DataSource = dtServicios;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("Servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));
            // Puedes poner este código en un manejador de eventos del botón "Pagar" en tu formulario.

            // Calcular el monto total con IVA (0.013)
            double montoSinIva = 0;
            foreach (DataRow fila in dtServicios.Rows)
            {
                double costo = Convert.ToDouble(fila["Costo"]);
                montoSinIva += costo;
            }
            double iva = montoSinIva * 0.013;
            double montoConIva = montoSinIva + iva;

            // Mostrar un mensaje de servicio cancelado
            MessageBox.Show("Servicio Cancelado");

            // Actualizar las etiquetas para mostrar el monto con IVA y el estado
            // lblSubtotal.Text = "Monto con IVA: " + montoConIva.ToString("C"); // Formatea el monto como moneda
            //lblEstadoServicio.Text = "Estado del Servicio: Cancelado";

        }


        private void txtIdentificacionNinno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblidNinio_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("prueba");
        }
    }
}
