using Avam.DigiCura.Domain;

namespace Avam.DigiCura.Data.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        #region ctors
        protected CategoryRepository() : base(new DigiCuraDbContext())
        {
        }
        #endregion
    }
}
