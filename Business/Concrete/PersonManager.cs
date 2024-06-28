using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete //somut nesneler
{ //encapsulation kapsülleme verilerin tek bir birim altında toplanması
    public class PersonManager : IApplicianService
    {
        public void ApplyForMask(Person person)
        {

            //implementasyon buaya gelecek
        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //mernis kontrolü yapılacak
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName, Soyad: person.LastName, person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;



        }
    }
}
