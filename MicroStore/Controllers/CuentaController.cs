using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MicroStore.Models;

namespace MicroStore.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        public ActionResult Index()
        {
            return View();
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }
        //Metodo post que utilizamos apra obtener los datos de las variables y comprobar la validez de las credenciales
        [HttpPost]
        public ActionResult Login(CuentaUsuario user)
        {
            //OurDbContext es la conexion a nuestra base de datos
            using (OurDbContext db = new OurDbContext())
            {
                //La variable usr es donde validamos lo escrito por el usuario con lo establecido en la base de datos
                var usr = db.cuentaUsuario.Where(u => u.Usuario == user.Usuario && u.Contraseña == user.Contraseña).FirstOrDefault();
                //Si en caso exitoso concuerdan las credenciales agregamos cada variable a sus respectivo objeto creando así variables de sesion
                if (usr != null)
                {
                    Session["Id"] = usr.Id.ToString();
                    Session["Usuario"] = usr.Usuario.ToString();
                    //Nos redirege a la vista de LoggedIn
                    return RedirectToAction("LoggedIn");
                }
                //En caso contrario mostrara el mensaje de error creado por nosotros 
                else
                {
                    ModelState.AddModelError("", "Usuario ó Contraseña incorrectos");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            //OurDbContext es la conexion a nuestra base de datos
            OurDbContext db = new OurDbContext();
            //Este validacion es para evitar que usuarios no han iniciado sesion entre al catalogo de productos
            if (Session["Id"] != null)
            {

                return View(db.usuarioCompra.ToList());
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}