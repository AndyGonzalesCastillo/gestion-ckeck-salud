using System;
using System.Data;
using System.Web.UI;
using TestWeb_WCF_CheckSalud.ProxyResultado;
using TestWeb_WCF_CheckSalud.ProxyPaciente;
using TestWeb_WCF_CheckSalud.ProxyMedico;
using TestWeb_WCF_CheckSalud.ProxyAnalisis;
using System.Web.UI.WebControls;
using TestWeb_WCF_CheckSalud.ProxyEvaluacion;

namespace TestWeb_WCF_CheckSalud
{
    public partial class Resultado02 : System.Web.UI.Page
    {
        ProxyResultado.ServicioResultadoClient objServicioResultado = new ProxyResultado.ServicioResultadoClient();
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyMedico.ServicioMedicoClient objServicioMedico = new ProxyMedico.ServicioMedicoClient();
        ProxyAnalisis.ServicioAnalisisClient objServicioAnalisis = new ProxyAnalisis.ServicioAnalisisClient();
        ProxyAuditor.ServicioAuditorClient objAuditor = new ProxyAuditor.ServicioAuditorClient();
        ProxyEnfermedad.ServicioEnfermedadClient objEnfermedad = new ProxyEnfermedad.ServicioEnfermedadClient();
        ProxyEvaluacion.ServicioEvaluacionClient objEvaluacion = new ProxyEvaluacion.ServicioEvaluacionClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombos();
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
                // Llenar los combos desde el servicio web
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

                cboMedico.DataSource = objServicioMedico.usp_ListarMedico();
                cboMedico.DataTextField = "ApeNomMedico";
                cboMedico.DataValueField = "CodMedico";
                cboMedico.DataBind();
                cboMedico.Items.Insert(0, new ListItem("--Seleccione--", ""));

                cboAuditor.DataSource = objAuditor.ListarAuditor();
                cboAuditor.DataTextField = "Auditor";
                cboAuditor.DataValueField = "codAuditor";
                cboAuditor.DataBind();
                cboAuditor.Items.Insert(0, new ListItem("--Seleccione--", ""));
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPeso.Text.Trim() == "" || txtAltura.Text.Trim() == "" || txtRecomendaciones.Text.Trim() == "" ||
                    cboSangre.SelectedIndex == 0 || cboOrina.SelectedIndex == 0 || cboEkg.SelectedIndex == 0 ||
                    cboEspirometria.SelectedIndex == 0 || cboPsicologia.SelectedIndex == 0 || cboRayosX.SelectedIndex == 0 ||
                    cboAudicion.SelectedIndex == 0 || cboVista.SelectedIndex == 0 || cbocodEnfermedad.SelectedIndex == 0 ||
                    cbocodPaciente.SelectedIndex == 0 || cboMedico.SelectedIndex == 0 || cboAuditor.SelectedIndex == 0)
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                // Validar y convertir la fecha de evaluación
                DateTime fechaEvaluacion;
                if (!DateTime.TryParseExact(txtFechaEval.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaEvaluacion))
                {
                    throw new Exception("La fecha de evaluación no tiene un formato válido. Utilice el formato dd/MM/yyyy.");
                }

                // Crear objetos y asignar valores
                ResultadoDC objResultadoBE = new ResultadoDC
                {
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
                    recomendaciones = txtRecomendaciones.Text.Trim(),
                    codEnfermedad = cbocodEnfermedad.SelectedValue.ToString(),
                    codPaciente = cbocodPaciente.SelectedValue.ToString(),
                    Usu_Registro = "andy" // Cambia esto por el usuario actual
                };

                AnalisisDC objAnalisisBE = new AnalisisDC
                {
                    descAnalisis = "EXAMEN PREOCUPACIONAL",
                    costo = Convert.ToSingle(txtCosto.Text.Trim()),
                    Usu_Registro = "andy" // Cambia esto por el usuario actual
                     
                };

                EvaluacionDC objEvaluacionBE = new EvaluacionDC
                {
                    fechaEvaluacion = fechaEvaluacion,
                    codMedico = cboMedico.SelectedValue.ToString(),
                    codAuditor = cboAuditor.SelectedValue.ToString(),
                    Usu_Registro = "andy" // Cambia esto por el usuario actual
                };

                // Insertar análisis
                if (objServicioAnalisis.InsertarAnalisis(objAnalisisBE))
                {
                    // Insertar evaluación
                    if (objEvaluacion.InsertarEvaluacion(objEvaluacionBE))
                    {
                        // Consultar los últimos análisis y evaluación
                        objAnalisisBE = objServicioAnalisis.ConsultarUltimoAnalisis();
                        objEvaluacionBE = objEvaluacion.ConsultarEvaluacion();

                        // Asignar códigos al objeto resultado
                        objResultadoBE.codAnalisis = objAnalisisBE.codAnalisis;
                        objResultadoBE.codEvaluacion = objEvaluacionBE.codEvaluacion;

                        // Insertar resultado
                        if (objServicioResultado.InsertarResultado(objResultadoBE))
                        {
                            Response.Redirect("resultado01.aspx");
                        }
                        else
                        {
                            throw new Exception("No se pudo insertar el resultado, contacte con IT.");
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar la evaluación, contacte con IT.");
                    }
                }
                else
                {
                    throw new Exception("No se pudo insertar el análisis, contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }
    }
}