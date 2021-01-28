using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ICollection<Application> Application { get; set; }
        public User()
        {
            Application = new List<Application>();
        }
    }
}
