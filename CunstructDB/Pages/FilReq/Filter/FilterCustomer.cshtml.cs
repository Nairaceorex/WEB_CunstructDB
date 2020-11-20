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
    public class FilterCustomerModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;
        public FilterCustomerModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public Customer Customer { get; set; }
        public IList<Order> Order { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.CustomerID == Customer.ID).ToListAsync();
            return Page();
        }
    }
}
