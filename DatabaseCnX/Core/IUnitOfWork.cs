using DatabaseCnX.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCnX.Core
{
    public interface IUnitOfWork: IDisposable
    {
         IArticleRepository articles { get; }
        ICategorieRepository categorie { get; }
        IProfilRepository profil { get; }
        IUserReposiroy user { get; }
        IQuestionSecrets questions { get; }
    }
}
