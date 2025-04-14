using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public Boolean usp_InsertarUsuario(UsuarioDC objUsuarioDC)
        {
            try
            {
                using (BDCheckSaludEntities MiDB = new BDCheckSaludEntities())
                {
                    MiDB.usp_InsertarUsuario(
                        objUsuarioDC.LoginUsuario,
                        objUsuarioDC.PassUsuario,
                        objUsuarioDC.UsuRegistro
                    );

                    MiDB.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
