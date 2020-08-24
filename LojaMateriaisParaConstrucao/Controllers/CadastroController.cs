using LojaMateriaisParaConstrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaMateriaisParaConstrucao.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult CadastrarCliente(Models.tbCliente cli)
        {

            if (ModelState.IsValid)
            {

                using (LMPCEntities1 db = new LMPCEntities1())
                {

                    db.tbClientes.Add(cli);
                    db.SaveChanges();
                    ModelState.Clear();
                    cli = null;
                    ViewBag.Mensagem = "Cliente registrado com sucesso";

                    return RedirectToAction("MensagemCupom", "Home");

                }
            }
            else
            {
                return View();
            }




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