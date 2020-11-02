using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructDB.Models
{
    public class Brigade
    {
        public long ID { get; set; }
        [Display(Name = "ID_Сотрудник1")]
        public long? Staff1ID { get; set; }
        public DbSet<Staff> Staff1 { get; set; }
        [Display(Name = "ID_Сотрудник2")]
        public long? Staff2ID { get; set; }
        public DbSet<Staff> Staff2 { get; set; }
        [Display(Name = "ID_Сотрудник3")]
        public long? Staff3ID { get; set; }
        public DbSet<Staff> Staff3 { get; set; }
    }
}
