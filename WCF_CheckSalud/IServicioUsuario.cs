using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Boolean usp_InsertarUsuario(UsuarioDC objUsuarioDC);
    }

    [DataContract]
    [Serializable]
    public class UsuarioDC
    {
        [DataMember] public string LoginUsuario { get; set; }
        [DataMember] public string PassUsuario { get; set; }
        [DataMember] public string UsuRegistro { get; set; }
    }
}
