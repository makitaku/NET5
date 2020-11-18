using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NET5.Models;
using NET5.Models.Entities;

namespace NET5.Pages.Functions
{
    public class DetailsModel : PageModel
    {
        private readonly NET5.Models.AppDbContext _context;

        public DetailsModel(NET5.Models.AppDbContext context)
        {
            _context = context;
        }

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
    }
}
