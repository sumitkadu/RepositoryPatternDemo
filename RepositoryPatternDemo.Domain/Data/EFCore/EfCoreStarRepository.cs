using RepositoryPatternDemo.Domain.Models;
using RepositoryPatternDemo.Domain.Models.EFCore;

namespace RepositoryPatternDemo.Domain.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyMDBContext>
    {
        public EfCoreStarRepository(MyMDBContext context) : base(context)
        {

        }
    }
}
