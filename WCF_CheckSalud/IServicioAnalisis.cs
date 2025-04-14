using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAnalisis" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAnalisis
    {
        [OperationContract]
        AnalisisDC ConsultarAnalisis(String codAnalisis);

        [OperationContract]
        List<AnalisisDC> ListarAnalisis();

        [OperationContract]
        Boolean InsertarAnalisis(AnalisisDC objAnalisisDC);

        [OperationContract]
        Boolean ActualizarAnalisis(AnalisisDC objAnalisisDC);

        [OperationContract]
        Boolean EliminarAnalisis(String codAnalisis);

        [OperationContract]
        AnalisisDC ConsultarUltimoAnalisis();

    }

    [DataContract]
    [Serializable]
    public class AnalisisDC
    {
        [DataMember] public String codAnalisis { get; set; }
        [DataMember] public String descAnalisis { get; set; }
        [DataMember] public Single costo { get; set; }
        [DataMember] public int estAnalisis { get; set; }
        [DataMember] public String estado { get; set; }
        [DataMember] public DateTime Fec_reg { get; set; }
        [DataMember] public String Usu_Registro { get; set; }
        [DataMember] public DateTime Fec_Ult_Mod { get; set; }
        [DataMember] public String Usu_Ult_Mod { get; set; }

    }
}
