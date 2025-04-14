using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEmpresa" en el código y en el archivo de configuración a la vez.
    public class ServicioEmpresa : IServicioEmpresa
    {
        public List<EmpresaDC> usp_ListarEmpresa()
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<EmpresaDC> objListaEmpresaDC = new List<EmpresaDC>();

                //hacemos el query
                var query = (from miEmpresa in MiDB.Tb_Empresa
                             orderby miEmpresa.codEmpresa
                             select miEmpresa).ToList();

                //agregamos cada resultado del query a la lista
                foreach (var objEmpresa in query)
                {
                    EmpresaDC objEmpresaDC = new EmpresaDC();
                    objEmpresaDC.codEmpresa = objEmpresa.codEmpresa;
                    objEmpresaDC.RazSocEmpresa = objEmpresa.Raz_soc_emp;
                    objEmpresaDC.RucEmpresa = objEmpresa.Ruc_emp;
                    objEmpresaDC.RepEmpresa = objEmpresa.Rep_emp;
                    objEmpresaDC.DirecEmpresa = objEmpresa.Dir_emp;
                    objEmpresaDC.IdUbigeo = objEmpresa.Id_Ubigeo;
                    objEmpresaDC.departamento = objEmpresa.Tb_Ubicacion.Departamento;
                    objEmpresaDC.provincia = objEmpresa.Tb_Ubicacion.Provincia;
                    objEmpresaDC.distrito = objEmpresa.Tb_Ubicacion.Distrito;
                    objEmpresaDC.TelEmpresa = objEmpresa.Tel_emp;
                    objEmpresaDC.FecIngreso = Convert.ToDateTime(objEmpresa.fec_Ingreso);
                    objEmpresaDC.Est_Empresa = Convert.ToInt16(objEmpresa.estado);
                    if (objEmpresa.estado == 1)
                    {
                        objEmpresaDC.Estado = "Activo";
                    }
                    else
                    {
                        objEmpresaDC.Estado = "Inactivo";
                    }

                    objListaEmpresaDC.Add(objEmpresaDC);
                }

                //devolvemos la lista
                return objListaEmpresaDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ListarEmpresa

        public Boolean usp_InsertarEmpresa(EmpresaDC objEmpresaDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_InsertarEmpresa(
                    objEmpresaDC.RazSocEmpresa,
                    objEmpresaDC.DirecEmpresa,
                    objEmpresaDC.TelEmpresa,
                    objEmpresaDC.RucEmpresa,
                    objEmpresaDC.RepEmpresa,
                    objEmpresaDC.IdUbigeo,
                    objEmpresaDC.Est_Empresa);

                MiDB.SaveChanges();

                //Devolvemos true para indicar que se ejecutó el SP con éxito
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//InsertarEmpresa

        public Boolean usp_ActualizarEmpresa(EmpresaDC objEmpresaDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_ActualizarEmpresa(
                    objEmpresaDC.codEmpresa,
                    objEmpresaDC.RazSocEmpresa,
                    objEmpresaDC.DirecEmpresa,
                    objEmpresaDC.TelEmpresa,
                    objEmpresaDC.RucEmpresa,
                    objEmpresaDC.RepEmpresa,
                    objEmpresaDC.IdUbigeo,
                    objEmpresaDC.Est_Empresa);

                MiDB.SaveChanges();

                //Devolvemos true para indicar que se ejecutó el SP con éxito
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ActualizarEmpresa

        public Boolean usp_EliminarEmpresa(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_EliminarEmpresa(strCodigo);

                MiDB.SaveChanges();

                //Devolvemos true para indicar que se ejecutó el SP con éxito
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }//EliminarEmpresa

        public EmpresaDC usp_ConsultarEmpresa(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (un objeto EmpresaDC)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                EmpresaDC objEmpresaDC = new EmpresaDC();

                //hacemos el query y guardamos el primer resultado en un objEmpresa
                Tb_Empresa objEmpresa = (
                    from miEmpresa in MiDB.Tb_Empresa
                    where miEmpresa.codEmpresa == strCodigo
                    select miEmpresa).FirstOrDefault();

                //Si la empresa no existe, el objeto que devolvamos tendrá un codEmpresa vacío
                if (objEmpresa == null)
                {
                    objEmpresaDC.codEmpresa = String.Empty;
                }
                //si la empresa existe, añadimos sus datos al objeto EmpresaDC
                else
                {
                    objEmpresaDC.codEmpresa = objEmpresa.codEmpresa;
                    objEmpresaDC.RazSocEmpresa = objEmpresa.Raz_soc_emp;
                    objEmpresaDC.RucEmpresa = objEmpresa.Ruc_emp;
                    objEmpresaDC.Est_Empresa = Convert.ToInt16(objEmpresa.estado);
                    if (objEmpresa.estado == 1)
                    {
                        objEmpresaDC.Estado = "Activo";
                    }
                    else
                    {
                        objEmpresaDC.Estado = "Inactivo";
                    }
                    objEmpresaDC.IdUbigeo = objEmpresa.Id_Ubigeo;
                    objEmpresaDC.departamento = objEmpresa.Tb_Ubicacion.Departamento;
                    objEmpresaDC.provincia = objEmpresa.Tb_Ubicacion.Provincia;
                    objEmpresaDC.distrito = objEmpresa.Tb_Ubicacion.Distrito;
                    objEmpresaDC.DirecEmpresa = objEmpresa.Dir_emp;
                    objEmpresaDC.TelEmpresa = objEmpresa.Tel_emp;
                    objEmpresaDC.FecIngreso = Convert.ToDateTime(objEmpresa.fec_Ingreso);
                    objEmpresaDC.RepEmpresa = objEmpresa.Rep_emp;
                }

                //devolvemos el objeto EmpresaDC
                return objEmpresaDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ConsultarEmpresa
        public Boolean usp_ExisteRuc(String ruc) // Implementación del nuevo método
        {
            try
            {
                using (var context = new BDCheckSaludEntities())
                {
                    return context.Tb_Empresa.Any(e => e.Ruc_emp == ruc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }//class
}



