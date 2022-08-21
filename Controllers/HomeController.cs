using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20676736_HW04.Models;

namespace u20676736_HW04.Controllers
{
    public class HomeController : Controller
    {
        //Declare My PregnantPatient
        public static List<PregnantPatient> PregPatientlist = new List<PregnantPatient>();
        //Declare My HIVPatient
        public static List<HIVPatient> HIVPatientlist = new List<HIVPatient>();

        private void InitialisePatient()
        {
            if (Patientlist.Count() == 0)
            {
                PregPatientlist.Add(new PregnantPatient(001277593989, "Lilly", "Johnson", "Female", 25, 0836757410, new DateTime(2012, 1, 25), "3456 Central Ave.", "Is Pregnant", 4, 80.7,90));
                PregPatientlist.Add(new PregnantPatient(001277839389, "Janet", "Johnson", "Female", 25, 0836757410, new DateTime(2012, 1, 25), "3456 Central Ave.", "Is Pregnant", 43, 80.7, 48));



                Patientlist.AddRange(Patientlist);
                Patientlist.AddRange(HIVPatientlist);
            }
            else
            {
                return;
            }
        }
        public static List<Patient> Patientlist = new List<Patient>();

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Locate()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Add_Patient()
        {
            Patient Obj = new Patient();

            return View();
        }
        public ActionResult Patient_Summary()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Order_Vaccine()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Inventory_Summary()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}