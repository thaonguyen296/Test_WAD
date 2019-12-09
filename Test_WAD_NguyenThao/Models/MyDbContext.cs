using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test_WAD_NguyenThao.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=MyContext")
        {

        }
        public DbSet<Exam> Exams { get; set; }
    }

}