using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEvaluacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEvaluacion
    {
        [OperationContract]
        Boolean InsertarEvaluacion(EvaluacionDC objEvaluacionDC);

        [OperationContract]
        EvaluacionDC ConsultarEvaluacion();
    }

    [DataContract]
    public class EvaluacionDC
    {
        [DataMember]
        public String codEvaluacion { get; set; }

        [DataMember]
        public DateTime fechaEvaluacion { get; set; }

        [DataMember]
        public string codMedico { get; set; }

        [DataMember]
        public string codAuditor { get; set; }

        [DataMember]
        public int Est_Evaluacion { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

    }
}
