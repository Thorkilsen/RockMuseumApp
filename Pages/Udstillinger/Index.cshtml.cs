using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace RockMuseumApp.Pages.Udstillinger
{
    public class IndexModel : PageModel
    {
        private readonly MuseumContext _context;

        public IndexModel(MuseumContext context)
        {
            _context = context;
        }

        public IList<Udstilling> Udstillinger { get; set; } = new List<Udstilling>();

        public void OnGet()
        {
            Udstillinger = _context.Udstillinger.ToList();
        }
    }
}




