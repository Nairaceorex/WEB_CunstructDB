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
    public class FilterFinModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;
        public FilterFinModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        
        public IList<Order> Order { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<Brigade> Brigade { get; set; }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public IList<Customer> Customer { get; set; }
        public async Task<IActionResult> OnGetAsync(bool? fin)
        {
            if (fin == null)
            {
                return NotFound();
            }


            Order = await _context.Order.Where(m => m.CompletionMark == fin).ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Brigade = await _context.Brigade.ToListAsync();
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Customer = await _context.Customer.ToListAsync();

            return Page();
        }
    }
}
