using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CunstructDB.Pages.FilReq.filter
{
    public class PerDepModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public PerDepModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public IList<Position> Position { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Position = await _context.Position.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
