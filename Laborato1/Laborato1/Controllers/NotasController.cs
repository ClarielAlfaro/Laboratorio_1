using System;
using Laborato1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Laborato1.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {       
            return View();
        }      

        public ActionResult Resultado(String nombre, String Lab1, String Lab2, String Lab3, String par1, String par2, String par3)
        {

            using (estudianteEntities bd = new estudianteEntities())
            {
                TblNotasEstudiante ca = new TblNotasEstudiante();
                ca.nombre = nombre;
                ca.lab1 = float.Parse(Lab1);
                ca.lab2 = float.Parse(Lab2);
                ca.lab3 = float.Parse(Lab3);
                ca.par1 = float.Parse(par1);
                ca.par2 = float.Parse(par2);
                ca.par3 = float.Parse(par3);
                bd.TblNotasEstudiante.Add(ca);
                bd.SaveChanges();

            }

            ViewBag.nombre = nombre;
            ViewBag.Lab1 = Lab1;
            ViewBag.Lab2 = Lab2;
            ViewBag.Lab3 = Lab3;
            ViewBag.par1 = par1;
            ViewBag.par2 = par2;
            ViewBag.par3 = par3;

            double prom1 = ((Double.Parse(Lab1) * 0.4) * 0.33) + ((Double.Parse(par1) * 0.6) * 0.33);
            double prom2 = ((Double.Parse(Lab2) * 0.4) * 0.33) + ((Double.Parse(par2) * 0.6) * 0.33);
            double prom3 = ((Double.Parse(Lab3) * 0.4) * 0.34) + ((Double.Parse(par3) * 0.6) * 0.34);
            double totalpromedio = prom1 + prom2 + prom3;


            ViewBag.total = totalpromedio;


            return View();
        }

      
    }
}