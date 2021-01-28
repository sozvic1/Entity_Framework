using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
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
