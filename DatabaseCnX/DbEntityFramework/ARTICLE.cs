//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseCnX.DbEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTICLE
    {
        public int idarticle { get; set; }
        public Nullable<double> prix { get; set; }
        public int quantite { get; set; }
        public string img { get; set; }
        public string categorienom { get; set; }
        public Nullable<System.DateTime> datecreation { get; set; }
        public string marque { get; set; }
        public string model { get; set; }
    
        public virtual CATEGORIE CATEGORIE { get; set; }
    }
}
