using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Models
{
    public class Cenima
    {
        public int ID { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }


        public List<Movie> Movies { get; set; }

    }
}
