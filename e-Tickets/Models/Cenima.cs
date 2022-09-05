using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Models
{
    public class Cenima
    {
        public int ID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public List<Movie> Movies { get; set; }

    }
}
