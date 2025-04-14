using ProxyConsultas;
using ProxyMedico;
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
    public partial class ConsultasAsignadasMedico : Form
    {
        public ConsultasAsignadasMedico()
        {
            InitializeComponent();
            LoadMedicos();

            cmbFiltro1.Enabled = false;
            cmbFiltro1.SelectedIndex = 0;
            chkConsulta1.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicioConsultasClient ServicioConsultasClient = new ServicioConsultasClient();
            if (cmbFiltro1.SelectedIndex == 0 && chkConsulta1.Checked == true)
            {
                MessageBox.Show("Selecciona el tipo de consulta: CANCELADA, PENDIENTE o REALIZADA.");
                return;
            }
            if (cmbMedico.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un Medico");
                return;
            }

            try
            {
                var codMedico = cmbMedico.SelectedValue.ToString();
                var filtroConsulta = chkConsulta1.Checked == true ? cmbFiltro1.SelectedItem?.ToString() : "";


                var consultasAsigandasMedico = ServicioConsultasClient.sp_ConsultasAsignadasMedico(codMedico, filtroConsulta);
                dataGridView1.DataSource = consultasAsigandasMedico;
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la consulta" + ex.Message);
            }
        }

        public class Medico
        {
            public string ID { get; set; }
            public string NomMedico { get; set; }
            public string ApeMedico { get; set; }
            public string NombreCompleto { get; set; }
        }

        private void LoadMedicos()
        {
            try
            {
                ServicioMedicoClient medicoclient = new ServicioMedicoClient();
                var medicos = medicoclient.usp_ListarMedico().Select(m => new Medico
                {
                    ID = m.CodMedico,
                    NombreCompleto = m.ApeMedico + ", " + m.NomMedico

                }).ToList();

                // Guarda la lista de médicos en una variable de clase para poder usarla en el filtro



                cmbMedico.DataSource = medicos;
                cmbMedico.DisplayMember = "NombreCompleto";
                cmbMedico.ValueMember = "ID";
                cmbMedico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbMedico.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // Maneja el evento TextChanged

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los medicos_ " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsulta1.Checked)
            {
                cmbFiltro1.Enabled = true;
            }
            else { cmbFiltro1.Enabled = false; }
        }
    }
}
