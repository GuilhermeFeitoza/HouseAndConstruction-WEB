using LojaMateriaisParaConstrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaMateriaisParaConstrucao.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Loginn()
        {
            return View();
        }
        public ActionResult VerificarLogin(tbCliente log)
        {
            if (ModelState.IsValid)
            {
                using (Models.LMPCEntities1 db = new LMPCEntities1())
                {
                    var v = db.tbClientes.Where(a => a.Cpf.Equals(log.Cpf) && log.Senha.Equals(log.Senha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["CodigoCliente"] = Convert.ToInt32(v.CodigoCliente);
                        Session["NomeCliente"] = Convert.ToString(v.Nome);
                        return RedirectToAction("ClienteLogado", "Login");
                    }
                    else
                    {
                        ViewData["LoginApresenta"] = "Login e/ou senha invalido";
                        return RedirectToAction("Loginn", "Login");
                    }
                }
            }

            return View(log);
        }

        public ActionResult ClienteLogado()
        {
            int Codigo = Convert.ToInt16(Session["CodigoCliente"]);
            Models.LMPCEntities1 db = new Models.LMPCEntities1();
            List<Models.tbPedido> listaProd = db.tbPedidoes
                .Where(a => a.CodigoCliente == Codigo)
                .OrderByDescending(x => x.CodigoPedido)
                .ToList<Models.tbPedido>();
            return View(listaProd);


        }
        public ActionResult Cadastro()
        {
            return View();
        }


        public ActionResult FaleConosco()
        {
            return View();
        }
        public ActionResult QuemSomos()
        {
            return View();


        }
    }
}