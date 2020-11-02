using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace ConstructDB.Models
{
    public class Order
    {
        public long ID { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Дата начала")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Дата оканчания")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Отметка завершения")]
        public string CompletionMark { get; set; }
        [Display(Name = "Об оплате")]
        public string AboutPayment { get; set; }
        [Display(Name = "ID_Заказчик")]
        public long? CustomerID { get; set; }
        public DbSet<Customer> Customer { get; set; }
        [Display(Name = "ID_Вид работы")]
        public long? TypeOfJobID { get; set; }
        public DbSet<TypeOfJob> TypeOfJob { get; set; }
        [Display(Name = "ID_Бригада")]
        public long? BrigadeID { get; set; }
        public DbSet<Brigade> Brigade { get; set; }
        [Display(Name = "ID_Сотрудник")]
        public long? StaffID { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
