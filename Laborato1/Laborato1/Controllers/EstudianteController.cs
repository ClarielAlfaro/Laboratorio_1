using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laborato1.Models;

namespace Laborato1.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Estudiante()
        {
            using(estudianteEntities bd = new estudianteEntities())
            {

                var ListadoEstudiantes = bd.TblNotasEstudiante.ToList();

                return View(ListadoEstudiantes);
            }
            
        }
    }
}