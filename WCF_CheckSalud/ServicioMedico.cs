using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioMedico" en el código y en el archivo de configuración a la vez.
    public class ServicioMedico : IServicioMedico
    {
        public List<MedicoDC> usp_ListarMedico()
        {
            try
            {
                // Instanciamos el modelo
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                // Creamos una lista Medico
                List<MedicoDC> objListaMedicoDC = new List<MedicoDC>();

                // Hacemos la consulta con LINQ para obtener los médicos en un rango de fechas
                var query = (from miMedico in MiDB.Tb_Medico
                             orderby miMedico.codMedico
                             select miMedico).ToList();

                foreach (var objMedico in query)
                {
                    MedicoDC objMedicoDC = new MedicoDC();
                    objMedicoDC.CodMedico = objMedico.codMedico;
                    objMedicoDC.NomMedico = objMedico.nomMedico;
                    objMedicoDC.ApeMedico = objMedico.apeMedico;
                    objMedicoDC.ApeNomMedico = objMedico.apeMedico + ", " + objMedico.nomMedico;
                    objMedicoDC.CodEspecialidad= Convert.ToString(objMedico.codEspecialidad);
                    objMedicoDC.Especialidad = Convert.ToString(objMedico.Tb_Especialidad.descEspecialidad);
                    objMedicoDC.Est_Medico = Convert.ToInt16(objMedico.estado);
                    if (objMedico.estado == 1)
                    {
                        objMedicoDC.Estado = "Activo";
                    }
                    else
                    {
                        objMedicoDC.Estado = "Inactivo";
                    }
                    objMedicoDC.FecNacMedico = objMedico.fechaNacimiento;
                    objMedicoDC.Edad = DateTime.Now.Year - objMedico.fechaNacimiento.Year; // Calcula la edad a partir de la fecha de nacimiento.
                    objMedicoDC.DniMedico = objMedico.dniMedic;
                    objMedicoDC.DirecMedico = objMedico.direcMedico;
                    objMedicoDC.EmailMedico = objMedico.emailMedico;
                    objMedicoDC.LoginUsuario = objMedico.Login_Usuario;
                    objMedicoDC.IdUbigeo = objMedico.Id_Ubigeo;
                    objMedicoDC.departamento = objMedico.Tb_Ubicacion.Departamento;
                    objMedicoDC.provincia = objMedico.Tb_Ubicacion.Provincia;
                    objMedicoDC.distrito = objMedico.Tb_Ubicacion.Distrito;
                    objMedicoDC.numColegiatura=objMedico.numColegiatura;
                    objMedicoDC.FecIngreso = Convert.ToDateTime(objMedico.fec_ingreso);
                    objMedicoDC.FecRegistro = Convert.ToDateTime(objMedico.Fec_Reg);
                    objMedicoDC.UsuRegistro = Convert.ToString(objMedico.Usu_Registro);
                    objMedicoDC.UsuUltMod = Convert.ToString(objMedico.Usu_Ult_Mod);
                    objMedicoDC.FecUltMod = Convert.ToDateTime(objMedico.Fech_Ult_Mod);

                    // Agregamos la instancia a la colección
                    objListaMedicoDC.Add(objMedicoDC);
                }

                return objListaMedicoDC;
            }
            catch (Exception ex)
            {
                throw new FaultException<string>(ex.Message); // Usamos FaultException para manejar excepciones de manera adecuada.
            }
        }//ListarMedico

        public Boolean usp_InsertarMedico(MedicoDC objMedicoDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_InsertarMedico(
                    objMedicoDC.DniMedico,
                    objMedicoDC.NomMedico,
                    objMedicoDC.ApeMedico,
                    objMedicoDC.numColegiatura,
                    objMedicoDC.FecNacMedico,
                    objMedicoDC.EmailMedico,
                    objMedicoDC.DirecMedico,
                    objMedicoDC.Est_Medico,
                    objMedicoDC.CodEspecialidad,
                    objMedicoDC.LoginUsuario,
                    objMedicoDC.UsuRegistro,
                    objMedicoDC.IdUbigeo,
                    objMedicoDC.FecIngreso);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//InsertarMedico

        public Boolean usp_ActualizarMedico(MedicoDC objMedicoDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_ActualizarMedico(
                    objMedicoDC.CodMedico,
                    objMedicoDC.DniMedico,
                    objMedicoDC.NomMedico,
                    objMedicoDC.ApeMedico,
                    objMedicoDC.numColegiatura,
                    objMedicoDC.FecNacMedico,
                    objMedicoDC.EmailMedico,
                    objMedicoDC.DirecMedico,
                    objMedicoDC.Est_Medico,
                    objMedicoDC.CodEspecialidad,
                    objMedicoDC.LoginUsuario,
                    objMedicoDC.UsuUltMod,
                    objMedicoDC.IdUbigeo);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ActualizarMedico

        public Boolean usp_EliminarMedico(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_EliminarMedico(strCodigo);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }//EliminarMedico

        public MedicoDC usp_ConsultarMedico(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (un objeto MedicoDC)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                MedicoDC objMedicoDC = new MedicoDC();

                Tb_Medico objMedico = (
                    from miMedico in MiDB.Tb_Medico
                    where miMedico.codMedico ==  strCodigo
                    select miMedico).FirstOrDefault();

                if(objMedico == null)
                {
                    objMedicoDC.CodMedico = String.Empty;
                }
                else
                {
                    objMedicoDC.CodMedico = objMedico.codMedico;
                    objMedicoDC.NomMedico = objMedico.nomMedico;
                    objMedicoDC.ApeMedico = objMedico.apeMedico;
                    objMedicoDC.ApeNomMedico = objMedico.apeMedico + ", " + objMedico.nomMedico;
                    objMedicoDC.CodEspecialidad = Convert.ToString(objMedico.codEspecialidad);
                    objMedicoDC.Especialidad = Convert.ToString(objMedico.Tb_Especialidad.descEspecialidad);
                    objMedicoDC.Est_Medico = Convert.ToInt16(objMedico.estado);
                    if (objMedico.estado == 1)
                    {
                        objMedicoDC.Estado = "Activo";
                    }
                    else
                    {
                        objMedicoDC.Estado = "Inactivo";
                    }
                    objMedicoDC.FecNacMedico = objMedico.fechaNacimiento;
                    objMedicoDC.Edad = DateTime.Now.Year - objMedico.fechaNacimiento.Year; // Calcula la edad a partir de la fecha de nacimiento.
                    objMedicoDC.DniMedico = objMedico.dniMedic;
                    objMedicoDC.DirecMedico = objMedico.direcMedico;
                    objMedicoDC.EmailMedico = objMedico.emailMedico;
                    objMedicoDC.IdUbigeo = objMedico.Id_Ubigeo;
                    objMedicoDC.departamento = objMedico.Tb_Ubicacion.Departamento;
                    objMedicoDC.LoginUsuario = objMedico.Login_Usuario;
                    objMedicoDC.provincia = objMedico.Tb_Ubicacion.Provincia;
                    objMedicoDC.distrito = objMedico.Tb_Ubicacion.Distrito;
                    objMedicoDC.numColegiatura = objMedico.numColegiatura;
                    objMedicoDC.FecIngreso = Convert.ToDateTime(objMedico.fec_ingreso);
                    objMedicoDC.FecRegistro = Convert.ToDateTime(objMedico.Fec_Reg);
                    objMedicoDC.UsuRegistro = Convert.ToString(objMedico.Usu_Registro);
                    objMedicoDC.UsuUltMod = Convert.ToString(objMedico.Usu_Ult_Mod);
                    objMedicoDC.FecUltMod = Convert.ToDateTime(objMedico.Fech_Ult_Mod);
                }

                return objMedicoDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ConsultarMedico

    }
}