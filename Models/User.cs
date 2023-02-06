using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListProject.Models
{
    public class User : IdentityUser
    {
        public byte[] Image { get; set; }
        public ICollection<Item> items { get; set; }
    }
}
