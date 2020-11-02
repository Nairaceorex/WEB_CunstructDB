using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.Materials
{
    public class DeleteModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public DeleteModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Material Material { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Material = await _context.Material.FirstOrDefaultAsync(m => m.ID == id);

            if (Material == null)
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

            Material = await _context.Material.FindAsync(id);

            if (Material != null)
            {
                _context.Material.Remove(Material);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
