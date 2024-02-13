﻿using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager:IInstructorService
    {
        IInsturctorDal _instructorDal;

        public InstructorManager(IInsturctorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    
}
}
