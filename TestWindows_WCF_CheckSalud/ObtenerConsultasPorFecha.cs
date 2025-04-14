using ProxyConsultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows_WCF_CheckSalud
{
    public partial class ObtenerConsultasPorFecha : Form
    {
        public ObtenerConsultasPorFecha()
        {
            InitializeComponent();
            LoadConsultaFecha(DateTime.Today);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();

            var result = servicioConsultasClient.sp_GetConsultasByDate(fecha);

            if (result != null)
            {
                dataGridView1.DataSource = result;
            }

        }


        private void LoadConsultaFecha(DateTime date)
        {

            ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();

            var result = servicioConsultasClient.sp_GetConsultasByDate(date);

            if (result != null)
            {
                dataGridView1.DataSource = result;
            }




        }
    }
}
