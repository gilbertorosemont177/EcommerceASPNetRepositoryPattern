using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core.Domain
{
   public class ARTICLEDTO
    {

        public int idarticle { get; set; }
        public Nullable<double> prix { get; set; }
        public int quantite { get; set; }
        public string img { get; set; }
        public string categorienom { get; set; }
        public Nullable<System.DateTime> datecreation { get; set; }

        public virtual CATEGORIEDTO CATEGORIE { get; set; }
    }
}
