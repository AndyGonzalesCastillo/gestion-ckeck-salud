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
    public partial class PacienteMan03 : Form

    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyEmpresa.ServicioEmpresaClient objServicioEmpresa = new ProxyEmpresa.ServicioEmpresaClient();
        ProxyPaciente.PacienteDC objPacienteDC = new ProxyPaciente.PacienteDC();

        public PacienteMan03()
        {
            InitializeComponent();
        }

        public String strCodigo { get; set; }
        private void PacienteMan03_Load(object sender, EventArgs e)
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

                cboUbigeo.DataSource = dtUbicaciones;
                cboUbigeo.DisplayMember = "Distrito";
                cboUbigeo.ValueMember = "Id_Ubigeo";

                // Llenar el combo box de Empresa usando el servicio
                var empresas = objServicioEmpresa.usp_ListarEmpresa();
                var dtEmpresas = new DataTable();
                dtEmpresas.Columns.Add("codEmpresa");
                dtEmpresas.Columns.Add("RazSocEmpresa");

                foreach (var emp in empresas)
                {
                    var row = dtEmpresas.NewRow();
                    row["codEmpresa"] = emp.codEmpresa;
                    row["RazSocEmpresa"] = emp.RazSocEmpresa;
                    dtEmpresas.Rows.Add(row);
                }

                DataRow drEmpresa = dtEmpresas.NewRow();
                drEmpresa["codEmpresa"] = 0;
                drEmpresa["RazSocEmpresa"] = "--Seleccione--";
                dtEmpresas.Rows.InsertAt(drEmpresa, 0);

                cboEmpresa.DataSource = dtEmpresas;
                cboEmpresa.DisplayMember = "RazSocEmpresa";
                cboEmpresa.ValueMember = "codEmpresa";

                objPacienteDC = objServicioPaciente.usp_ConsultarPaciente(strCodigo);

                lblCodigo.Text = objPacienteDC.CodPaciente;
                txtNombres.Text = objPacienteDC.NomPaciente;
                txtApellidos.Text = objPacienteDC.ApePaciente;
                dtpNacimiento.Value = Convert.ToDateTime(objPacienteDC.FecNacPaciente);
                txtDNI.Text = objPacienteDC.DniPaciente;
                cboSexo.SelectedIndex = objPacienteDC.Sexo_Paciente + 1;
                txtDireccion.Text = objPacienteDC.DirecPaciente;
                cboSangre.SelectedIndex = objPacienteDC.Tipo_Sangre + 1;
                dtpIngreso.Value = objPacienteDC.FecNacPaciente;
                txtEmail.Text = objPacienteDC.EmailPaciente;
                txtTelefono.Text = objPacienteDC.TelPaciente;
                cboCliente.SelectedIndex = objPacienteDC.Tipo_Cliente ;
                cboEmpresa.SelectedValue = objPacienteDC.CodEmpresa;
                cboUbigeo.SelectedValue = objPacienteDC.IdUbigeo;


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
                if (txtApellidos.Text.Trim() == "" || txtNombres.Text.Trim() == ""
                   || txtDNI.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                   || txtTelefono.Text.Trim() == "" || txtDireccion.Text.Trim() == ""
                   || cboSexo.SelectedIndex == 0 || cboSangre.SelectedIndex == 0
                   || cboCliente.SelectedIndex == 0)
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                objPacienteDC.CodEmpresa = lblCodigo.Text;
                objPacienteDC.NomPaciente = txtNombres.Text.Trim();
                objPacienteDC.ApePaciente = txtApellidos.Text.Trim();
                objPacienteDC.FecNacPaciente = dtpNacimiento.Value;
                objPacienteDC.DniPaciente = txtDNI.Text.Trim();
                objPacienteDC.Sexo_Paciente = Convert.ToInt16(cboSexo.SelectedIndex - 1);
                objPacienteDC.DirecPaciente = txtDireccion.Text.Trim();
                objPacienteDC.Tipo_Sangre = Convert.ToInt16(cboSangre.SelectedIndex - 1);
                objPacienteDC.EmailPaciente = txtEmail.Text.Trim();
                objPacienteDC.FecNacPaciente = dtpIngreso.Value;
                objPacienteDC.TelPaciente = txtTelefono.Text.Trim();
                objPacienteDC.Tipo_Cliente = Convert.ToInt16(cboCliente.SelectedIndex);
                objPacienteDC.CodEmpresa = cboEmpresa.SelectedValue.ToString();
                objPacienteDC.UsuUltMod = "jleon";
                objPacienteDC.IdUbigeo = cboUbigeo.SelectedValue.ToString();

                if (objServicioPaciente.usp_ActualizarPaciente(objPacienteDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con IT");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                || e.KeyChar == (char)Keys.Back);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
