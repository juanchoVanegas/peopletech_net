//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Periodico1
{
    using System;
    using System.Collections.Generic;
    
    public partial class NOTICIA
    {
        public int ID_NOTICIA { get; set; }
        public string TITULO { get; set; }
        public string FOTO { get; set; }
        public string CONTENIDO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public int ID_TEMA { get; set; }
        public int ID_AUTOR { get; set; }
    
        public virtual AUTOR AUTOR { get; set; }
        public virtual TEMA TEMA { get; set; }
    }
}