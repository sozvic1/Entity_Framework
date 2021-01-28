using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 model = new Model1();
            Student student = new Student()
            {
                Cpeciality ="Auth",
                City = "Dnepr",

            };
            Student student2 = new Student()
            {
                Cpeciality = "Debt",
                City = "Kyiv",

            };
            model.Student.Add(student);
            model.Student.Add(student2);
            model.SaveChanges();

            

            model.People.Add(new People { Name = "Alex",Age =12,Student = student });
            model.People.Add(new People { Name = "Igor", Age =17,Student = student2 });
            model.People.Add(new People { Name = "Ivan", Age = 34, Student = student2 });
            model.SaveChanges();
            using (Model1 db = new Model1())
            {
                IEnumerable<Student> details = db.Student.ToList();
                var val = details.Where(x => x.City == "Kyiv").First();
                Console.WriteLine($"{val.City} , {val.Cpeciality}, {val.Id}");
                var order = details.OrderBy(x => x.Cpeciality).FirstOrDefault();
                Console.WriteLine($"{order.City}, {order.Cpeciality}, {order.Id}");
                var count = details.Where(x =>x.City == "Kyiv").ToList().Count();
                Console.WriteLine(count);


               var minAge = db.People.Select(x => x.Age).Min();
                Console.WriteLine(minAge);
                var maxAge = db.People.Select(x => x.Age).Max();
                Console.WriteLine(maxAge);
                var avarAge = db.People.Select(x => x.Age).Average();
                Console.WriteLine(avarAge);
                Console.ReadLine();
            }

        }
    }
}
