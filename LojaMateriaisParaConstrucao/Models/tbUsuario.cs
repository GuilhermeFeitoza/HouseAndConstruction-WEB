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
    
    public partial class tbUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUsuario()
        {
            this.tbContatoes = new HashSet<tbContato>();
        }
    
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public Nullable<int> StatusUsuario { get; set; }
        public Nullable<System.DateTime> DataAcessoUsuario { get; set; }
        public Nullable<System.DateTime> DataCadastroUsuario { get; set; }
        public Nullable<int> CodigoNivelAcesso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbContato> tbContatoes { get; set; }
    }
}
