using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyCheckS_GUI
{
    public partial class PacienteMan02 : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente= new ProxyPaciente.ServicioPacienteClient();
        ProxyUbicacion.ServicioUbicacionClient objServicioUbicacion = new ProxyUbicacion.ServicioUbicacionClient();
        ProxyEmpresa.ServicioEmpresaClient objServicioEmpresa = new ProxyEmpresa.ServicioEmpresaClient();

        ProxyPaciente.PacienteDC objPacienteDC = new ProxyPaciente.PacienteDC();

        public PacienteMan02()
        {
            InitializeComponent();
        }

        private void PacienteMan02_Load(object sender, EventArgs e)
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
                
                foreach(var emp in empresas) 
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
                cboCliente.SelectedIndex = 0;
                cboSexo.SelectedIndex = 0;
                cboSangre.SelectedIndex = 0;

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

                objPacienteDC.NomPaciente = txtNombres.Text.Trim();
                objPacienteDC.ApePaciente = txtApellidos.Text.Trim();
                objPacienteDC.FecNacPaciente = dtpNacimiento.Value;
                objPacienteDC.DniPaciente = txtDNI.Text.Trim();
                objPacienteDC.Sexo_Paciente = Convert.ToInt16(cboSexo.SelectedIndex - 1);
                objPacienteDC.DirecPaciente = txtDireccion.Text.Trim();
                objPacienteDC.Tipo_Sangre = Convert.ToInt16(cboSangre.SelectedIndex - 1);
                objPacienteDC.EmailPaciente = txtEmail.Text.Trim();
                objPacienteDC.FecIngreso = dtpIngreso.Value;
                objPacienteDC.TelPaciente = txtTelefono.Text.Trim();
                objPacienteDC.Tipo_Cliente = Convert.ToInt16(cboCliente.SelectedIndex);
                objPacienteDC.CodEmpresa = cboEmpresa.SelectedValue.ToString();
                objPacienteDC.UsuRegistro = "luciana2021";
                objPacienteDC.IdUbigeo = cboUbigeo.SelectedValue.ToString();

                if (objServicioPaciente.usp_InsertarPaciente(objPacienteDC) == true)
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
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
