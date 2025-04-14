using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyEmpresa;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Empresa01 : System.Web.UI.Page
    {
        private ServicioEmpresaClient client = new ServicioEmpresaClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEmpresas();
            }
        }

        private void CargarEmpresas()
        {
            try
            {
                List<ProxyEmpresa.EmpresaDC> empresas = client.usp_ListarEmpresa().ToList();
                FiltrarYMostrarEmpresas(empresas);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void FiltrarYMostrarEmpresas(List<ProxyEmpresa.EmpresaDC> empresas)
        {
            string filtro = txtBuscar.Text.ToLower();
            List<ProxyEmpresa.EmpresaDC> empresasFiltradas = empresas
                .Where(emp => emp.RazSocEmpresa.ToLower().Contains(filtro))
                .ToList();

            gvEmpresas.DataSource = empresasFiltradas;
            gvEmpresas.DataBind();

            lblTotalEmpresas.Text = "Total de Empresas: " + empresasFiltradas.Count;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string codEmpresa = (sender as Button).CommandArgument;
            Response.Redirect("Empresa03.aspx?codEmpresa=" + codEmpresa);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene el ID de la empresa desde el botón
                string codEmpresa = (sender as Button).CommandArgument;

                // Llama al método para eliminar la empresa
                if (client.usp_EliminarEmpresa(codEmpresa))
                {
                    // Vuelve a cargar los datos si la eliminación fue exitosa
                    CargarEmpresas();
                }
                else
                {
                    throw new Exception("No se eliminó el registro. Verifique su vínculo en otra tabla.");
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepción
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empresa02.aspx");
        }
    }
}
