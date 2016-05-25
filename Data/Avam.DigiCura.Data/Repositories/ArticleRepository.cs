using Avam.DigiCura.Domain;

namespace Avam.DigiCura.Data.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
    }
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        #region ctors
        protected ArticleRepository() : base(new DigiCuraDbContext())
        {
        }
        #endregion
    }
}
