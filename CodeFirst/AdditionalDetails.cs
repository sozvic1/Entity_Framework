using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class AdditionalDetails
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public string City { get; set; }
        public Student Student { get; set; }

    }
}
