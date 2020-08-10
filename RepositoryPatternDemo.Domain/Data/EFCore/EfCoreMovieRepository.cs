using RepositoryPatternDemo.Domain.Models;
using RepositoryPatternDemo.Domain.Models.EFCore;

namespace RepositoryPatternDemo.Domain.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyMDBContext>
    {
        public EfCoreMovieRepository(MyMDBContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
