using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor:Entity
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }


    }
}
