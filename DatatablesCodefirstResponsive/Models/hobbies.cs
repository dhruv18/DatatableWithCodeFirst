using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatatablesCodefirstResponsive.Models
{
    public class hobbies
    {
        [Key]
        public int idhobbies { get; set; }

        public string hobbiesName { get; set; }

        public bool isselected { get; set; }
    }
}