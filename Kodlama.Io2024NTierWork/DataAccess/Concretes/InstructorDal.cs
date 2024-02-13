using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInsturctorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>() { new Instructor { FirstName="Engin", LastName="Demiroğ" ,Description="Engin Demiroğ açıklama" ,Id=1,ImagePath="test.png"}, new Instructor { FirstName = "Halit Enes", LastName = "Kalaycı", Description = "Halit Enes Kalaycı açıklama", Id = 2, ImagePath = "test.png" } };

        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var deletedInstructor = instructors.First(c => c.Id == entity.Id);
            instructors.Remove(deletedInstructor);
        }

        public Instructor Get(int id)
        {
            return instructors.First(c => c.Id == id); ;
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor = instructors.First(c => c.Id == entity.Id);
            updatedInstructor.Id = entity.Id;
            updatedInstructor.Description = entity.Description;
            updatedInstructor.FirstName = entity.FirstName;
            updatedInstructor.LastName = entity.LastName;
            updatedInstructor.ImagePath = entity.ImagePath;
        }
    }
}
