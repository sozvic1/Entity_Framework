using System;
using System.Data.Entity;
using System.Linq;

namespace HomeTask_5
{
    public class Model1 : DbContext
    {        
        public Model1()
            : base("name=Model1")
        {
        }
        
         public virtual DbSet<Student> Student { get; set; }
         public virtual DbSet<People> People { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}