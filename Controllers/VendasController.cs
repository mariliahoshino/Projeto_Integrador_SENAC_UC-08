       // using System;
using UC8At3_Marília.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace UC8At3_Marília.Controllers
{
    public class VendasController : Controller //lembrar sempre : Controller    09/06 35min
    {






        //Lista
        public IActionResult Vendas(){
            /*
            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }
            */

            VendasRepository ur = new VendasRepository();
            List<Vendas> Listagem = ur.listar();
            return View(Listagem);

        }



        //Remover
        public IActionResult Remover(int Id)
        {
            /*
            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }
            */

            VendasRepository ur = new VendasRepository();
            Vendas user = ur.buscarPorId(Id);
            ur.remover(user);

            return RedirectToAction("ListaPT");

        }



        //Editar
        public IActionResult EditarPT(int Id)
        {
            /*
            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }
            */
            
            VendasRepository ur = new VendasRepository();
            Vendas user = ur.buscarPorId(Id);
            return View(user);
        }


        //Editar - banco de dados
        [HttpPost]
        public IActionResult EditarPT(Vendas userForm)
        {
            VendasRepository ur = new VendasRepository();
            ur.atualizar(userForm);
            //ViewBag.Mensagem = "Atualização realizado com sucesso";
            return RedirectToAction("ListaPT");  
        }


        //Cadastro
        public IActionResult CadastroPT()
        {
            return View();
        }


        //Cadastro - banco de dados
        [HttpPost]
        public IActionResult CadastroPT(Vendas userForm)
        {
            VendasRepository ur = new VendasRepository();
            ur.inserir(userForm);
            ViewBag.Mensagem = "Cadastro realizado com sucesso";
            return View();
        }

        
























    }
}