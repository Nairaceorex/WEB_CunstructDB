using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CunstructDB.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public IndexModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
        }
    }
}
