using LojaMateriaisParaConstrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
namespace LojaMateriaisParaConstrucao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Models.LMPCEntities1 db = new LMPCEntities1();

            var data = db.produtosrecentes();

            data.AsEnumerable();


            return View(data);
       
        }
        public ActionResult MensagemCupom()
        {
            Models.LMPCEntities1 db = new LMPCEntities1();
            var data = db.sp_cupomadquirido();

            data.AsEnumerable();
            return View(data);
        }




        public ActionResult Loginn()
        {
         
            return View();
        }

       
      
       
        public ActionResult Cadastro()
        {
            return View();
        }

       

        public ActionResult ListaDesejo()
        {
            return View();
        }

        public ActionResult Ferramentas()
        {
            return View();
        }

        public ActionResult AreaExterna()
        {
            return View();
        }

        public ActionResult Portas()
        {
            return View();
        }

        public ActionResult Pisos()
        {
            return View();
        }

        public ActionResult Iluminacao()
        {
            return View();
        }

        public ActionResult Eletrica()
        {
            return View();
        }

        public ActionResult Banheiro()
        {
            return View();
        }

        public ActionResult Cozinha()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Materiais()
        {
            return View();
        }

        public ActionResult Tintas()
        {
            return View();
        }

        public ActionResult QuemSomos()
        {
            return View();
        }

        public ActionResult FaleConosco()
        {
            return View();
        }

        public ActionResult MensagemFaleConosco()
        {
            return View();
        }

        public ActionResult DetProd()
        {
            return View();
        }

        public ActionResult Produtos()
        {

            Models.LMPCEntities1 db = new Models.LMPCEntities1();
            List<Models.tbProduto> listaProd = db.tbProdutoes.OrderByDescending(x => x.CodigoProduto).ToList<Models.tbProduto>();
            return View(listaProd);
        }
              

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult View2()
        {
            return View();
        }
        public ActionResult RetornarPedidos()
        {
            Models.LMPCEntities1 db = new Models.LMPCEntities1();
            List<Models.tbPedido> listaProd = db.tbPedidoes
             .Where(a => a.CodigoCliente == Convert.ToInt32(Session["CodigoCliente"]))
             .OrderByDescending(x => x.CodigoPedido).ToList<Models.tbPedido>();
            return View(listaProd);



        }


        public ActionResult Cupons()
        {
            Models.LMPCEntities1 db = new LMPCEntities1();
            int Codigo = Convert.ToInt32(Session["CodigoCliente"]);
            var data = db.pesq_cupom(Codigo);
               
            data.AsEnumerable();


            return View(data);
        }

        public ActionResult DetalhesProduto(int? id) {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //LMPCEntities1 db = new LMPCEntities1();
            //var prod = db.tbProdutoes.Find(id);
            detalhesmodel model = new detalhesmodel();
            Models.LMPCEntities1 db = new LMPCEntities1();
            ViewBag.id= id;
            //Produtos
            model.detalheprod= db.tbProdutoes.Find(id);
            //Comentarios
            model.listacomentario = db.sp_exibircomentarioproduto(id);
            
            //Media
            model.Media = (from a in db.tbComentarios
                           where a.CodigoProduto==id
                           select a.Avaliacao).Average();




            if (db == null)
            {
                return HttpNotFound();
            }
            return View(model);


        }

        public ActionResult carrinho()
        {


            return View();

        }

        public ActionResult Pagamento()
        {
            return View();
        }
    }
}
