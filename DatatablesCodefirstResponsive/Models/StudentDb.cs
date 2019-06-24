using DatatablesCodefirstResponsive.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataTablesWithResponsive.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StudentDb :DbContext
    {
        public DbSet<Students> students { get; set; }
        public  DbSet<hobbies> hobbies { get; set; }

        public StudentDb() 
            : base("WebAppCon") { }
        

    }
    
}