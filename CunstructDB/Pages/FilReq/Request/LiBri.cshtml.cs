using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CunstructDB.Pages.FilReq.Request
{
    public class LiBriModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public LiBriModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public IList<Brigade> Brigade { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Brigade = await _context.Brigade.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
