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
    public partial class ListarConsultaPacientes : Form
    {
        public ListarConsultaPacientes()
        {
            InitializeComponent();
            cmbFiltro1.Enabled = false;
            cmbFiltro1.SelectedIndex = 0;
            chkConsulta1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServicioConsultasClient servicioConsultasClient = new ServicioConsultasClient();

            string DNI = textBox1.Text;
            var filtroConsulta = chkConsulta1.Checked == true ? cmbFiltro1.SelectedItem?.ToString() : "";

            var listaConsultasPaciente = servicioConsultasClient.sp_ListarConsultasPaciente(DNI, filtroConsulta);
            dataGridView1.DataSource = listaConsultasPaciente;
            dataGridView1.Refresh();


        }

        private void chkConsulta1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsulta1.Checked)
            {
                cmbFiltro1.Enabled = true;
            }
            else { cmbFiltro1.Enabled = false; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el evento de tecla
            }
        }
    }
}
