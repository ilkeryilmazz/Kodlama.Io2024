using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>() { new Course { Name="C#,",Id=1,Description="C# Kursu",InstructorId=1,CategoryId=1,ImagePath="csharp.png"},
            new Course { Name="JAVA,",Id=2,Description="JAVA Kursu",InstructorId=3,ImagePath="java.png",CategoryId=2 } };

        }
        public void Add(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var deletedCourse = courses.First(c => c.Id == entity.Id);
            courses.Remove(deletedCourse);
        }

        public Course Get(int id)
        {
            return courses.First(c => c.Id == id); ;
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course entity)
        {
            var updatedCourse = courses.First(c => c.Id == entity.Id);
            updatedCourse.Id = entity.Id;
            updatedCourse.Description = entity.Description;
            updatedCourse.Name = entity.Name;
            updatedCourse.InstructorId=entity.InstructorId;
            updatedCourse.CategoryId = entity.CategoryId;

        }
    }
}
