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
    public partial class MedicoMan03 : Form
    {
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyMedico.MedicoDC objMedicoDC = new ProxyMedico.MedicoDC();
        ProxyUsuario.ServicioUsuarioClient objServicioUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objUsuarioDC = new ProxyUsuario.UsuarioDC();
        ProxyEspecialidad.ServicioEspecialidadClient objEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();

        public MedicoMan03()
        {
            InitializeComponent();
        }
        public String strCodigo { get; set; }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el combo box de distritos usando el servicio
                var ubicaciones = objServicioUbicacion.usp_ListarUbicacion();
                var dtUbicaciones = new DataTable();
                dtUbicaciones.Columns.Add("Id_Ubigeo");
                dtUbicaciones.Columns.Add("Distrito");

                foreach (var ubicacion in ubicaciones)
                {
                    var row = dtUbicaciones.NewRow();
                    row["Id_Ubigeo"] = ubicacion.Id_Ubigeo;
                    row["Distrito"] = ubicacion.Distrito;
                    dtUbicaciones.Rows.Add(row);
                }

                DataRow drUbicacion = dtUbicaciones.NewRow();
                drUbicacion["Id_Ubigeo"] = 0;
                drUbicacion["Distrito"] = "--Seleccione--";
                dtUbicaciones.Rows.InsertAt(drUbicacion, 0);

                cboDistrito.DataSource = dtUbicaciones;
                cboDistrito.DisplayMember = "Distrito";
                cboDistrito.ValueMember = "Id_Ubigeo";

                // Llenar el combo box de especialidades usando el servicio
                var especialidades = objEspecialidad.usp_ListarEspecialidad();
                var dtEspecialidades = new DataTable();
                dtEspecialidades.Columns.Add("codEspecialidad");
                dtEspecialidades.Columns.Add("descEspecialidad");

                foreach (var especialidad in especialidades)
                {
                    var row = dtEspecialidades.NewRow();
                    row["codEspecialidad"] = especialidad.CodEspecialidad;
                    row["descEspecialidad"] = especialidad.DescEspecialidad;
                    dtEspecialidades.Rows.Add(row);
                }

                DataRow drEspecialidad = dtEspecialidades.NewRow();
                drEspecialidad["codEspecialidad"] = 0;
                drEspecialidad["descEspecialidad"] = "--Seleccione--";
                dtEspecialidades.Rows.InsertAt(drEspecialidad, 0);

                cboEspecialidad.DataSource = dtEspecialidades;
                cboEspecialidad.DisplayMember = "descEspecialidad";
                cboEspecialidad.ValueMember = "codEspecialidad";


                // Consultar el médico utilizando el servicio
                objMedicoDC = objServicioMedico.usp_ConsultarMedico(strCodigo);

                // Llenar los campos del formulario con los datos del médico
                lblCodigo.Text = this.strCodigo;
                txtNombre.Text = objMedicoDC.NomMedico;
                txtApellido.Text = objMedicoDC.ApeMedico;
                txtDni.Text = objMedicoDC.DniMedico;
                txtDireccion.Text = objMedicoDC.DirecMedico;
                txtEmail.Text = objMedicoDC.EmailMedico;
                txtNumColegiatura.Text = objMedicoDC.numColegiatura;
                dtpNacimiento.Value = Convert.ToDateTime(objMedicoDC.FecNacMedico);
                dtpIngreso.Value = objMedicoDC.FecIngreso;
                cboEspecialidad.SelectedValue = objMedicoDC.CodEspecialidad;
                cboDistrito.SelectedValue = objMedicoDC.IdUbigeo;
                chkestado.Checked = Convert.ToBoolean(objMedicoDC.Est_Medico);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == ""
                     || txtDni.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                     || txtNumColegiatura.Text.Trim() == "" || txtDireccion.Text.Trim() == ""
                     || cboEspecialidad.SelectedIndex == 0 || cboDistrito.SelectedIndex == 0)
                {
                    throw new Exception("Todos los datos son obligatorios");
                }


                // Crear y llenar el objeto MedicoDC
                objMedicoDC.NomMedico = txtNombre.Text.Trim();
                objMedicoDC.ApeMedico = txtApellido.Text.Trim();
                objMedicoDC.FecNacMedico = dtpNacimiento.Value;
                objMedicoDC.DniMedico = txtDni.Text.Trim();
                objMedicoDC.numColegiatura = txtNumColegiatura.Text.Trim();
                objMedicoDC.DirecMedico = txtDireccion.Text.Trim();
                objMedicoDC.EmailMedico = txtEmail.Text.Trim();
                objMedicoDC.FecIngreso = dtpIngreso.Value;
                objMedicoDC.CodEspecialidad = cboEspecialidad.SelectedValue.ToString();
                objMedicoDC.IdUbigeo = cboDistrito.SelectedValue.ToString();
                objMedicoDC.Est_Medico = Convert.ToInt16(chkestado.Checked);
                objMedicoDC.UsuUltMod = "jleon";


                if (objServicioMedico.usp_ActualizarMedico(objMedicoDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertaron los registros, contacte con IT");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true; 
            }
        }


        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
  }

