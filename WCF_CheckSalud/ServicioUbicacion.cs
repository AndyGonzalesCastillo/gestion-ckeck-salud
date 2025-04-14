using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbicacion" en el código y en el archivo de configuración a la vez.
    public class ServicioUbicacion : IServicioUbicacion
    {
        public List<UbicacionDC> usp_ListarUbicacion()
        {
            try
            {
                // Instanciamos el modelo
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                // Creamos una lista Ubicacion
                List<UbicacionDC> objLista = new List<UbicacionDC>();

                // Hacemos la consulta con LINQ para obtener las ubicaciones, pero solo seleccionando las columnas Id_Ubigeo y Distrito
                var query = MiDB.Tb_Ubicacion
                                 .OrderBy(u => u.Id_Ubigeo)
                                .Select(u => new { u.Id_Ubigeo, u.Distrito })
                                .ToList();

                foreach (var resultado in query)
                {
                    UbicacionDC objUbicacionDC = new UbicacionDC
                    {
                        Id_Ubigeo = resultado.Id_Ubigeo,
                        Distrito = resultado.Distrito
                    };

                    objLista.Add(objUbicacionDC);
                }

                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
