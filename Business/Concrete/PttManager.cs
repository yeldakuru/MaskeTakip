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
        private IApplicianService _applicianService;

        public PttManager(IApplicianService applicianService)//constractur new yapıldıgında çalısır
        {
            _applicianService = applicianService;
        }
        public void GiveMask(Person person)
        {

            if (_applicianService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}
