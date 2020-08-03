using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JuegoRuleta.Models;
using System.Data;
using System.Net;
using Newtonsoft.Json;

namespace JuegoRuleta.Controllers
{
    public class UsuariosController : Controller
    {
        public DBapi DBapli = new DBapi();
        public bool YaExiste = false;
        public Usuario usuario = new Usuario();

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        //public IActionResult Usuarios(Usuario usuario,string name,string email,string password,int credit)
        public IActionResult Usuarios(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
        /*    usuario.Name = name;
            usuario.Email = email;
            usuario.Password = password;
            usuario.Credit = credit;*/
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Clientes");
            ViewBag.clientes = respuesta;
            for (int i = 0; i < ViewBag.clientes.Count; i++)
            {
                if (usuario.Email == ViewBag.clientes[i].email.ToString())
                {
                    YaExiste = true;
                }
            }
            if (!YaExiste) 
            {
                string jsonArchi = JsonConvert.SerializeObject(usuario);
                dynamic respu = DBapli.Post("http://rouletteapi.azurewebsites.net/api/Clientes", jsonArchi);
                ViewBag.ruletas = respu;
                return RedirectToAction("SignIn","Home");
            }
            return View("Index");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
