using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace RockMuseumApp.Pages.Lydguider
{
    public class IndexModel : PageModel
    {
        private readonly MuseumContext _context;

        public IndexModel(MuseumContext context)
        {
            _context = context;
        }

        public IList<Lydguide>? Lydguider { get; set; }

        public void OnGet()
        {
            Lydguider = _context.Lydguides?.ToList() ?? new List<Lydguide>();
        }
    }
}
