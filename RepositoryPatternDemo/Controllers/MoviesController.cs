using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Domain.Data.EFCore;
using RepositoryPatternDemo.Domain.Models;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
