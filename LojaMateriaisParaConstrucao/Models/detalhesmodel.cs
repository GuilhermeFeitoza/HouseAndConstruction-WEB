using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaMateriaisParaConstrucao.Models
{
    public class detalhesmodel
    {

       public tbProduto detalheprod{get;set;}
        public IEnumerable<sp_exibircomentarioproduto_Result> listacomentario { get; set; }

        public double? Media { get; set; }




    }
}