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
    public class LiWoModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public LiWoModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public IList<TypeOfJob> TypeOfJob { get; set; }
        public IList<Material> Material { get; set; }
        public async Task OnGetAsync()
        {
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Material = await _context.Material.ToListAsync();
        }
    }
}
