using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Item
    {
        [Key] // annotion for primary key 
        public int Id { get; set; } // default identifier

        public string Borrower { get; set; }


    }
}
