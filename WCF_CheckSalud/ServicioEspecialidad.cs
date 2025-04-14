using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEspecialidad" en el código y en el archivo de configuración a la vez.
    public class ServicioEspecialidad : IServicioEspecialidad
    {
        public List<EspecialidadDC> usp_ListarEspecialidad()
        {
            try
            {
                // Instanciamos el modelo
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                // Creamos una lista Especialidad
                List<EspecialidadDC> objLista = new List<EspecialidadDC>();

                // Hacemos la consulta con LINQ para obtener las especialidades
                var query = MiDB.Tb_Especialidad
                                .OrderBy(e => e.codEspecialidad)
                                .Select(e => new { e.codEspecialidad, e.descEspecialidad })
                                .ToList();

                foreach (var resultado in query)
                {
                    EspecialidadDC objEspecialidadDC = new EspecialidadDC
                    {
                        CodEspecialidad = resultado.codEspecialidad,
                        DescEspecialidad = resultado.descEspecialidad
                    };

                    objLista.Add(objEspecialidadDC);
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
