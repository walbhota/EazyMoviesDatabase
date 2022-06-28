using System.ComponentModel.DataAnnotations;
namespace EazyMoviesDatabase.Models
{
    public class Movie
        {
            public int ID { get; set; }
            public string Title { get; set; }

            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; } 

            [DataType(DataType.Currency)]
            public decimal Price { get; set; }



        }
    
    
}
