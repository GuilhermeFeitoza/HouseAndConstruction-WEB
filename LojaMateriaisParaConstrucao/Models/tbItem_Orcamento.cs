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
    
    public partial class tbItem_Orcamento
    {
        public int CodigoItem_Orcamento { get; set; }
        public Nullable<int> CodigoOrcamento { get; set; }
        public Nullable<int> CodigoProduto { get; set; }
    
        public virtual tbOrcamento tbOrcamento { get; set; }
        public virtual tbProduto tbProduto { get; set; }
    }
}
