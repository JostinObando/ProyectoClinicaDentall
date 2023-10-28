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
        //Inicio listas
        private PantallaPrincipal principal;
        private PantallaPrincipal ventanaPrincipal;
        private List<string> servicioss = new List<string>();
        private List<Factura> facturas = new List<Factura>();
        DataTable dtServicios;
        public ConsultaCita(PantallaPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;

        }
        List<Servicio> servicios = new List<Servicio>();
        List<Facturas> fact = new List<Facturas>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //XML
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
                DataTable dtServicios = new DataTable();
                //Columnas
                dtServicios.Columns.Add("Identificacion", typeof(string));
                dtServicios.Columns.Add("NombreNinio", typeof(string));
                dtServicios.Columns.Add("FechaFactura", typeof(string));
                dtServicios.Columns.Add("NumeroFactura", typeof(string));

                foreach (var item in factuxml.Facturaxml)
                {
                    if (item.Facturaxml.Identificacion == txtIdentificacionNinno.Text)
                    {
                        DataRow fila1 = dtServicios.NewRow();
                        fila1["Identificacion"] = item.Facturaxml.Identificacion.ToString();
                        fila1["NombreNinio"] = item.Facturaxml.NombreNinio.ToString();
                        fila1["FechaFactura"] = item.Facturaxml.FechaFactura.ToString();
                        fila1["NumeroFactura"] = item.Facturaxml.NumeroFactura.ToString();
                        dtServicios.Rows.Add(fila1);
                    }

                }

                dataGridViewFactura.DataSource = dtServicios;

            }
            catch (Exception ex)
            {
                
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //DataTable
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

            // Mostrar un mensaje de servicio cancelado
            MessageBox.Show("Servicio Cancelado");

          

        }


        private void txtIdentificacionNinno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblidNinio_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir 
            this.Hide();
            ventanaPrincipal.Show();

        }

        private void dataGridViewFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            //Evento de la informacion de Paciente
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
             

                DataGridViewCell celdaSeleccionada = dataGridViewFactura.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (celdaSeleccionada.Value != null)
                {
                    string valorCelda = celdaSeleccionada.Value.ToString();
                    InformacionPaciente informacionPaciente = new InformacionPaciente(Convert.ToInt32(valorCelda));
                    informacionPaciente.Show();
                    MessageBox.Show(" " + valorCelda);
                }
                else
                {
                    MessageBox.Show(" ");
                }//fin if
            }
        }
    }
}
