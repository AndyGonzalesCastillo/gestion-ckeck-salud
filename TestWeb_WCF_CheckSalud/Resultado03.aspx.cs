using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyResultado;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Resultado03 : System.Web.UI.Page
    {

        ProxyResultado.ServicioResultadoClient objServicioResultado = new ProxyResultado.ServicioResultadoClient();
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyEvaluacion.ServicioEvaluacionClient objEvaluacion = new ProxyEvaluacion.ServicioEvaluacionClient();
        ProxyEnfermedad.ServicioEnfermedadClient objEnfermedad = new ProxyEnfermedad.ServicioEnfermedadClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["codResultado"] != null)
                {
                    CargarResultado(Request.QueryString["codResultado"]);
                    CargarCombos();

                }
            }
        }


        private void CargarCombos()
        {
            // Cargar datos estáticos
            String[] sangre = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] orina = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] ekg = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] spirom = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] spic = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] rayos = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] audi = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };
            String[] vista = { "-No realizo-", "Resultados positivos", "Resultados Negativos" };

            cboSangre.DataSource = sangre;
            cboSangre.DataBind();
            cboOrina.DataSource = orina;
            cboOrina.DataBind();
            cboEkg.DataSource = ekg;
            cboEkg.DataBind();
            cboEspirometria.DataSource = spirom;
            cboEspirometria.DataBind();
            cboPsicologia.DataSource = spic;
            cboPsicologia.DataBind();
            cboRayosX.DataSource = rayos;
            cboRayosX.DataBind();
            cboAudicion.DataSource = audi;
            cboAudicion.DataBind();
            cboVista.DataSource = vista;
            cboVista.DataBind();

            try
            {
                cbocodEnfermedad.DataSource = objEnfermedad.ListarEnfermedad();
                cbocodEnfermedad.DataTextField = "descEnfermedad";
                cbocodEnfermedad.DataValueField = "codEnfermedad";
                cbocodEnfermedad.DataBind();
                cbocodEnfermedad.Items.Insert(0, new ListItem("--Seleccione--", ""));

                cbocodPaciente.DataSource = objServicioPaciente.usp_ListarPaciente();
                cbocodPaciente.DataTextField = "ApeNomPaciente";
                cbocodPaciente.DataValueField = "CodPaciente";
                cbocodPaciente.DataBind();
                cbocodPaciente.Items.Insert(0, new ListItem("--Seleccione--", ""));
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }



        private void CargarResultado(String codResultado)
        {
            try
            {
                ResultadoDC resultado = objServicioResultado.ConsultarResultado(codResultado);
                if (resultado != null)
                {

                    txtPeso.Text = resultado.peso.ToString();
                    txtAltura.Text = resultado.altura.ToString();
                    txtCodigo.Text = resultado.codResultado.ToString();
                    cboSangre.SelectedValue = resultado.sangre.ToString();
                    cboOrina.SelectedValue = resultado.orina.ToString();
                    cboEkg.SelectedValue = resultado.ekg.ToString();
                    cboEspirometria.SelectedValue = resultado.spirometria.ToString();
                    cboPsicologia.SelectedValue = resultado.psicologia;
                    
                    cboRayosX.SelectedValue = resultado.rayosX.ToString();
                    cboAudicion.SelectedValue = resultado.audicion.ToString();
                    cboVista.SelectedValue = resultado.vista.ToString();
                    cbocodEnfermedad.SelectedValue = resultado.codEnfermedad.ToString();
                    cbocodPaciente.SelectedValue = resultado.codPaciente.ToString();
                    
                    txtRecomendaciones.Text = resultado.recomendaciones;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: " + ex.Message);
            }
        }




        private void MostrarMensaje(string mensaje)
        {
            string script = $"<script type='text/javascript'>showAlert('{mensaje}');</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Alert", script);
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text) ||
                    string.IsNullOrWhiteSpace(txtRecomendaciones.Text) || cboSangre.SelectedIndex == 0 ||
                    cboOrina.SelectedIndex == 0 || cboEspirometria.SelectedIndex == 0 || cboPsicologia.SelectedIndex == 0 ||
                    cboRayosX.SelectedIndex == 0 || cboAudicion.SelectedIndex == 0 || cboVista.SelectedIndex == 0 ||
                    cboEkg.SelectedIndex == 0 || cbocodEnfermedad.SelectedIndex == 0 || cbocodPaciente.SelectedIndex == 0)
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                ResultadoDC resultado = new ResultadoDC
                {
                    codResultado = txtCodigo.Text,
                    peso = Convert.ToSingle(txtPeso.Text.Trim()),
                    altura = Convert.ToSingle(txtAltura.Text.Trim()),
                    sangre = cboSangre.SelectedItem.ToString(),
                    orina = cboOrina.SelectedItem.ToString(),
                    ekg = cboEkg.SelectedItem.ToString(),
                    spirometria = cboEspirometria.SelectedItem.ToString(),
                    psicologia = cboPsicologia.SelectedItem.ToString(),
                    rayosX = cboRayosX.SelectedItem.ToString(),
                    audicion = cboAudicion.SelectedItem.ToString(),
                    vista = cboVista.SelectedItem.ToString(),
                    codEnfermedad = cbocodEnfermedad.SelectedValue,
                    codPaciente = cbocodPaciente.SelectedValue,
                    recomendaciones = txtRecomendaciones.Text.Trim(),
                    Usu_Ult_Mod = "Andy",
                };

                bool resultadoActualizado = objServicioResultado.ActualizarResultado(resultado);
                if (resultadoActualizado)
                {
                    Response.Redirect("resultado01.aspx");
                }
                else
                {
                    throw new Exception("No se pudo actualizar el resultado, contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: " + ex.Message);
            }
        }
    }
}