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
    public partial class InformacionPaciente : Form
    {


        private List<string> servicioss = new List<string>();
        private List<Factura> facturas = new List<Factura>();

        DataTable dtServicios;
        public InformacionPaciente(int NumeroFactura)
        {
            InitializeComponent();
            MostrarFacturas(NumeroFactura);

        }

        private void MostrarFacturas(int NumeroFactura)
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
            dtServicios.Columns.Add("servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));
            dtServicios.Columns.Add("FechaFactura", typeof(string));

            //DateTime FechaFactura = DateTime.Parse(" "); 

            var resultado = from persona in factuxml.Facturaxml
                            where persona.NumeroFactura.ToString() == NumeroFactura.ToString()
                            select new { persona.servicio, persona.NombreNinio, persona.FechaFactura,persona.costoTotal,persona.ApellidoNinio,persona.Identificacion };// persona.Nombre, persona.Apellido };


            foreach (var persona in resultado)
            {

                DataRow fila1 = dtServicios.NewRow();
                fila1["servicio"] = persona.servicio.ToString();
                fila1["Costo"] = persona.costoTotal.ToString();
                fila1["FechaFactura"] = persona.FechaFactura.ToString();
                dtServicios.Rows.Add(fila1);
                txtNombre.Text = persona.NombreNinio;
                txtApellido.Text = persona.ApellidoNinio;
                txtIdentificacion.Text = persona.Identificacion;

            }



            dataGridViewInfoPanciente.DataSource = dtServicios;



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //    MostrarFacturas();
            //ListaServicio listaServi = new ListaServicio();
            //xmlFactura factuxml = new xmlFactura();
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string subfolder = "XMLFiles";
            //string filename = "Factura.xml";
            //string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            //if (File.Exists(xmlFilePath))
            //{
            //    using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(xmlFactura));
            //        factuxml = (xmlFactura)serializer.Deserialize(fileStream);
            //    }
            //}
            //DataTable dtServicios = new DataTable();
            //dtServicios.Columns.Add("servicio", typeof(string));
            //dtServicios.Columns.Add("NombreNinio", typeof(string));
            //dtServicios.Columns.Add("FechaFactura", typeof(string));

            ////DateTime FechaFactura = DateTime.Parse(" "); 

            //var resultado = from persona in factuxml.Facturaxml
            //                where persona.NumeroFactura.ToString() == txtIdentificacionNinno.Text.ToString()
            //                select new { persona.servicio, persona.NombreNinio, persona.FechaFactura };// persona.Nombre, persona.Apellido };


            //foreach (var persona in resultado)
            //{

            //    DataRow fila1 = dtServicios.NewRow();
            //    fila1["servicio"] = persona.servicio.ToString();
            //    fila1["NombreNinio"] = persona.NombreNinio.ToString();
            //    fila1["FechaFactura"] = persona.FechaFactura.ToString();
            //    dtServicios.Rows.Add(fila1);

            //}



            //dataGridViewInfoPanciente.DataSource = dtServicios;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
