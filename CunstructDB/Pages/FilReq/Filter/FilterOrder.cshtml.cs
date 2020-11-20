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
    public class FilterOrderModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;
        public FilterOrderModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public TypeOfJob TypeOfJob { get; set; }
        public IList<Order> Order { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob.FirstOrDefaultAsync(m => m.ID == id);

            if (TypeOfJob == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.TypeOfJobID == TypeOfJob.ID).ToListAsync();
            return Page();
        }
    }
}
