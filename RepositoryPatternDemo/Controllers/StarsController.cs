using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Domain.Data.EFCore;
using RepositoryPatternDemo.Domain.Models;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}