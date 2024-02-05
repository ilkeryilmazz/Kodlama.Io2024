using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicantManager : IApplicantService
    {
        public bool CheckCitizen(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest() { Body = new TCKimlikNoDogrulaRequestBody() { Ad = citizen.FirstName, Soyad = citizen.LastName, DogumYili = citizen.DateOfBirthYear, TCKimlikNo = citizen.NationalIdentity } }).Result.Body.TCKimlikNoDogrulaResult;
            
        }

        public bool CheckForeignerCitizen(ForeignerCitizen foreignerCitizen)
        {
           if (foreignerCitizen.Passport.IsValid) return true;
           else return false;

        }
    }
}
