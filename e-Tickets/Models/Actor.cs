using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
