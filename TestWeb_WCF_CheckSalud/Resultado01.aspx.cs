using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyResultado;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Resultado01 : System.Web.UI.Page
    {
        private ServicioResultadoClient client = new ServicioResultadoClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarResultados();
            }
        }

        private void CargarResultados(string filtro = "")
        {
            try
            {
                List<ProxyResultado.ResultadoDC> resultados = client.ListarResultado().ToList();

                if (!string.IsNullOrEmpty(filtro))
                {
                    resultados = resultados.Where(r => r.NomApePaciente.ToLower().Contains(filtro.ToLower())).ToList();
                }

                gvResultados.DataSource = resultados;
                gvResultados.DataBind();

                lblTotalResultados.Text = $"Total Resultados: {resultados.Count}";
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;
            CargarResultados(filtro);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string codResultado = (sender as Button).CommandArgument;
            Response.Redirect("Resultado03.aspx?codResultado=" + codResultado);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codResultado = (sender as Button).CommandArgument;

                if (client.EliminarResultado(codResultado) == true)
                {
                    CargarResultados();
                }
                else
                {
                    throw new Exception("No se eliminó el registro. Verifique su vínculo en otra tabla.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Resultado02.aspx");
        }

        protected void gvResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
