using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core.Domain
{
   public class QUESTIONSECRETDTO
    {
        
        public QUESTIONSECRETDTO()
        {
            this.USERS = new HashSet<USERDTO>();
        }

        public int idquestion { get; set; }
        public string question { get; set; }

        
        public virtual ICollection<USERDTO> USERS { get; set; }
    }
}
