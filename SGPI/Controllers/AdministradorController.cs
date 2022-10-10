using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;

namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {
        SGPIDBContext context = new SGPIDBContext();
        public IActionResult Login()
        {

            return View();
        }
        public IActionResult OlvidarContrasena()
        {
            return View();
        }
        public IActionResult CrearUsuario ()
        {
            return View();
        }
        public IActionResult BuscarUsuario()
        {
            return View();
        }
        public IActionResult ReportesAdmin()
        {
            return View();
        }
    }
}
