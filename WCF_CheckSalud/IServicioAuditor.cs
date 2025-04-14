using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAuditor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAuditor
    {
        [OperationContract]
        List<AuditorDC> ListarAuditor();
    }


    [DataContract]
    [Serializable]
    public class AuditorDC
    {
        [DataMember]
        public string codAuditor { get; set; }

        [DataMember]
        public string Auditor { get; set; }
    }

}
