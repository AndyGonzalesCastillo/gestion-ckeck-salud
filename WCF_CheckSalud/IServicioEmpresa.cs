using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEmpresa" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEmpresa
    {
        [OperationContract]
        List<EmpresaDC> usp_ListarEmpresa();
        [OperationContract]
        Boolean usp_InsertarEmpresa(EmpresaDC objEmpresaDC);
        [OperationContract]
        Boolean usp_ActualizarEmpresa(EmpresaDC objEmpresaDC);
        [OperationContract]
        Boolean usp_EliminarEmpresa(String strCodigo);
        [OperationContract]
        EmpresaDC usp_ConsultarEmpresa(String strCodigo);
        [OperationContract]
        Boolean usp_ExisteRuc(String ruc);
    }

    [DataContract]
    [Serializable]
    public class EmpresaDC
    {
        [DataMember] public string codEmpresa { get; set; }
        [DataMember] public string RazSocEmpresa { get; set; }
        [DataMember] public string RucEmpresa { get; set; }
        [DataMember] public string DirecEmpresa { get; set; }
        [DataMember] public string TelEmpresa { get; set; }
        [DataMember] public string RepEmpresa { get; set; }
        [DataMember] public string IdUbigeo { get; set; }
        [DataMember] public string departamento { get; set; }
        [DataMember] public string provincia { get; set; }
        [DataMember] public string distrito { get; set; }
        [DataMember] public DateTime FecIngreso { get; set; }
        [DataMember] public string Estado { get; set; }
        [DataMember] public int Est_Empresa { get; set; }
    }
}
