using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string City { get; set; }        
        public ICollection<User> User { get; set; }
        public PersonalInfo()
        {
            User = new List<User>();
        }
    }
}
