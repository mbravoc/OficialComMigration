//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oficial3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int id_Cliente { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Nullable<int> Idade { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public int usuario { get; set; }
    
        public virtual Usuario Usuario1 { get; set; }
    }
}
