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
    
    public partial class sp_exibircomentarioproduto_Result
    {
        public int CodigoComentario { get; set; }
        public Nullable<int> CodigoCliente { get; set; }
        public Nullable<int> CodigoProduto { get; set; }
        public Nullable<int> Avaliacao { get; set; }
        public string TituloComentario { get; set; }
        public string Comentario { get; set; }
        public Nullable<System.DateTime> DataComentario { get; set; }
        public Nullable<int> StatusComentario { get; set; }
    }
}