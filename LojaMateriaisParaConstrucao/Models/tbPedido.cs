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
    
    public partial class tbPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPedido()
        {
            this.tbItem_Pedido = new HashSet<tbItem_Pedido>();
        }
    
        public int CodigoPedido { get; set; }
        public Nullable<int> CodigoCliente { get; set; }
        public Nullable<int> CodigoFuncionario { get; set; }
        public Nullable<System.DateTime> DataPedido { get; set; }
        public Nullable<System.DateTime> DataEntrega { get; set; }
        public Nullable<decimal> ValorTotalPedido { get; set; }
        public Nullable<int> CodigoDestinatario { get; set; }
        public Nullable<int> CodigoPgto_Pedido { get; set; }
        public Nullable<bool> StatusPedido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbItem_Pedido> tbItem_Pedido { get; set; }
    }
}
