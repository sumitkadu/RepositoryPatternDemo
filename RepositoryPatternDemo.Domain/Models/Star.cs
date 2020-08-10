using System;
using System.ComponentModel.DataAnnotations;
using RepositoryPatternDemo.Domain.Data;

namespace RepositoryPatternDemo.Domain.Models
{
    public class Star : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Surname { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Nationality { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public bool WonNationalAward { get; set; }
    }
}
