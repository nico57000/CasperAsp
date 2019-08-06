using CasperAsp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CasperAsp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        [HttpPost]
        public ActionResult Connect_Click(Users U)
        {
            MySqlConnection MyServerSql = new MySqlConnection("server=137.74.118.171;user id=sta33;password=cu267a;persistsecurityinfo=True;database=sta33;allowuservariables=True");
            MyServerSql.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE Identifiant = '" + U.UserName + "' AND Password = '" + U.UserPassword + "'", MyServerSql);

            MySqlDataReader reader = cmd.ExecuteReader();



            if (reader.HasRows)
            {
                reader.Close();
                return RedirectToAction("Index","Projet");
            }
            else
            {
                reader.Close();
                return View("About");
            }
        }
    }
}