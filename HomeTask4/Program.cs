using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Model1>());

            using (Model1 db = new Model1())
            {
                User p1 = new User { FirstName = "Alex", SecondName = "LOLO" };
                User p2 = new User { FirstName = "Vladimir", SecondName = "Ivanovich" };
                User p3 = new User { FirstName = "Ivan", SecondName = "LALA" };
                User p4 = new User { FirstName = "Petro", SecondName = "Petrovich" };

                db.User.AddRange(new List<User> { p1, p2, p3, p4 });
                db.SaveChanges();

                Application app = new Application { Transaction = "Passed", Customer = "Ales" };
                app.User.Add(p1);
                app.User.Add(p2);
                app.User.Add(p3);

                Application app1 = new Application { Transaction = "Failed", Customer = "Ivan" };
                app1.User.Add(p1);
                app1.User.Add(p2);
                app1.User.Add(p3);

                db.Application.AddRange(new List<Application> { app, app1});
                db.SaveChanges();

                PersonalInfo personalInfo = new PersonalInfo { City = "Kyiv" };
                personalInfo.User.Add(p1);
                personalInfo.User.Add(p3);

                PersonalInfo personalInfo2 = new PersonalInfo { City = "Harkiv" };
                personalInfo2.User.Add(p2);

                db.PersonalInfo.AddRange(new List<PersonalInfo> { personalInfo, personalInfo2 });
                db.SaveChanges();

                foreach (var itemApplication in db.User.Include(p => p.Application))
                {
                    Console.WriteLine("{0}.{1}", itemApplication.Id, itemApplication.FirstName);

                    if (itemApplication.Application == null) continue;

                    foreach (var itemUser in itemApplication.Application)
                    {
                        Console.WriteLine("{0}.{1}.{2}", itemUser.Id, itemUser.Customer, itemUser.Transaction);
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                Console.WriteLine("-----------------------------------------");
                Console.ReadKey();

                foreach (var itemApplication in db.Application.Include(p => p.User))
                {
                    Console.WriteLine("{0}.{1}", itemApplication.Id, itemApplication.Customer);

                    if (itemApplication.User == null) continue;

                    foreach (var itemUser in itemApplication.User)
                    {
                        Console.WriteLine("{0}.{1} - {2}", itemUser.Id, itemUser.FirstName, itemUser.SecondName );
                    }
                    Console.WriteLine("-----------------------------------------");
                }

                Console.WriteLine("-----------------------------------------");
                Console.ReadKey();

                foreach (var itemPersonalInfo in db.PersonalInfo.Include(p => p.User))
                {
                    Console.WriteLine("{0}.{1}", itemPersonalInfo.Id, itemPersonalInfo.City);

                    if (itemPersonalInfo.User == null) continue;

                    foreach (var itemUser in itemPersonalInfo.User)
                    {
                        Console.WriteLine("{0}.{1} - {2}", itemUser.Id, itemUser.FirstName, itemUser.SecondName);
                    }
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
    }
}
