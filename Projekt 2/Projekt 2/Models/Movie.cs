using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt_2.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public int Year { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime DateView { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}