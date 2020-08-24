using LojaMateriaisParaConstrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaMateriaisParaConstrucao.Controllers
{
    public class FaleController : Controller
    {
        // GET: Fale
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FaleConosco()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult CadastrarMensagem(Models.tbContato cont)
        {

            if (ModelState.IsValid)
            {

                using (LMPCEntities1 db = new LMPCEntities1())
                {
                    cont.DataContato = DateTime.Today;
                    cont.StatusContato = 0;
                    db.tbContatoes.Add(cont);
                    db.SaveChanges();
                    ModelState.Clear();
                    cont = null;
                    ViewBag.Mensagem = "Mensagem registrada com sucesso";

                    return RedirectToAction("MensagemFaleConosco", "Home");

                }
            }
            else
            {
                return View();
            }




        }
    }
}