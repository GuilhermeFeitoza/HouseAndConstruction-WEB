//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaMateriaisParaConstrucao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEstoque
    {
        public int CodigoEstoque { get; set; }
        public Nullable<int> CodigoProduto { get; set; }
        public Nullable<int> QuantidadeAtual { get; set; }
    
        public virtual tbProduto tbProduto { get; set; }
    }
}
