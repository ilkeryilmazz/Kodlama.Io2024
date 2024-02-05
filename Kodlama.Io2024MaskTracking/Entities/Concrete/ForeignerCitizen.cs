using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ForeignerCitizen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Passport Passport { get; set; }
    }
}
