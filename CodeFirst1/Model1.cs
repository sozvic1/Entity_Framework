using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst1
{
    public class Model1 : DbContext
    {
      
        public Model1()
            : base("name=Model1")
        {
        }

      
        public virtual DbSet<Student> StudentList { get; set; }
        public virtual DbSet<AdditionalDetails> AdditionalDetailsList { get; set; }
    }

    
}