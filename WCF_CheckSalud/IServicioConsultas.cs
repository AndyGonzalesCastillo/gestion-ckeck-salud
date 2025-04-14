using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConsultas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<ResultConsultas> sp_VerConsultasPendientes();
        [OperationContract]
        List<ResultConsultas> sp_ListarConsultasPaciente(String strCodigo, String estado);
        [OperationContract]
        List<ResultConsultas> sp_ConsultasAsignadasMedico(String strCodigo, String estado );
        [OperationContract]
        List<ResultConsultas> sp_ConsultaEspecialidadFechas(DateTime? fecIni, DateTime? fecFin);

        [OperationContract]
        List<ResultConsultas> sp_GetConsultasByDate(DateTime date);
    }
    [DataContract]
    [Serializable]
    public class ResultConsultas
    {  

        //CONSULTA MEDICA
        [DataMember] public string codConsulta { get; set; }
        [DataMember] public string codMedico { get; set; }
        [DataMember] public string codPaciente { get; set; }
        [DataMember] public string NomMedico { get; set; }
     
        [DataMember] public string NomPaciente { get; set; }
        [DataMember] public string motivoConsulta { get; set; }
        [DataMember] public string resultadoConsulta { get; set; }
        [DataMember] public DateTime fechConsulta { get; set; }
        [DataMember] public string especialidadMedico { get; set; }

        [DataMember] public string estadoConsulta { get; set; }

        [DataMember] public int totalConsultas { get; set; }


    }
}