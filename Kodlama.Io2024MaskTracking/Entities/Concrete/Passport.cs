using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Passport
    {
        public string Country { get; set; }
        public string PassportNo { get; set; }
        public bool IsValid { get; set; }
    }
}
