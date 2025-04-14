using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAnalisis" en el código y en el archivo de configuración a la vez.
    public class ServicioAnalisis : IServicioAnalisis
    {
        public AnalisisDC ConsultarAnalisis(String codAnalisis)
        {
            BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
            try
            {
                Tb_Analisis objAnalisis = (from objAnalis in MiDB.Tb_Analisis
                                           where objAnalis.codAnalisis == codAnalisis
                                           select objAnalis).FirstOrDefault();

                AnalisisDC objAnalisisDC = new AnalisisDC();
                if (objAnalisis == null)
                {
                    objAnalisisDC.codAnalisis = "";
                }
                else
                {
                    objAnalisisDC.codAnalisis = objAnalisis.codAnalisis;
                    objAnalisisDC.descAnalisis = objAnalisis.descAnalisis;
                    objAnalisisDC.costo = Convert.ToSingle(objAnalisis.costo);
                    objAnalisisDC.estAnalisis = Convert.ToInt16(objAnalisis.estado);
                    if (objAnalisis.estado == 1)
                    {
                        objAnalisisDC.estado = "Activo";
                    }
                    else
                    {
                        objAnalisisDC.estado = "Inactivo";
                    }
                    objAnalisisDC.Fec_reg = Convert.ToDateTime(objAnalisis.Fec_reg);
                    objAnalisisDC.Usu_Registro = objAnalisis.Usu_Registro;
                    objAnalisisDC.Fec_Ult_Mod = Convert.ToDateTime(objAnalisis.Fec_Ult_Mod);
                    objAnalisisDC.Usu_Ult_Mod = objAnalisis.Usu_Ult_Mod;
                }
                return objAnalisisDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AnalisisDC> ListarAnalisis()
        {

            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                List<AnalisisDC> objLista = new List<AnalisisDC>();

                var query = MiDB.Tb_Analisis.OrderBy(miAnalisis => miAnalisis.codAnalisis).ToList();

                foreach (var resultado in query)
                {
                    AnalisisDC objAnalisisDC = new AnalisisDC();
                    objAnalisisDC.codAnalisis = resultado.codAnalisis;
                    objAnalisisDC.descAnalisis = resultado.descAnalisis;
                    objAnalisisDC.costo = Convert.ToSingle(resultado.costo);
                    objAnalisisDC.estAnalisis = Convert.ToInt16(resultado.estado);
                    if (resultado.estado == 1)
                    {
                        objAnalisisDC.estado = "Activo";
                    }
                    else
                    {
                        objAnalisisDC.estado = "Inactivo";
                    }
                    objAnalisisDC.Fec_reg = Convert.ToDateTime(resultado.Fec_reg);
                    objAnalisisDC.Usu_Registro = resultado.Usu_Registro;
                    objAnalisisDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod);
                    objAnalisisDC.Usu_Ult_Mod = resultado.Usu_Ult_Mod;
                    objLista.Add(objAnalisisDC);
                }
                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public Boolean InsertarAnalisis(AnalisisDC objAnalisisDC)
        { 
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_InsertarAnalisis(
                    objAnalisisDC.descAnalisis,
                    Convert.ToDecimal(objAnalisisDC.costo),
                    Convert.ToInt16(objAnalisisDC.estAnalisis),
                    objAnalisisDC.Usu_Registro);

                MiDB.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean ActualizarAnalisis(AnalisisDC objAnalisisDC)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_ActualizarAnalisis(
                    objAnalisisDC.codAnalisis,
                    objAnalisisDC.descAnalisis,
                    Convert.ToDecimal(objAnalisisDC.costo),
                    Convert.ToInt16(objAnalisisDC.estAnalisis),
                    objAnalisisDC.Usu_Ult_Mod);

                MiDB.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean EliminarAnalisis(String codAnalisis)
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();

                MiDB.usp_EliminarAnalisis(codAnalisis);

                MiDB.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public AnalisisDC ConsultarUltimoAnalisis()
        {
            try
            {
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                var resultado = MiDB.usp_ListarUltAnalisis().FirstOrDefault();

                if (resultado == null)
                {
                    return null;
                }

                AnalisisDC objAnalisisDC = new AnalisisDC
                {
                    codAnalisis = resultado.codAnalisis,
                    descAnalisis = resultado.descAnalisis,
                    costo = Convert.ToSingle(resultado.costo),
                    estAnalisis = Convert.ToInt16(resultado.estado),
                    estado = resultado.estado == 1 ? "Activo" : "Inactivo",
                    Fec_reg = Convert.ToDateTime(resultado.Fec_reg),
                    Usu_Registro = resultado.Usu_Registro,
                    Fec_Ult_Mod = Convert.ToDateTime(resultado.Fec_Ult_Mod),
                    Usu_Ult_Mod = resultado.Usu_Ult_Mod
                };

                return objAnalisisDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
