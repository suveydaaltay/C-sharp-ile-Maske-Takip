using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    //çıplak class kalmasın
    public class PersonManager:IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

                return client.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest
                    (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                    .Result.Body.TCKimlikNoDogrulaResult;

                // MernisServiceReference1.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                // return client.TcKimlikNoDogrulaAsync(
                //   new TCKimlikNoDogrulaRequest
                // (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad:person.FirstName,Soyad:person.LastName,person.DateOfBirthYear)))
                //.Result.Body.TcKimlikNoDogrulaResult;
            }
            
        }
        //private TCKimlikNoDogrulaRequestBody TCKimlikNoDogrulaRequestBody(int request, string v1, string v2, int v3)
       // {throw new NotImplementedException();}

        //private TCKimlikNoDogrulaRequestBody TCKimlikNoDogrulaRequestBody()
        //{throw new NotImplementedException();}

    }
}
