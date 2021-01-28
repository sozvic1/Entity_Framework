using System;
using System.Data.Entity;
using System.Linq;

namespace HomeTask4
{
    public class Model1 : DbContext
    {
       
        public Model1()
            : base("name=Model1")
        {
        }
     

         public virtual DbSet<User> User { get; set; }
         public virtual DbSet<Application> Application { get; set; }
         public virtual DbSet<PersonalInfo> PersonalInfo { get; set; }
    }

}