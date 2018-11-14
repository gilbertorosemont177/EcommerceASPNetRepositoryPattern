using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core.Domain
{
    public class USERDTO
    {
     
        public USERDTO()
        {
            this.PROFILs = new HashSet<PROFILDTO>();
        }

        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> idquestion { get; set; }
        public string reponsesc { get; set; }

        
        public virtual ICollection<PROFILDTO> PROFILs { get; set; }
        public virtual QUESTIONSECRETDTO QUESTIONSECRET { get; set; }
    }
}
