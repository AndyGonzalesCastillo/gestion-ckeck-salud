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
    public partial class ConsultaEspecialidadFechas : Form
    {
        public ConsultaEspecialidadFechas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();

            DateTime fecini = dateTimePicker1.Value;
            DateTime fecfin = dateTimePicker2.Value;

            var resultados = servicioConsultasClient.sp_ConsultaEspecialidadFechas(fecini, fecfin);

            if (resultados != null)
            {
                dataGridView1.DataSource = resultados;
            }
        }
    }
}
