using ProyCheckS_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWindows_WCF_CheckSalud;

namespace ProyCheckS_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }





        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteMan01 pacienteMan01 = new();
            pacienteMan01.MdiParent = this;
            pacienteMan01.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicoman01 medicoMan01 = new();
            medicoMan01.MdiParent = this;
            medicoMan01.Show();
        }

        private void nConsultasPorEspecialidadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeConsultasDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarConsultaPacientes listarConsultaPacientes = new();
            listarConsultaPacientes.MdiParent = this;
            listarConsultaPacientes.Show();
        }

        private void obtenerConsultasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObtenerConsultasPorFecha ObtenerConsultasPorFecha = new();
            ObtenerConsultasPorFecha.MdiParent = this;
            ObtenerConsultasPorFecha.Show();
        }

        private void nConsultasPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEspecialidadFechas ConsultaEspecialidadFechas = new();
            ConsultaEspecialidadFechas.MdiParent = this;
            ConsultaEspecialidadFechas.Show();
        }

        private void consultasAsigandasAMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasAsignadasMedico ConsultasAsignadasMedico = new();
            ConsultasAsignadasMedico.MdiParent = this;
            ConsultasAsignadasMedico.Show();
        }
    }
}
