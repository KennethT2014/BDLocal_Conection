//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDLocal_Conection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
    
        public virtual Categoria Categoria1 { get; set; }
        public virtual Categoria Categoria2 { get; set; }
    }
}
