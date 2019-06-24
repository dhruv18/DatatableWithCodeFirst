using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataTablesWithResponsive.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1,12, ErrorMessage = "Age Must be between 18 to 56")]
        public string STD { get; set; }
        public int Hobies { get; set; }

    }
    public class ViewStudents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string STD { get; set; }
        public string Hobies { get; set; }
    }

}