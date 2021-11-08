//using System;
using UC8At3_Marília.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace UC8At3_Marília.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Login(Usuario userForm)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario userSessao = ur.validarLogin(userForm);

            if (userSessao!=null)
            {
                //significa que está logado
                ViewBag.Mensagem = "Você está logado!";

                //carrega na sessão informações do objeto
                HttpContext.Session.SetInt32("IdUsuario", userSessao.Id);
                HttpContext.Session.SetString("NomeUsuario", userSessao.Nome);

                //redirecionar
                return RedirectToAction("Lista");
            }else
            {
                ViewBag.Mensagem = "Falha no login!";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }



        //Lista
        public IActionResult Lista(){
            
            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> Listagem = ur.listar();
            return View(Listagem);

        }


        //Remover
        public IActionResult Remover(int Id)
        {
            

            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }


            UsuarioRepository ur = new UsuarioRepository();
            Usuario user = ur.buscarPorId(Id);
            ur.remover(user);

            return RedirectToAction("Lista");

        }


        //Editar
        public IActionResult Editar(int Id)
        {
            


            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
            return RedirectToAction("Login");
            }
            
            UsuarioRepository ur = new UsuarioRepository();
            Usuario user = ur.buscarPorId(Id);
            return View(user);
        }


        //Editar - banco de dados
        [HttpPost]
        public IActionResult Editar(Usuario userForm)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.atualizar(userForm);
            //ViewBag.Mensagem = "Atualização realizado com sucesso";
            return RedirectToAction("Lista");  
        }





        //Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }


        //Cadastro - banco de dados
        [HttpPost]
        public IActionResult Cadastro(Usuario userForm)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.inserir(userForm);
            ViewBag.Mensagem = "Cadastro realizado com sucesso";
            return View();
        }
        
    }
}