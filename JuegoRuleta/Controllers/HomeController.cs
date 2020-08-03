using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JuegoRuleta.Models;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
//http://rouletteapi.azurewebsites.net/
//http://localhost:5000/api/Clientes
namespace JuegoRuleta.Controllers
{
    public class HomeController : Controller
    {
        [BindProperty]
        public Usuario registro { get; set; }

        public DBapi DBapli = new DBapi();
        public Ruletas ruleta = new Ruletas();
        public bool autenticado = false;
        public String EmaiUser = "";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuPrincipal()
        {
            return View();
        }


        public IActionResult SignIn()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignIn(string EmailUsuario, string PasswordUsuario)
        {
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Clientes");
            ViewBag.ruletas = respuesta;
            for (int i = 0; i < ViewBag.ruletas.Count; i++)
            {
                if (EmailUsuario==ViewBag.ruletas[i].email.ToString() && PasswordUsuario == ViewBag.ruletas[i].password.ToString())
                {
                    Usuario User = new Usuario();
                    User.Credit = Convert.ToInt32(ViewBag.ruletas[i].credit.ToString());
                    User.Email=ViewBag.ruletas[i].email.ToString();
                    User.Name = ViewBag.ruletas[i].name.ToString();
                    //Begin session 
                    HttpContext.Session.SetString("SessionEmail",User.Email);
                    HttpContext.Session.SetString("SessionName", User.Name);
                    HttpContext.Session.SetString("SessionCredit", Convert.ToString(User.Credit)) ;
                    autenticado = true;
                }
            }
                
            if (autenticado)
            {
                return RedirectToAction("MenuPrincipal", "Home");
            }
            else
            {
                return RedirectToAction("index", "Home");
            }
        }

        public IActionResult NewRoulete()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult NewRoulete(Ruletas ruleta,string name,Boolean estado,string entrada1)
        {
            ruleta.name = name;
            ruleta.id = "";
            ruleta.estado=estado;
            string json=JsonConvert.SerializeObject(ruleta);
            dynamic respuesta = DBapli.Post("http://rouletteapi.azurewebsites.net/api/Ruletas", json);
            ViewBag.ruletas = respuesta;
            return RedirectToAction("AllRoulette");
        }

        public IActionResult Bet(string name,string id, string email)
        {
            //dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Ruletas");
            //ViewBag.ruletas = respuesta;
            ViewBag.name = name;
            ViewBag.id = id;
            ViewBag.email = email;
            return View();
        }
        //public List<Apuestas> apuesta = new List<Apuestas>();
        
        public List<Models.Colorul> colorul = new List<Models.Colorul>();
        public List<numerorul> numero = new List<numerorul>();

        [HttpPost]
        public IActionResult Bet(string name, string id, string email, int valorapostado, bool Cr, bool Cn, bool Ch1, bool Ch2, bool Ch3, bool Ch4, bool Ch5, bool Ch6, bool Ch7, bool Ch8, bool Ch9, bool Ch10, bool Ch11, bool Ch12, bool Ch13, bool Ch14, bool Ch15, bool Ch16, bool Ch17, bool Ch18, bool Ch19, bool Ch20, bool Ch21, bool Ch22, bool Ch23, bool Ch24, bool Ch25, bool Ch26, bool Ch27, bool Ch28, bool Ch29, bool Ch30, bool Ch31, bool Ch32, bool Ch33, bool Ch34, bool Ch35, bool Ch36)
        {
            INumeroRuleta prueba = new ArmaListas();
            var numeroslist = prueba.Devolver(Ch1,Ch2,Ch3,Ch4,Ch5,Ch6,Ch7,Ch8,Ch9,Ch10,Ch11,Ch12,Ch13,Ch14,Ch15,Ch16,Ch17,Ch18,Ch19,Ch20,Ch21,Ch22,Ch23,Ch24,Ch25,Ch26,Ch27,Ch28,Ch29,Ch30,Ch31,Ch32,Ch33,Ch34,Ch35,Ch36);
            if (Cn)
            {
            colorul.Add(new Models.Colorul() { indice = 1, name = "Negro" });
            }

            if (Cr)
            {
            colorul.Add(new Models.Colorul() { indice = 2, name = "Rojo" });
            }
            Apuestas apuesta = new Apuestas();
            apuesta.cliente = HttpContext.Session.GetString("SessionEmail");
            apuesta.valorapostado = valorapostado;
            apuesta.ruleta = name;
            apuesta.colores = colorul;
            apuesta.numeros = numeroslist; 

            string Url = "http://rouletteapi.azurewebsites.net/api/Apuestas/";
            string json = JsonConvert.SerializeObject(apuesta);
            dynamic respuesta = DBapli.Post(Url, json);
            ViewBag.ruletas = respuesta;
            return RedirectToAction("MenuPrincipal", "Home");
        }

        public IActionResult AllRoulette()
        {
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Ruletas");
            ViewBag.ruletas = respuesta;
            return View();
        }

        public IActionResult OpenRouletes()
        {
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Ruletas");
            ViewBag.ruletas = respuesta;
            return View();
        }


        [HttpPost]
        public ActionResult OpenRouletes(Ruletas ruleta,Boolean estado,string name,string id)
        {
            
            ruleta.id = id;
            string Url = "http://rouletteapi.azurewebsites.net/api/Ruletas/" + ruleta.id;
            ruleta.name = name;
            ruleta.estado = true;
            string json = JsonConvert.SerializeObject(ruleta);
            dynamic respuesta = DBapli.Put(Url, json);
            ViewBag.ruletas = respuesta;
            return RedirectToAction("AllRoulette");
        }

        public IActionResult CloseRouletes()
        {
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Ruletas");
            ViewBag.ruletas = respuesta;
            return View();
        }


        [HttpPost]
        public ActionResult CloseRouletes(Ruletas ruleta, Boolean estado, string name, string id)
        {
            ruleta.id = id;
            string Url = "http://rouletteapi.azurewebsites.net/api/Ruletas/" + ruleta.id;
            ruleta.name = name;
            ruleta.estado = false;
            string json = JsonConvert.SerializeObject(ruleta);
            dynamic respuesta = DBapli.Put(Url, json);
            ViewBag.ruletas = respuesta;
            return RedirectToAction("AllRoulette");
        }



        public IActionResult ListBets()
        {
            dynamic respuesta = DBapli.Get("http://rouletteapi.azurewebsites.net/api/Apuestas");
            ViewBag.ruletas = respuesta;
            var validar = ViewBag.ruletas[0].cliente.ToString();
            return View();
        }
    }
}
