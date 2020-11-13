using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CunstructDB.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;
        public FilterPositionModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public Position Position { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == id);

            if (Position == null)
            {
               return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.PositionID == Position.ID).ToListAsync();
            return Page();
        }
    }
}
