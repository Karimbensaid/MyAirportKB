using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KB.MyAirport.EF;

namespace KB.MyAirportRazor.Pages.Bagages
{
    public class IndexModel : PageModel
    {
        private readonly KB.MyAirport.EF.MyAirportContext _context;

        public IndexModel(KB.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Bagage> Bagage { get;set; }

        public async Task OnGetAsync()
        {
            Bagage = await _context.Bagages.ToListAsync();
        }
    }
}
