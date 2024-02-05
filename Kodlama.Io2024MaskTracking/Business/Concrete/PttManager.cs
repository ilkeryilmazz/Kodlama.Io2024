using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;   
        }
        public void GiveMask(Citizen citizen)
        {
          
            if (_applicantService.CheckCitizen(citizen)) 
            {
                Console.WriteLine(citizen.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(citizen.FirstName + " için maske verilemedi.");
            }
        }

        public void GiveMaskToForeignerCitizen(ForeignerCitizen foreignerCitizen)
        {
            if (_applicantService.CheckForeignerCitizen(foreignerCitizen))
            {
                Console.WriteLine(foreignerCitizen.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(foreignerCitizen.FirstName + " için maske verilemedi.");
            }
        }
    }
}
