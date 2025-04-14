using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEnfermedad" en el código y en el archivo de configuración a la vez.
    public class ServicioEnfermedad : IServicioEnfermedad
    {
        public List<EnfermedadDC> ListarEnfermedad()
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                var enfermedades = MiDB.usp_ListarEnfermedad().ToList();
                List<EnfermedadDC> listaEnfermedades = new List<EnfermedadDC>();

                foreach (var item in enfermedades)
                {
                    EnfermedadDC objEnfermedadDC = new EnfermedadDC
                    {
                        codEnfermedad = item.codEnfermedad,
                        descEnfermedad = item.descEnfermedad
                    };
                    listaEnfermedades.Add(objEnfermedadDC);
                }

                return listaEnfermedades;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
