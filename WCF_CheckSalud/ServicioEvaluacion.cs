using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEvaluacion" en el código y en el archivo de configuración a la vez.
    public class ServicioEvaluacion : IServicioEvaluacion
    {
        public Boolean InsertarEvaluacion(EvaluacionDC objEvaluacionDC)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_InsertarEvaluacion(
                    objEvaluacionDC.fechaEvaluacion,
                    objEvaluacionDC.codMedico,
                    objEvaluacionDC.codAuditor,
                    objEvaluacionDC.Est_Evaluacion,
                    objEvaluacionDC.Usu_Registro);
                MiDB.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EvaluacionDC ConsultarEvaluacion()
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                var resultado = MiDB.usp_ListarUltEvaluacion().FirstOrDefault();

                if (resultado == null)
                {
                    return null;
                }

                EvaluacionDC objEvaluacionDC = new EvaluacionDC
                {
                    codEvaluacion = resultado.codEvaluacion,
                    fechaEvaluacion = Convert.ToDateTime(resultado.Fec_Eva),
                    codMedico = resultado.codMedico,
                    codAuditor = resultado.codAuditor,
                    Est_Evaluacion = Convert.ToInt16(resultado.estado),
                    Estado = resultado.estado == 1 ? "Activo" : "Inactivo",
                    Usu_Registro = resultado.Usu_Registro,

                };

                return objEvaluacionDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
