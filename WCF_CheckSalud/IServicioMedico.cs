using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioMedico" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioMedico
    {
        [OperationContract]
        List<MedicoDC> usp_ListarMedico();
        [OperationContract]
        Boolean usp_InsertarMedico(MedicoDC objMedicoDC);
        [OperationContract]
        Boolean usp_ActualizarMedico(MedicoDC objMedicoDC);
        [OperationContract]
        Boolean usp_EliminarMedico(String strCodigo);
        [OperationContract]
        MedicoDC usp_ConsultarMedico(String strCodigo);

    }
    [DataContract]
    [Serializable]
    public class MedicoDC
    {
        [DataMember] public string CodMedico { get; set; }
        [DataMember] public string NomMedico { get; set; }
        [DataMember] public string ApeMedico { get; set; }
        [DataMember] public string ApeNomMedico { get; set; }
        [DataMember] public string CodEspecialidad { get; set; }
        [DataMember] public string Especialidad { get; set; }
        [DataMember] public string Estado { get; set; }
        [DataMember] public DateTime FecNacMedico { get; set; }
        [DataMember] public int Edad { get; set; }
        [DataMember] public string DniMedico { get; set; }
        [DataMember] public string DirecMedico { get; set; }
        [DataMember] public string IdUbigeo { get; set; }
        [DataMember] public string departamento { get; set; }
        [DataMember] public string provincia { get; set; }
        [DataMember] public string distrito { get; set; }
        [DataMember] public string EmailMedico { get; set; }
        [DataMember] public string numColegiatura { get; set; }
        [DataMember] public string LoginUsuario { get; set; }
        [DataMember] public DateTime FecIngreso { get; set; }
        [DataMember] public DateTime FecRegistro { get; set; }
        [DataMember] public String UsuRegistro { get; set; }
        [DataMember] public DateTime FecUltMod { get; set; }
        [DataMember] public String UsuUltMod { get; set; }
        [DataMember] public int Est_Medico { get; set; }
    }



}