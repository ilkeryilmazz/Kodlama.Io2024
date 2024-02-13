using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:Entity
    {
    
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int InstructorId{ get; set; }
        public int CategoryId { get; set; }
    }
}
