using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyEmpresa;
using TestWeb_WCF_CheckSalud.ProxyUbicacion;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Empresa02 : System.Web.UI.Page
    {
        private ServicioEmpresaClient empresaClient = new ServicioEmpresaClient();
        private ServicioUbicacionClient ubicacionClient = new ServicioUbicacionClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUbigeos();
            }
        }

        private void CargarUbigeos()
        {
            try
            {
                List<ProxyUbicacion.UbicacionDC> ubicaciones = ubicacionClient.usp_ListarUbicacion().ToList();
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

                bool rucExiste = empresaClient.usp_ExisteRuc(ruc);
                if (rucExiste)
                {
                    MostrarMensaje("El RUC ingresado ya existe");
                    return;
                }

                EmpresaDC nuevaEmpresa = new EmpresaDC
                {
                    RazSocEmpresa = razonSocial,
                    DirecEmpresa = direccion,
                    TelEmpresa = telefono,
                    RucEmpresa = ruc,
                    RepEmpresa = representante,
                    IdUbigeo = distrito,
                    Est_Empresa = Convert.ToInt32(ddlEstado.SelectedValue)
                };

                bool resultado = empresaClient.usp_InsertarEmpresa(nuevaEmpresa);

                if (resultado)
                {
                    MostrarMensaje("Empresa creada correctamente");
                    Response.Redirect("Empresa01.aspx");
                }
                else
                {
                    MostrarMensaje("No se pudo crear la empresa");
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
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
        }
    }
}
