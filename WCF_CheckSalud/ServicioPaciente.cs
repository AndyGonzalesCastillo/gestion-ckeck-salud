using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPaciente" en el código y en el archivo de configuración a la vez.
    public class ServicioPaciente : IServicioPaciente
    {
        public List<PacienteDC> usp_ListarPaciente()
        {
            try
            {
                // Instanciamos el modelo
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<PacienteDC> objListaPacienteDC = new List<PacienteDC>();

                var query = (from miPaciente in MiDB.Tb_Paciente
                             orderby miPaciente.codPaciente
                             select miPaciente).ToList();

                foreach (var objPaciente in query)
                {
                    PacienteDC objPacienteDC = new PacienteDC();
                    objPacienteDC.CodPaciente = objPaciente.codPaciente;
                    objPacienteDC.NomPaciente = objPaciente.nomPaciente;
                    objPacienteDC.ApePaciente = objPaciente.apePaciente;
                    objPacienteDC.ApeNomPaciente = objPaciente.apePaciente + ", " + objPaciente.nomPaciente;
                    objPacienteDC.FecNacPaciente = objPaciente.fechaNacimiento;
                    objPacienteDC.CodEmpresa = objPaciente.codEmpresa;
                    objPacienteDC.Est_Paciente = Convert.ToInt16(objPaciente.estado);

                    if (objPaciente.estado == 1)
                    {
                        objPacienteDC.Estado = "Activo";
                    }
                    else
                    {
                        objPacienteDC.Estado = "Inactivo";
                    }
                    objPacienteDC.DniPaciente = objPaciente.dniPaciente;
                    objPacienteDC.Sexo_Paciente = Convert.ToInt16(objPaciente.sexo);
                    if (objPaciente.sexo == 0)
                    {
                        objPacienteDC.Sexo = "Masculino";
                    }
                    else
                    {
                        objPacienteDC.Sexo = "femenino";
                    }
                    objPacienteDC.DirecPaciente = objPaciente.direcPaciente;
                    // Asignamos directamente el valor de tipoSangre como string
                    objPacienteDC.TipoSangre = objPaciente.tipoSangre;

                    // Convertimos el tipoSangre a entero y lo asignamos a Tipo_Sangre
                    if (objPaciente.tipoSangre == "0")
                    {
                        objPacienteDC.Tipo_Sangre = 0;
                        objPacienteDC.TipoSangre = "A+";
                    }
                    else if (objPaciente.tipoSangre == "1")
                    {
                        objPacienteDC.Tipo_Sangre = 1;
                        objPacienteDC.TipoSangre = "B+";
                    }
                    else if (objPaciente.tipoSangre == "2")
                    {
                        objPacienteDC.Tipo_Sangre = 2;
                        objPacienteDC.TipoSangre = "AB+";
                    }
                    else if (objPaciente.tipoSangre == "3")
                    {
                        objPacienteDC.Tipo_Sangre = 3;
                        objPacienteDC.TipoSangre = "O+";
                    }
                    else if (objPaciente.tipoSangre == "4")
                    {
                        objPacienteDC.Tipo_Sangre = 4;
                        objPacienteDC.TipoSangre = "A-";
                    }
                    else if (objPaciente.tipoSangre == "5")
                    {
                        objPacienteDC.Tipo_Sangre = 5;
                        objPacienteDC.TipoSangre = "B-";
                    }
                    else if (objPaciente.tipoSangre == "6")
                    {
                        objPacienteDC.Tipo_Sangre = 6;
                        objPacienteDC.TipoSangre = "AB-";
                    }
                    else if (objPaciente.tipoSangre == "7")
                    {
                        objPacienteDC.Tipo_Sangre = 7;
                        objPacienteDC.TipoSangre = "O-";
                    }
                    else
                    {
                        objPacienteDC.Tipo_Sangre = -1; // Un valor que represente "Desconocido"
                        objPacienteDC.TipoSangre = "Desconocido";
                    }

                    objPacienteDC.IdUbigeo = objPaciente.Id_Ubigeo;
                    objPacienteDC.Edad = DateTime.Now.Year - objPaciente.fechaNacimiento.Year; // Calcula la edad a partir de la fecha de nacimiento.

                    objPacienteDC.departamento = objPaciente.Tb_Ubicacion.Departamento;
                    objPacienteDC.provincia = objPaciente.Tb_Ubicacion.Provincia;
                    objPacienteDC.distrito = objPaciente.Tb_Ubicacion.Distrito;
                    objPacienteDC.EmailPaciente = objPaciente.emailPaciente;
                    objPacienteDC.TelPaciente = objPaciente.numTelefono;
                    objPacienteDC.Tipo_Cliente = Convert.ToInt16(objPaciente.tipoCliente);

                    if (objPaciente.tipoCliente == 1)
                    {
                        objPacienteDC.Tipo = "Gerente";
                    }
                    else if (objPaciente.tipoCliente == 2)
                    {
                        objPacienteDC.Tipo = "Administrativo";
                    }
                    else if (objPaciente.tipoCliente == 3)
                    {
                        objPacienteDC.Tipo = "Operacional";
                    }
                    else
                    {
                        objPacienteDC.Tipo = "Desconocido";
                    }
                    objPacienteDC.LugarTrabajo = objPaciente.Tb_Empresa.Raz_soc_emp;
                    objPacienteDC.FecIngreso = Convert.ToDateTime(objPaciente.fechaIngreso);
                    objPacienteDC.FecRegistro= Convert.ToDateTime(objPaciente.Fec_reg);
                    objPacienteDC.UsuRegistro = objPaciente.Usu_Registro;
                    objPacienteDC.FecUltMod = Convert.ToDateTime(objPaciente.Fec_Ult_Mod);
                    objPacienteDC.UsuUltMod = objPaciente.Usu_Ult_Mod;


                    objListaPacienteDC.Add(objPacienteDC);
                }

                return objListaPacienteDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ListarPaciente

        public Boolean usp_InsertarPaciente(PacienteDC objPacienteDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_InsertarEstadoPaciente(
                    objPacienteDC.NomPaciente,
                    objPacienteDC.ApePaciente,
                    objPacienteDC.FecNacPaciente,
                    objPacienteDC.DniPaciente,
                    Convert.ToInt16(objPacienteDC.Sexo_Paciente),
                    objPacienteDC.DirecPaciente,
                    Convert.ToString(objPacienteDC.Tipo_Sangre),
                    objPacienteDC.EmailPaciente,
                    objPacienteDC.FecIngreso,
                    objPacienteDC.TelPaciente,
                    objPacienteDC.Est_Paciente,
                    objPacienteDC.Tipo_Cliente,
                    objPacienteDC.CodEmpresa,
                    objPacienteDC.UsuRegistro,
                    objPacienteDC.IdUbigeo);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//InsertarPaciente

        public Boolean usp_ActualizarPaciente(PacienteDC objPacienteDC)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_ActualizarEstadoPaciente(
                    objPacienteDC.CodPaciente,
                    objPacienteDC.NomPaciente,
                    objPacienteDC.ApePaciente,
                    objPacienteDC.FecNacPaciente,
                    objPacienteDC.DniPaciente,
                    Convert.ToInt16(objPacienteDC.Sexo_Paciente),
                    objPacienteDC.DirecPaciente,
                    Convert.ToString(objPacienteDC.Tipo_Sangre),
                    objPacienteDC.EmailPaciente,
                    objPacienteDC.FecIngreso,
                    objPacienteDC.TelPaciente,
                    objPacienteDC.Est_Paciente,
                    objPacienteDC.Tipo_Cliente,
                    objPacienteDC.CodEmpresa,
                    objPacienteDC.UsuUltMod,
                    objPacienteDC.IdUbigeo);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ActualizarPaciente

        public Boolean usp_EliminarPaciente(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                //Ejecutamos el procedimiento almacenado de la base de datos
                MiDB.usp_EliminarPaciente(strCodigo);

                MiDB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }//EliminarPaciente

        public PacienteDC usp_ConsultarPaciente(String strCodigo)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (un objeto PacienteDC)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                PacienteDC objPacienteDC = new PacienteDC();

                Tb_Paciente objPaciente = (
                    from miPaciente in MiDB.Tb_Paciente
                    where miPaciente.codPaciente == strCodigo
                    select miPaciente).FirstOrDefault();

                if(objPaciente == null)
                {
                    objPacienteDC.CodPaciente = String.Empty;
                }
                else
                {
                    objPacienteDC.CodPaciente = objPaciente.codPaciente;
                    objPacienteDC.NomPaciente = objPaciente.nomPaciente;
                    objPacienteDC.ApePaciente = objPaciente.apePaciente;
                    objPacienteDC.ApeNomPaciente = objPaciente.apePaciente + ", " + objPaciente.nomPaciente;
                    objPacienteDC.FecNacPaciente = objPaciente.fechaNacimiento;
                    objPacienteDC.CodEmpresa = objPaciente.codEmpresa;
                    objPacienteDC.Est_Paciente = Convert.ToInt16(objPaciente.estado);

                    if (objPaciente.estado == 1)
                    {
                        objPacienteDC.Estado = "Activo";
                    }
                    else
                    {
                        objPacienteDC.Estado = "Inactivo";
                    }
                    objPacienteDC.DniPaciente = objPaciente.dniPaciente;
                    objPacienteDC.Sexo_Paciente = Convert.ToInt16(objPaciente.sexo);
                    if (objPaciente.sexo == 0)
                    {
                        objPacienteDC.Sexo = "Masculino";
                    }
                    else
                    {
                        objPacienteDC.Sexo = "femenino";
                    }
                    objPacienteDC.DirecPaciente = objPaciente.direcPaciente;
                    objPacienteDC.Tipo_Sangre = Convert.ToInt16(objPaciente.tipoSangre);

                    // Lógica con if para el tipo de sangre
                    if (objPaciente.tipoSangre == "0")
                    {
                        objPacienteDC.TipoSangre = "A+";
                    }
                    else if (objPaciente.tipoSangre == "1")
                    {
                        objPacienteDC.TipoSangre = "B+";
                    }
                    else if (objPaciente.tipoSangre == "2")
                    {
                        objPacienteDC.TipoSangre = "AB+";
                    }
                    else if (objPaciente.tipoSangre == "3")
                    {
                        objPacienteDC.TipoSangre = "O+";
                    }
                    else if (objPaciente.tipoSangre == "4")
                    {
                        objPacienteDC.TipoSangre = "A-";
                    }
                    else if (objPaciente.tipoSangre == "5")
                    {
                        objPacienteDC.TipoSangre = "B-";
                    }
                    else if (objPaciente.tipoSangre == "6")
                    {
                        objPacienteDC.TipoSangre = "AB-";
                    }
                    else if (objPaciente.tipoSangre == "7")
                    {
                        objPacienteDC.TipoSangre = "O-";
                    }
                    else
                    {
                        objPacienteDC.TipoSangre = "Desconocido";
                    }
                    objPacienteDC.IdUbigeo = objPaciente.Id_Ubigeo;
                    objPacienteDC.departamento = objPaciente.Tb_Ubicacion.Departamento;
                    objPacienteDC.provincia = objPaciente.Tb_Ubicacion.Provincia;
                    objPacienteDC.distrito = objPaciente.Tb_Ubicacion.Distrito;
                    objPacienteDC.Edad = DateTime.Now.Year - objPaciente.fechaNacimiento.Year; // Calcula la edad a partir de la fecha de nacimiento.
                    objPacienteDC.EmailPaciente = objPaciente.emailPaciente;
                    objPacienteDC.TelPaciente = objPaciente.numTelefono;
                    objPacienteDC.Tipo_Cliente = Convert.ToInt16(objPaciente.tipoCliente);

                    if (objPaciente.tipoCliente == 1)
                    {
                        objPacienteDC.Tipo = "Gerente";
                    }
                    else if (objPaciente.tipoCliente == 2)
                    {
                        objPacienteDC.Tipo = "Administrativo";
                    }
                    else if (objPaciente.tipoCliente == 3)
                    {
                        objPacienteDC.Tipo = "Operacional";
                    }
                    else
                    {
                        objPacienteDC.Tipo = "Desconocido";
                    }
                    objPacienteDC.LugarTrabajo = objPaciente.Tb_Empresa.Raz_soc_emp;
                    objPacienteDC.FecIngreso = Convert.ToDateTime(objPaciente.fechaIngreso);
                    objPacienteDC.FecRegistro = Convert.ToDateTime(objPaciente.Fec_reg);
                    objPacienteDC.UsuRegistro = objPaciente.Usu_Registro;
                    objPacienteDC.FecUltMod = Convert.ToDateTime(objPaciente.Fec_Ult_Mod);
                    objPacienteDC.UsuUltMod= objPaciente.Usu_Ult_Mod;
                }

                return objPacienteDC;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }//ConsultarPaciente
    }//class
}
