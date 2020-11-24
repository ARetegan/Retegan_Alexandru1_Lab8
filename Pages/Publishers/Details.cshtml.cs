using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Retegan_Alexandru1_Lab8.Data;
using Retegan_Alexandru1_Lab8.Models;

namespace Retegan_Alexandru1_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Retegan_Alexandru1_Lab8.Data.Retegan_Alexandru1_Lab8Context _context;

        public DetailsModel(Retegan_Alexandru1_Lab8.Data.Retegan_Alexandru1_Lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
