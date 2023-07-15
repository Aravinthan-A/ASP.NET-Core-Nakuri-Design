using Microsoft.AspNetCore.Mvc;
using Nakuri.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace Nakuri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login(ErrorViewModel errorViewModel)
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = DELEVERY; Data Source =.");
            sqlConnection.Open();
            string value = $"INSERT INTO NAKURI(NAMES, MAIL, PASS, PHONE) VALUES ('{errorViewModel.Name}','{errorViewModel.Email}','{errorViewModel.Pass}','{errorViewModel.Phone}')";
            SqlCommand sqlCommand = new SqlCommand(value, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return View("Index");
        }
        public IActionResult Register(ErrorViewModel errorViewModel)
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = DELEVERY; Data Source =.");
            sqlConnection.Open();
            string value = $"INSERT INTO NAKURI(NAMES, MAIL, PASS, PHONE) VALUES ('{errorViewModel.Name}','{errorViewModel.Email}','{errorViewModel.Pass}','{errorViewModel.Phone}')";
            SqlCommand sqlCommand = new SqlCommand(value, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return View("Index");
           
        }
    }
}