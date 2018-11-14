using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core.Domain
{
   public class CATEGORIEDTO
    {
      
        public CATEGORIEDTO()
        {
            this.ARTICLES = new HashSet<ARTICLEDTO>();
        }

        public string categorienom { get; set; }
        public Nullable<System.DateTime> datecreation { get; set; }

     
        public virtual ICollection<ARTICLEDTO> ARTICLES { get; set; }
    
}
}
