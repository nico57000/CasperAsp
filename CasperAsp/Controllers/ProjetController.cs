using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasperAsp.Controllers
{
    public class ProjetController : Controller
    {
        public List<string> ListeDeProjet { get; set; }
        // GET: Projet
        public ActionResult Index()
        {
            MySqlConnection MyServerSql2 = new MySqlConnection("server=137.74.118.171;user id=sta33;password=cu267a;persistsecurityinfo=True;database=sta33;allowuservariables=True");
            MyServerSql2.Open();

            MySqlCommand cmd2 = new MySqlCommand("SELECT Nom FROM Projets", MyServerSql2);

            MySqlDataReader reader2 = cmd2.ExecuteReader();

            int compteur = 0;
            while (reader2.Read())
            {
                TempData["Projets"+compteur] += reader2["Nom"].ToString();
                compteur++;
            }
            reader2.Close();
            return View("SelectProjets");

        }


    }
}