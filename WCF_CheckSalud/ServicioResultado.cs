using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioResultado" en el código y en el archivo de configuración a la vez.
    public class ServicioResultado : IServicioResultado
    {
        public ResultadoDC ConsultarResultado(String codResultado)
        {

            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                var resultado = MiDB.usp_ConsultarResultado(codResultado).FirstOrDefault();


                if (resultado == null)
                {
                    return null;
                }
                ResultadoDC objResultadoDC = new ResultadoDC
                {
                    codResultado = resultado.codResultado.ToString(),
                    NomApePaciente = resultado.NomApePaciente.ToString(),
                    peso = Convert.ToSingle(resultado.peso),
                    altura = Convert.ToSingle(resultado.altura),
                    sangre = resultado.sangre.ToString(),
                    orina = resultado.orina.ToString(),
                    ekg = resultado.ekg.ToString(),
                    psicologia = resultado.psicologia.ToString(),
                    spirometria = resultado.spirometria.ToString(),
                    rayosX = resultado.rayosX.ToString(),
                    audicion = resultado.audicion.ToString(),
                    vista = resultado.vista.ToString(),
                    codAnalisis = resultado.codAnalisis.ToString(),
                    codEvaluacion = resultado.codEvaluacion.ToString(),
                    codEnfermedad = resultado.codEnfermedad.ToString(),
                    recomendaciones = resultado.recomendaciones.ToString(),
                    codPaciente = resultado.codPaciente.ToString(),



                };

                return objResultadoDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ResultadoDC> ListarResultado()
        {

            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                var resultados = MiDB.usp_ListarResultados().ToList();
                List<ResultadoDC> listaResultados = new List<ResultadoDC>();

                foreach (var item in resultados)
                {
                    ResultadoDC objResultadoDC = new ResultadoDC
                    {
                        codResultado = item.Codigo,
                        NomApePaciente = item.Paciente,
                        fecNac = Convert.ToDateTime(item.Fecha_de_nacimiento),
                        edad = Convert.ToInt16(item.Edad),
                        dni = item.DNI,
                        lugarTrabajo = item.Lugar_de_trabajo,
                        tipoExamen = item.Tipo_de_examen,
                        fechaEvaluacion = Convert.ToDateTime(item.Fecha_de_evaluacion),
                        peso = Convert.ToSingle(item.Peso__KG_),
                        altura = Convert.ToSingle(item.Altura__Mts_),
                        sangre = item.Examen_de_sangre,
                        orina = item.Examen_de_orina,
                        ekg = item.Electrocardiograma,
                        spirometria = item.Espirometria,
                        psicologia = item.Examen_psicologico,
                        rayosX = item.Rayos_X,
                        audicion = item.Examen_de_audicion,
                        vista = item.Examen_de_vista,
                        enfermedad = item.Enfermedad,
                        recomendaciones = item.Recomendaciones,
                        Evaluador = item.Medico_Evaluador,
                    };
                    listaResultados.Add(objResultadoDC);
                }

                return listaResultados;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarResultado(ResultadoDC objResultadoDC)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_InsertarResultado(
                    Convert.ToDecimal(objResultadoDC.peso),
                    Convert.ToDecimal(objResultadoDC.altura),
                    objResultadoDC.sangre,
                    objResultadoDC.orina,
                    objResultadoDC.ekg,
                    objResultadoDC.spirometria,
                    objResultadoDC.psicologia,
                    objResultadoDC.rayosX,
                    objResultadoDC.audicion,
                    objResultadoDC.vista,
                    objResultadoDC.codAnalisis,
                    objResultadoDC.codEvaluacion,
                    objResultadoDC.codEnfermedad,
                    objResultadoDC.recomendaciones,
                    objResultadoDC.codPaciente,
                    objResultadoDC.Usu_Registro);

                MiDB.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;

            }
        }

        public Boolean ActualizarResultado(ResultadoDC objResultadoDC)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_ActualizarResultado(
                    objResultadoDC.codResultado,
                    Convert.ToDecimal(objResultadoDC.peso),
                    Convert.ToDecimal(objResultadoDC.altura),
                    objResultadoDC.sangre,
                    objResultadoDC.orina,
                    objResultadoDC.ekg,
                    objResultadoDC.spirometria,
                    objResultadoDC.psicologia,
                    objResultadoDC.rayosX,
                    objResultadoDC.audicion,
                    objResultadoDC.vista,
                    objResultadoDC.codEnfermedad,
                    objResultadoDC.recomendaciones,
                    objResultadoDC.codPaciente,
                    objResultadoDC.Usu_Ult_Mod
                    );

                MiDB.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;

            }
        }

        public Boolean EliminarResultado(String codResultado)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_EliminarResultado(codResultado);

                MiDB.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

       

        

        

    }
}