using Avam.DigiCura.Domain;
using System.Data.Entity;

namespace Avam.DigiCura.Data
{
    internal class DigiCuraDbContext : DbContext
    {
        #region ctors
        public DigiCuraDbContext()
        {

        }
        #endregion

        #region Overrides
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region DBSets
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion
    }
}
