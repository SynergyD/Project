using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        
        [StringLength(25)]
        [Required(ErrorMessage ="Длина имени не менее 2 символов")]
        public string Name { get; set; }
        
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Surname { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина адреса не менее 10 символов")]
        public string Adress { get; set; }
        [Display(Name = "Номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина адреса не менее 10 символов")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина email не менее 10 символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
