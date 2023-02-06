using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListProject.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Display(Name ="Complete")]
        public bool ISComplete { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public User User { get; set; }
    }
}
