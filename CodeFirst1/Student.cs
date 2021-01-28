using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst1
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public ICollection<AdditionalDetails> Additional { get; set; }
        public Student()
        {
            Additional = new List<AdditionalDetails>();
        }

    }
}

