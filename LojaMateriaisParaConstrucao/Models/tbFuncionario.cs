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
    
    public partial class tbFuncionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbFuncionario()
        {
            this.tbOrcamentoes = new HashSet<tbOrcamento>();
            this.tbVendas = new HashSet<tbVenda>();
        }
    
        public int CodigoFuncionario { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public Nullable<int> CodigoCargo { get; set; }
        public Nullable<System.DateTime> DataAdmissao { get; set; }
        public Nullable<bool> StatusFuncionario { get; set; }
    
        public virtual tbCargo tbCargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrcamento> tbOrcamentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbVenda> tbVendas { get; set; }
    }
}
