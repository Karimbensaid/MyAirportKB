using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KB.MyAirport.EF;

namespace KB.MyAirportRazor.Pages.Bagages
{
    public class CreateModel : PageModel
    {
        private readonly KB.MyAirport.EF.MyAirportContext _context;

        public CreateModel(KB.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bagage Bagage { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bagages.Add(Bagage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
