using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Review
    {
        public Recipe RecipeName { get; set; }
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Content { get; set; }
    }
}
