using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Çağrı",
                LastName = "Soral",
                NationalityId = "26065784266",
                DateOfBirth = new
                System.DateTime(1990, 11,11)
            }) ;
            System.Console.ReadLine();
        }
    }
}
