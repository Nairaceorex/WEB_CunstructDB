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
    public class IndexModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public IndexModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        public IList<Brigade> Brigade { get;set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Brigade = await _context.Brigade.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
