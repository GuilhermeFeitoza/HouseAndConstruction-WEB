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
    
    public partial class tbFormaPgto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbFormaPgto()
        {
            this.tbPgto_Orcamento = new HashSet<tbPgto_Orcamento>();
            this.tbPgto_Pedido = new HashSet<tbPgto_Pedido>();
        }
    
        public int CodigoFormaPgto { get; set; }
        public string NomeFormaPgto { get; set; }
        public string Descricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPgto_Orcamento> tbPgto_Orcamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPgto_Pedido> tbPgto_Pedido { get; set; }
    }
}
