using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NET5.Models;
using NET5.Models.Entities;

namespace NET5.Pages.Functions
{
    public class EditModel : PageModel
    {
        private readonly NET5.Models.AppDbContext _context;

        public EditModel(NET5.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Function Function { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Function = await _context.Functions.FirstOrDefaultAsync(m => m.Id == id);

            if (Function == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Function).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FunctionExists(Function.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FunctionExists(long id)
        {
            return _context.Functions.Any(e => e.Id == id);
        }
    }
}
