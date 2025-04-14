using System;
using System.Linq;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyEmpresa;
using TestWeb_WCF_CheckSalud.ProxyUbicacion;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Empresa03 : System.Web.UI.Page
    {
        private ServicioEmpresaClient empresaClient = new ServicioEmpresaClient();
        private ServicioUbicacionClient ubicacionClient = new ServicioUbicacionClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string codEmpresa = Request.QueryString["codEmpresa"];
                if (!string.IsNullOrEmpty(codEmpresa))
                {
                    CargarUbigeos();
                    CargarEmpresa(codEmpresa);
                }
            }
        }

        private void CargarUbigeos()
        {
            try
            {
                var ubicaciones = ubicacionClient.usp_ListarUbicacion().ToList();
                ddlUbigeo.DataSource = ubicaciones;
                ddlUbigeo.DataTextField = "Distrito";
                ddlUbigeo.DataValueField = "Id_Ubigeo";
                ddlUbigeo.DataBind();
                ddlUbigeo.Items.Insert(0, new ListItem("--Seleccionar Distrito--", "0"));
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: " + ex.Message);
            }
        }

        private void CargarEmpresa(string codEmpresa)
        {
            try
            {
                EmpresaDC empresa = empresaClient.usp_ConsultarEmpresa(codEmpresa);
                if (empresa != null)
                {
                    lblCodigoValue.Text = empresa.codEmpresa;
                    txtRazonSocial.Text = empresa.RazSocEmpresa;
                    txtDireccion.Text = empresa.DirecEmpresa;
                    txtTelefono.Text = empresa.TelEmpresa;
                    txtRuc.Text = empresa.RucEmpresa;
                    txtRepresentante.Text = empresa.RepEmpresa;
                    ddlUbigeo.SelectedValue = empresa.IdUbigeo;
                    ddlEstado.SelectedValue = empresa.Est_Empresa.ToString();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: " + ex.Message);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string razonSocial = txtRazonSocial.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string ruc = txtRuc.Text.Trim();
                string representante = txtRepresentante.Text.Trim();
                string distrito = ddlUbigeo.SelectedValue;

                if (string.IsNullOrEmpty(razonSocial) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono) ||
                    string.IsNullOrEmpty(ruc) || string.IsNullOrEmpty(representante))
                {
                    MostrarMensaje("Debe completar todos los campos");
                    return;
                }

                if (ruc.Length != 11)
                {
                    MostrarMensaje("El RUC debe tener 11 dígitos");
                    return;
                }

                if (distrito == "0")
                {
                    MostrarMensaje("Debe seleccionar un distrito");
                    return;
                }

                string codigoEmpresaActual = lblCodigoValue.Text;
                EmpresaDC empresaActual = empresaClient.usp_ConsultarEmpresa(codigoEmpresaActual);

                // Solo verificar el RUC si el RUC ingresado es diferente al RUC actual
                if (empresaActual != null && empresaActual.RucEmpresa != ruc)
                {
                    bool rucExiste = empresaClient.usp_ExisteRuc(ruc);
                    if (rucExiste)
                    {
                        MostrarMensaje("El RUC ingresado ya existe");
                        return;
                    }
                }

                EmpresaDC empresaActualizada = new EmpresaDC
                {
                    codEmpresa = codigoEmpresaActual,
                    RazSocEmpresa = razonSocial,
                    DirecEmpresa = direccion,
                    TelEmpresa = telefono,
                    RucEmpresa = ruc,
                    RepEmpresa = representante,
                    IdUbigeo = distrito,
                    Est_Empresa = Convert.ToInt32(ddlEstado.SelectedValue)
                };

                bool resultado = empresaClient.usp_ActualizarEmpresa(empresaActualizada);

                if (resultado)
                {
                    MostrarMensaje("Empresa actualizada correctamente");
                    Response.Redirect("Empresa01.aspx");
                }
                else
                {
                    MostrarMensaje("No se pudo actualizar la empresa");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: " + ex.Message);
            }
        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empresa01.aspx");
        }

        private void MostrarMensaje(string mensaje)
        {
            string script = $"<script type='text/javascript'>showAlert('{mensaje}');</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", script);
        }
    }
}
