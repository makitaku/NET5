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
    public class IndexModel : PageModel
    {
        private readonly NET5.Models.AppDbContext _context;

        public IndexModel(NET5.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Function> Function { get;set; }

        public async Task OnGetAsync()
        {
            Function = await _context.Functions.ToListAsync();
        }
    }
}
