using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class Application
    {        
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Transaction { get; set; }
        public ICollection<User> User { get; set; }
        public Application()
        {
            User = new List<User>();
        }
    }
}
