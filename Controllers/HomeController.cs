using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UC8At3_Marília.Models;

namespace UC8At3_Marília.Controllers
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
            return View();
        }

        public IActionResult Novidades()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Produtos(Carrinho novoProduto)
        {
            InfoCarrinho.Incluir(novoProduto);
            return View();
        }

        /////////////////////////////////////////////

                //Cadastro
        public IActionResult Contato()  //era Cadastro()
        {
            return View();
        }


        //Cadastro - banco de dados
        [HttpPost]
        public IActionResult Contato(Contato userForm)   //Usuario
        {
            ContatoRepository ur = new ContatoRepository(); // UsuarioRepository ur = new UsuarioRepository();
            ur.inserir(userForm);
            ViewBag.Mensagem = "Cadastro realizado com sucesso";
            return View();
        }


        /*
        public IActionResult Contato()
        {
            return View();
        }
        */
        //////////////////////////////////////////////////

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Favoritos()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            List<Carrinho> listaCarrinho = InfoCarrinho.Listar();
            return View(listaCarrinho);
        }


        /*

        public IActionResult Carrinho()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Carrinho(Carrinho novoCarrinho)
        {
            InfoCarrinho.Incluir(novoCarrinho);
            return View();
        }  
        */




        
        /*[Route("/Home/Carrinho", Name = "Carrinho")]
        
    public string Test()
    {
        return "This is the test page";
    }  */









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
