using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Models
{
    public class Producer
    {
        public int ID { get; set; }
        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
