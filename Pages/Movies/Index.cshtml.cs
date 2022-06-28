using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EazyMoviesDatabase.Data;
using EazyMoviesDatabase.Models;

namespace EazyMoviesDatabase.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly EazyMoviesDatabase.Data.EazyMoviesContext _context;

        public IndexModel(EazyMoviesDatabase.Data.EazyMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
