using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructDB.Models
{
    public class Position
    {
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }

    }
}
