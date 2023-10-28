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

        //Listas
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
            //Se carga xml Factura
            ListaServicio listaServi = new ListaServicio();
            XmlFactura factuxml = new XmlFactura();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string subfolder = "XMLFiles";
            string filename = "Factura.xml";
            string xmlFilePath = Path.Combine(baseDirectory, subfolder, filename);



            if (File.Exists(xmlFilePath))
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(XmlFactura));
                    factuxml = (XmlFactura)serializer.Deserialize(fileStream);
                }
            }
            //Columnas
            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));
            dtServicios.Columns.Add("FechaFactura", typeof(string));

            //Inicio foreach
            foreach (var item in factuxml.Facturaxml)
            {
                if (item.Facturaxml.NumeroFactura == NumeroFactura.ToString())
                {
                    foreach (var servicio in item.servicios)
                    {
                        DataRow fila1 = dtServicios.NewRow();
                        fila1["servicio"] = servicio.servicioNombre.ToString();
                        fila1["Costo"] = servicio.ServicioCostonSinIva.ToString();
                        fila1["FechaFactura"] = NumeroFactura.ToString();
                        dtServicios.Rows.Add(fila1);
                    }

                    txtNombre.Text = item.Facturaxml.NombreNinio;
                    txtApellido.Text = item.Facturaxml.ApellidoNinio;
                    txtIdentificacion.Text = item.Facturaxml.Identificacion;
                   
                }
            }

            dataGridViewInfoPanciente.DataSource = dtServicios;



        }//fin

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformacionPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
