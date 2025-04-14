using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPaciente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPaciente
    {
        [OperationContract]
        List<PacienteDC> usp_ListarPaciente();
        [OperationContract]
        Boolean usp_InsertarPaciente(PacienteDC objPacienteDC);
        [OperationContract]
        Boolean usp_ActualizarPaciente(PacienteDC objPacienteDC);
        [OperationContract]
        Boolean usp_EliminarPaciente(String strCodigo);
        [OperationContract]
        PacienteDC usp_ConsultarPaciente(String strCodigo);
    }
    [DataContract]
    [Serializable]
    public class PacienteDC
    {
        [DataMember] public string CodPaciente { get; set; }
        [DataMember] public string NomPaciente { get; set; }
        [DataMember] public string ApePaciente { get; set; }
        [DataMember] public string ApeNomPaciente { get; set; }
        [DataMember] public string Estado { get; set; }
        [DataMember] public DateTime FecNacPaciente { get; set; }        
        [DataMember] public string DniPaciente { get; set; }
        [DataMember] public int Sexo_Paciente {  get; set; }
        [DataMember] public String Sexo { get; set; }
        [DataMember] public int Edad { get; set; }


        [DataMember] public string DirecPaciente { get; set; }
        [DataMember] public string TipoSangre { get; set; }

        [DataMember] public int Tipo_Sangre { get; set; }


        [DataMember] public string IdUbigeo { get; set; }
        [DataMember] public string departamento { get; set; }
        [DataMember] public string provincia { get; set; }
        [DataMember] public string distrito { get; set; }
        [DataMember] public string EmailPaciente { get; set; }
        [DataMember] public string TelPaciente { get; set; }
        [DataMember] public int Tipo_Cliente { get; set; }
        [DataMember] public String Tipo { get; set; }
        [DataMember] public string CodEmpresa { get; set; }
        [DataMember] public string LugarTrabajo { get; set; }
        [DataMember] public DateTime FecIngreso { get; set; }
        [DataMember] public DateTime FecRegistro { get; set; }
        [DataMember] public String UsuRegistro { get; set; }
        [DataMember] public DateTime FecUltMod { get; set; }
        [DataMember] public String UsuUltMod { get; set; }
        [DataMember] public int Est_Paciente { get; set; }
    }
}