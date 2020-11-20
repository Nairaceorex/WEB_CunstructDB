using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Net.Mime.MediaTypeNames;

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
        public List<SelectListItem> SelTypeOfJob { get; set; }
        public List<SelectListItem> SelCustomer { get; set; }
        public List<SelectListItem> SelBrigade { get; set; }
        public List<SelectListItem> SelFin { get; set; }
        public List<SelectListItem> SelPay { get; set; }

        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();

            SelTypeOfJob = _context.TypeOfJob.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();

            SelCustomer = _context.Customer.Select(p =>
                                 new SelectListItem
                                 {
                                     Value = p.ID.ToString(),
                                     Text = p.FullName
                                 }).ToList();

            SelBrigade = _context.Brigade.Select(p =>
                                 new SelectListItem
                                 {
                                     Value = p.ID.ToString(),
                                     Text = p.ID.ToString()
                                 }).ToList();

            SelFin = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Завершено"},
                           new SelectListItem{ Value = "False", Text = "Не завершено"}
                        };

            SelPay = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Оплачен"},
                           new SelectListItem{ Value = "False", Text = "Не оплачен"}
                        };

        }
    }
}
