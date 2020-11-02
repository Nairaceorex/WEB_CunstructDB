using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public IndexModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }
        public IList<Customer> Customer { get; set; }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public IList<Brigade> Brigade { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
            Customer = await _context.Customer.ToListAsync();
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Brigade = await _context.Brigade.ToListAsync();
            Staff = await _context.Staff.ToListAsync();

        }
    }
}
