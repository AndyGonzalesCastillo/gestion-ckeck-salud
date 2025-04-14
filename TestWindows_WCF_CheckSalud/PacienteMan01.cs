using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyCheckS_GUI
{
    public partial class PacienteMan01 : Form
    {

        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();


        public PacienteMan01()
        {
            InitializeComponent();
        }

        private void PacienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {
            try
            {
                List<ProxyPaciente.PacienteDC> datos = objServicioPaciente.usp_ListarPaciente(); // Obtiene los datos del servicio

                if (!string.IsNullOrEmpty(strFiltro))
                {
                    // Aplica el filtro solo al campo de nombre del médico
                    var datosFiltrados = datos.Where(m => m.ApeNomPaciente.Contains(strFiltro, StringComparison.OrdinalIgnoreCase)).ToList();
                    dtgDatos.DataSource = datosFiltrados;
                }
                else
                {
                    // Si el filtro está vacío, muestra todos los datos
                    dtgDatos.DataSource = datos;
                }

                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                PacienteMan02 objPaciente02 = new PacienteMan02();
                objPaciente02.ShowDialog();

                // Refrescamos...
                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                PacienteMan03 objPaciente03 = new PacienteMan03();

                // Obtenemos el codigo del vendedor seleccionado en el dtgVendedor
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objPaciente03.strCodigo = strCodigo;
                objPaciente03.ShowDialog();

                // Refrescamos...
                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                if (objServicioPaciente.usp_EliminarPaciente(strCodigo) == true)
                {
                    CargarDatos(txtFiltro.Text);
                }
                else
                {
                    throw new Exception("no se elimino el registro verifique su vinculo en otra tabla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
