using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //Entity Framework will identify this as Identity and Primary Key Column
        [Required]
        public string Name { get; set; }

    }
}
