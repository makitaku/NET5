using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NET5.Models;
using NET5.Models.Entities;

namespace NET5.Pages.Functions
{
    public class CreateModel : PageModel
    {
        private readonly NET5.Models.AppDbContext _context;

        public CreateModel(NET5.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Function Function { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Functions.Add(Function);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
