using Microsoft.AspNetCore.Mvc;

namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {
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
