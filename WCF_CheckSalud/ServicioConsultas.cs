using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WCF_CheckSalud
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConsultas" en el código y en el archivo de configuración a la vez.
    public class ServicioConsultas : IServicioConsultas
    {     

        //Lista de consultas pendientes
        public List<ResultConsultas> sp_VerConsultasPendientes()
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<ResultConsultas> objListResultConsultas = new List<ResultConsultas>();

                //hacemos el query

                var resultado = MiDB.sp_VerConsultasPendientes().ToList();

                //agregamos cada resultado del query a la lista
                foreach (var objConsulta in resultado)
                {
                    ResultConsultas resultConsultasDC = new ResultConsultas();

                    resultConsultasDC.codConsulta = objConsulta.codConsulta;
                    resultConsultasDC.codPaciente = objConsulta.codPaciente;
                    resultConsultasDC.codMedico = objConsulta.codMedico;
                    resultConsultasDC.NomMedico = objConsulta.Medico;
                    resultConsultasDC.NomPaciente = objConsulta.Paciente;
                    resultConsultasDC.motivoConsulta = objConsulta.motivoConsulta;
                    resultConsultasDC.fechConsulta =  Convert.ToDateTime( objConsulta.fechaConsulta);


                    objListResultConsultas.Add(resultConsultasDC);
                }

                //devolvemos la lista
                return objListResultConsultas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Listar todas las consultas registradas a un paciente FILTRO OPCIONAL /PENDIENTE/CANCELADA/REALIZADA 
        public List<ResultConsultas> sp_ListarConsultasPaciente(String strCodigo, String estado)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<ResultConsultas> objListResultConsultas = new List<ResultConsultas>();

                //hacemos el query
               

                // Si el estado es null o vacío, lo pasamos como null
                estado = string.IsNullOrWhiteSpace(estado) ? null : estado;

                // Ejecutamos el procedimiento almacenado y mapeamos los resultados a la lista
               

                var resultado = MiDB.sp_ListarConsultasPaciente(strCodigo, estado).ToList();

                //agregamos cada resultado del query a la lista
                foreach (var objConsulta in resultado)
                {
                    ResultConsultas resultConsultasDC = new ResultConsultas();

                    resultConsultasDC.codConsulta = objConsulta.codConsulta;
                    resultConsultasDC.codPaciente = objConsulta.codPaciente;
                    resultConsultasDC.codMedico = objConsulta.codMedico;
                    resultConsultasDC.NomMedico = objConsulta.NombreMedico;
                    resultConsultasDC.NomPaciente = objConsulta.NombrePaciente;
                    resultConsultasDC.motivoConsulta = objConsulta.motivoConsulta;
                    resultConsultasDC.fechConsulta = Convert.ToDateTime(objConsulta.FechaConsulta);
                    resultConsultasDC.resultadoConsulta = objConsulta.resultados;
                    resultConsultasDC.estadoConsulta = objConsulta.estado;
                    
                   

                    if(objConsulta.resultados != String.Empty)
                    {
                        resultConsultasDC.resultadoConsulta = objConsulta.resultados;
                    }
                    else
                    {
                        resultConsultasDC.resultadoConsulta = "Sin resultados";
                    }

                    resultConsultasDC.estadoConsulta = objConsulta.estado;


                    objListResultConsultas.Add(resultConsultasDC);
                }

                //devolvemos la lista
                return objListResultConsultas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Consultas asiganadas a un medico FiLTRO OPCIONAL cancelada/pendiente/realizada
        public List<ResultConsultas> sp_ConsultasAsignadasMedico(String strCodigo, String estado)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<ResultConsultas> objListResultConsultas = new List<ResultConsultas>();

                //hacemos el query
                estado = string.IsNullOrWhiteSpace(estado) ? null : estado;
                var resultado = MiDB.sp_ConsultasAsignadasMedico(strCodigo, estado).ToList();

                //agregamos cada resultado del query a la lista
                foreach (var objConsulta in resultado)
                {
                    ResultConsultas resultConsultasDC = new ResultConsultas();
                    resultConsultasDC.codConsulta = objConsulta.codConsulta;
                    resultConsultasDC.codMedico = objConsulta.codMedico;
                    resultConsultasDC.codPaciente = objConsulta.codPaciente;
                    resultConsultasDC.NomMedico = objConsulta.NombreMedico;
                    resultConsultasDC.NomPaciente = objConsulta.NombrePaciente;
                    resultConsultasDC.especialidadMedico = objConsulta.Especialidad;
                    resultConsultasDC.estadoConsulta = objConsulta.estado;
                    resultConsultasDC.fechConsulta = Convert.ToDateTime( objConsulta.FechaConsulta);
                    resultConsultasDC.motivoConsulta = objConsulta.motivoConsulta;
                    resultConsultasDC.resultadoConsulta = objConsulta.resultados;


                    objListResultConsultas.Add(resultConsultasDC);
                }

                //devolvemos la lista
                return objListResultConsultas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Total de consultas por especialidad hechas entre dos fechas (si no se ingresa niguna fecha da el total registrado)
        public List<ResultConsultas> sp_ConsultaEspecialidadFechas(DateTime? fecIni, DateTime? fecFin)
        {
            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<ResultConsultas> objListResultConsultas = new List<ResultConsultas>();

                //hacemos el query
                if (fecIni.HasValue && fecIni.Value == DateTime.MinValue)
                {
                    fecIni = null;
                }
                if (fecFin.HasValue && fecFin.Value == DateTime.MinValue)
                {
                    fecFin = null;
                }
              
                var resultado = MiDB.sp_ConsultaEspecialidadFechas(fecIni, fecFin);

                //agregamos cada resultado del query a la lista
                foreach (var objConsulta in resultado)
                {

                    ResultConsultas resultConsultasDC = new ResultConsultas();

                    resultConsultasDC.especialidadMedico = objConsulta.Especialidad;
                    resultConsultasDC.totalConsultas = Convert.ToInt16(objConsulta.TotalConsultas);
                    objListResultConsultas.Add(resultConsultasDC);
                }

                //devolvemos la lista
                return objListResultConsultas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ResultConsultas> sp_GetConsultasByDate(DateTime date)
        {


            try
            {
                //Instanciamos la base de datos y el objeto que se va a devolver (una lista de Empresas)
                BDCheckSaludEntities MiDB = new BDCheckSaludEntities();
                List<ResultConsultas> objListResultConsultas = new List<ResultConsultas>();


                var resultado = MiDB.sp_GetConsultasByDate(date);

                //agregamos cada resultado del query a la lista
                foreach (var objConsulta in resultado)
                {

                    ResultConsultas resultConsultasDC = new ResultConsultas();

                    resultConsultasDC.codConsulta = objConsulta.codConsulta;
                    resultConsultasDC.codPaciente = objConsulta.CodPaciente;
                    resultConsultasDC.codMedico = objConsulta.CodMedico;
                    resultConsultasDC.fechConsulta = Convert.ToDateTime(objConsulta.fechaConsulta);
                    resultConsultasDC.estadoConsulta = objConsulta.Estado;
                    resultConsultasDC.NomPaciente = objConsulta.Paciente;
                    resultConsultasDC.NomMedico = objConsulta.Medico;
                   
                    resultConsultasDC.motivoConsulta = objConsulta.motivoConsulta;
                    objListResultConsultas.Add(resultConsultasDC);
                }

                //devolvemos la lista
                return objListResultConsultas;


            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


























        private static Timer _timer;
        private static readonly object _lock = new object();
        private static bool _isRunning = false;

        public ServicioConsultas()
        {
            // Iniciar el temporizador en el constructor
            if (_timer == null)
            {
                _timer = new Timer(UpdateConsultasPendientes, null, TimeSpan.Zero, TimeSpan.FromHours(1));
            }
        }

        private void UpdateConsultasPendientes(object state)
        {
            // Prevenir que se ejecute más de una vez simultáneamente
            if (_isRunning) return;

            lock (_lock)
            {
                _isRunning = true;
                try
                {
                    using (BDCheckSaludEntities context = new BDCheckSaludEntities())
                    {
                        context.sp_ActualizarConsultasPendientes();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones (puedes agregar logs aquí)
                    Console.WriteLine("Error al actualizar las consultas pendientes: " + ex.Message);
                }
                finally
                {
                    _isRunning = false;
                }
            }
        }
    }
}
