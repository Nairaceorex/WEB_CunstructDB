using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.Brigades
{
    public class DeleteModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public DeleteModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Brigade Brigade { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigade = await _context.Brigade.FirstOrDefaultAsync(m => m.ID == id);

            if (Brigade == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigade = await _context.Brigade.FindAsync(id);

            if (Brigade != null)
            {
                _context.Brigade.Remove(Brigade);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
