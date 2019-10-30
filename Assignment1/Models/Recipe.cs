using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
