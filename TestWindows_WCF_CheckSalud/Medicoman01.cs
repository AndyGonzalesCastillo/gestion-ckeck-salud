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
    public partial class Medicoman01 : Form
    {   
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();

        public Medicoman01()
        {
            InitializeComponent();

        }
        private void Medicoman01_Load(object sender, EventArgs e)
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

        private void CargarDatos(string strFiltro)
        {
            try
            {
                List<ProxyMedico.MedicoDC> datos = objServicioMedico.usp_ListarMedico(); // Obtiene los datos del servicio

                if (!string.IsNullOrEmpty(strFiltro))
                {
                    // Aplica el filtro solo al campo de nombre del médico
                    var datosFiltrados = datos.Where(m => m.NomMedico.Contains(strFiltro, StringComparison.OrdinalIgnoreCase)).ToList();
                    dtgDatos.DataSource = datosFiltrados;
                }
                else
                {
                    // Si el filtro está vacío, muestra todos los datos
                    dtgDatos.DataSource = datos;
                }

                lblRegistro.Text = dtgDatos.Rows.Count.ToString();
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
                MedicoMan02 objMedico02 = new MedicoMan02();
                objMedico02.ShowDialog();

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
                MedicoMan03 objMedico03 = new MedicoMan03();

                // Obtenemos el codigo del vendedor seleccionado en el dtgVendedor
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMedico03.strCodigo = strCodigo;
                objMedico03.ShowDialog();

                // Refrescamos...
                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                if (objServicioMedico.usp_EliminarMedico(strCodigo) == true)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


       
    }

 

