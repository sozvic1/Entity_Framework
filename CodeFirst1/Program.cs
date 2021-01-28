using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst1
{
    class Program
    {/// <summary>
    /// Task3
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {

            Model1 model1 = new Model1();
            Student student = new Student()
            {
                FirstName = "Alex",

            };
            Student student2 = new Student()
            {
                FirstName = "Igor",

            };

            model1.StudentList.Add(student);
            model1.StudentList.Add(student2);
            model1.SaveChanges();

            model1.AdditionalDetailsList.Add(new AdditionalDetails()
            {
                City = "Kyiv",
                Speciality = "Mathematik",
                Student = student
            });
            model1.AdditionalDetailsList.Add(new AdditionalDetails()
            {
                City = "Chernigov",
                Speciality = "Physik",
                Student = student2
            });

            model1.SaveChanges();

            using (Model1 db = new Model1())
            {
                IEnumerable<AdditionalDetails> details = db.AdditionalDetailsList.ToList();

                details = details.Where(x => x.Id == 2);
                foreach (var item in details)
                {
                    Console.WriteLine($"{item.Id} {item.City} {item.Speciality} {item.Student} ");
                }
                Console.ReadLine();
            }
        }
    }
}
