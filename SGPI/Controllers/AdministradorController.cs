using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;

namespace SGPI.Controllers
{
    public class AdministradorController : Controller
    {

        SGPIDBContext context = new SGPIDBContext();

        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            var usuario = context.Usuarios
               .Where(consulta => consulta.NumeroDocumento == user.NumeroDocumento
               && consulta.Password == user.Password).FirstOrDefault();

            if (usuario != null)
            {
                if (usuario.IdRol == 1)
                {
                    return Redirect("Administrador/BuscarUsuario");
                }
                else if (usuario.IdRol == 2)
                {
                    return Redirect("Coordinador/BuscarEstudiante");
                }
                else if (usuario.IdRol == 3)
                {
                    return Redirect("Estudiante/ActualizarEstudiante");
                }
                else
                {

                }
            }
            else { }
            return View();
        }
            public IActionResult Login()
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
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.programa = context.Programas.ToList();
            
            return View();
        }
        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.programa = context.Programas.ToList();
            return View();

        }
        public IActionResult BuscarUsuario()
        {
            ViewBag.documento = context.Documentos.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult BuscarUsuario(Usuario usuario)
        {
            var us = context.Usuarios
                            .Where(u => u.NumeroDocumento == usuario.NumeroDocumento
                            && u.IdDoc == usuario.IdDoc).FirstOrDefault();

            if (us != null)
            {

                ViewBag.documento = context.Documentos.ToList();

                return View(us);
            }
            else
            {
                ViewBag.documento = context.Documentos.ToList();
                return View();
            }
        }
        public IActionResult MenuAdmModificar(int? IdUsuario)
        {
            Usuario usuario = context.Usuarios.Find(IdUsuario);
            if (usuario != null)
            {
                return View(usuario);
            }
            else
                return Redirect("Administrador/BuscarUsuario");
        }
        [HttpPost]
        public IActionResult MenuAdmModificar(Usuario user)
        {
            context.Update(user);
            context.SaveChanges();
            return Redirect("Administrador/BuscarUsuario");
        }
        public IActionResult Delete(Usuario usuario)
        {
            context.Remove(usuario);
            context.SaveChanges();
            return Redirect("BuscarUsuario");
        }
        public IActionResult ReportesAdmin()
        {
            return View();
        }
    }
}
