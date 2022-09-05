using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Tickets.Models
{
    public class Actor
    {
        public int ID { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePicURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
