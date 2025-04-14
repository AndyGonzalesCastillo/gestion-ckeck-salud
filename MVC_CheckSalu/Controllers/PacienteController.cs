using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CheckSalu.AnalisisServiceReference1;

namespace MVC_CheckSalu.Controllers
{
    public class PacienteController : Controller
    {
        ServicioAnalisisClient miAnalisis = new ServicioAnalisisClient();

        // GET: Paciente
        public ActionResult Index(string searchString)
        {
            var listaAnalisis = miAnalisis.ListarAnalisis();
            if (!string.IsNullOrEmpty(searchString))
            {
                listaAnalisis = listaAnalisis.Where(a => a.descAnalisis.Contains(searchString)).ToArray();
            }
            ViewBag.ListarAnalisis = listaAnalisis;
            ViewBag.TotalAnalisis = listaAnalisis.Length; // Calcula el total de análisis
            return View();
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(AnalisisDC obj)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(obj.Usu_Registro) ||
                    obj.costo <= 0 ||
                    string.IsNullOrEmpty(obj.descAnalisis) ||
                    obj.estAnalisis == null)
                {
                    ModelState.AddModelError("", "Todos los campos son obligatorios y el costo debe ser mayor que cero.");
                    return View(obj);
                }

                miAnalisis.InsertarAnalisis(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public ActionResult Actualizar(string id)
        {
            var analisis = miAnalisis.ConsultarAnalisis(id);
            return View(analisis);
        }

        [HttpPost]
        public ActionResult Actualizar(AnalisisDC obj)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(obj.descAnalisis) ||
                    obj.costo <= 0 ||
                    obj.estAnalisis == null ||
                    string.IsNullOrEmpty(obj.Usu_Ult_Mod))
                {
                    ModelState.AddModelError("", "Todos los campos son obligatorios y el costo debe ser mayor que cero.");
                    return View(obj);
                }

                miAnalisis.ActualizarAnalisis(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        public JsonResult Eliminar(string codAnalisis)
        {
            miAnalisis.EliminarAnalisis(codAnalisis);
            return Json(new { success = true });
        }

        public ActionResult Buscar()
        {
            ViewBag.ListarAnalisis = miAnalisis.ListarAnalisis();
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(string codAnalisis)
        {
            ViewBag.ListarAnalisis = new List<AnalisisDC> { miAnalisis.ConsultarAnalisis(codAnalisis) };
            return View();
        }


    }
}
