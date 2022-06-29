using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EazyMoviesDatabase.Models
{
    public class Movie
        {
            public int ID { get; set; }
            public string Title { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Release Date")]
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; } 

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            public decimal Price { get; set; }
            public string Rating { get; set; }



        }
    
    
}
