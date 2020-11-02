using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public IndexModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }
        public IList<Position> Position { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
