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
    
    public partial class TEMA
    {
        public TEMA()
        {
            this.NOTICIA = new HashSet<NOTICIA>();
        }
    
        public int ID_TEMA { get; set; }
        public string TEMA1 { get; set; }
        public string ICONO { get; set; }
    
        public virtual ICollection<NOTICIA> NOTICIA { get; set; }
    }
}
