using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;

namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {

        SGPIDBContext context = new SGPIDBContext();
        [HttpPost]
      public IActionResult Login(Usuario user){

            var usuario = context.Usuarios
                .Where(consulta => consulta.NumeroDocumento == user.NumeroDocumento
                && consulta.Password == user.Password).FirstOrDefault();

            if (usuario != null)
            {
                //Redirige a la vista principal administrador
                if (usuario.IdRol == 1)
                {
                    return View("BuscarUsuario");
                        }
                //Redirige a la vista principal Coordinador
                else if (usuario.IdRol == 2)
                {
                    return Redirect("Coordinador/BuscarEstudiante");
                }
                //Redirige a la vista principal Estudiante
                else if (usuario.IdRol == 3)
                {
                    return Redirect("Estudiante/ActualizarEstudiante");
                }
                else
                {}


            }

                return View();
            }
      

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
