using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieProject.Models
{
    
    [Table("Movie")]
    public class Movie
    {

        public string Title { get; set; }
        public int MovieID { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreID { get; set; }

         
    }
}