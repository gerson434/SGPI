using Microsoft.AspNetCore.Mvc;

namespace SGPI.Controllers
{
    public class CoordinadorController : Controller
    {
        public IActionResult BuscarEstudiante()
        {
            return View();
        }
        public IActionResult ProgramarAsignatura()
        {
            return View();
        }

        public IActionResult Homologacion()
        {
            return View();
        }
        public IActionResult EntrevistasAdmisiones()
        {
            return View();

        }
        public IActionResult PagoEstudiante()
        {
            return View();

        }
        public IActionResult Reportes()
        {
            return View();

        }
    }
}