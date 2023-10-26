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
        DataTable dtServicios;
        public ConsultaCita()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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




            DataTable dtServicios = new DataTable();
            dtServicios.Columns.Add("Servicio", typeof(string));
            dtServicios.Columns.Add("Costo", typeof(string));
            dtServicios.Columns.Add("Niño", typeof(string));


            // Realizar una consulta SELECT utilizando LINQ
            var resultado = from persona in ninnoXML.ninnoxml
                            where persona.ninno.Identificacion.ToString() == txtIdentificacionNinno.Text.ToString()
                            select new { persona.ninno.Identificacion, persona.ninno.Nombre, persona.servicios };

            foreach (var persona in resultado)
            {
                foreach (var item in persona.servicios)
                {
                    DataRow fila1 = dtServicios.NewRow();
                    fila1["Servicio"] = item.servicioNombre.ToString();
                    fila1["Costo"] = item.ServicioCostonSinIva.ToString();
                    fila1["Niño"] = persona.Nombre.ToString(); 
                    dtServicios.Rows.Add(fila1);

                }
            }

            dataGridViewFactura.DataSource = dtServicios;
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
            lblSubtotal.Text = "Monto con IVA: " + montoConIva.ToString("C"); // Formatea el monto como moneda
            lblEstadoServicio.Text = "Estado del Servicio: Cancelado";

        }
    }
}
