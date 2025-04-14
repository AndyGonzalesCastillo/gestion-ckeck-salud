using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEnfermedad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEnfermedad
    {
        [OperationContract]
        List<EnfermedadDC> ListarEnfermedad();
    }

    [DataContract]
    [Serializable]
    public class EnfermedadDC
    {
        [DataMember]
        public string codEnfermedad { get; set; }

        [DataMember]
        public string descEnfermedad { get; set; }
    }
}
