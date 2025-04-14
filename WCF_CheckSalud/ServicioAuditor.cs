using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAuditor" en el código y en el archivo de configuración a la vez.
    public class ServicioAuditor : IServicioAuditor
    {
        public List<AuditorDC> ListarAuditor()
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                var auditores = MiDB.usp_ListarAuditor().ToList();
                List<AuditorDC> listaAuditores = new List<AuditorDC>();

                foreach (var item in auditores)
                {
                    AuditorDC objAuditorDC = new AuditorDC
                    {
                        codAuditor = item.codAuditor,
                        Auditor = item.Auditor
                    };
                    listaAuditores.Add(objAuditorDC);
                }

                return listaAuditores;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
