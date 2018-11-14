using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core.Domain
{
  public  class PROFILDTO
    {
        public int idprofil { get; set; }
        public string username { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string pays { get; set; }

        public virtual USERDTO USER { get; set; }
    }
}
