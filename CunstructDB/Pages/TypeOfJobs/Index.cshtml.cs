using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.TypeOfJobs
{
    public class IndexModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public IndexModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        public IList<TypeOfJob> TypeOfJob { get;set; }
        public IList<Material> Material { get; set; }

        public async Task OnGetAsync()
        {
            TypeOfJob = await _context.TypeOfJob.ToListAsync();
            Material = await _context.Material.ToListAsync();
        }
    }
}
