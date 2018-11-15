using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseCnX.PersistanceData;

namespace DatabaseCnX.PersistanceData.RepositoryData
{
   public class ConnexionRepositories
    {
        private static readonly UnityOfWork uofw= new UnityOfWork();
       

        public static UnityOfWork GetConnexionRepositories()
        {
            return uofw;
        }
    }
}
