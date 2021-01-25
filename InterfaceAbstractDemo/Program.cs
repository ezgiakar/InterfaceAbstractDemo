using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            baseCustomerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 10, 3),
                FirstName = "Ezgi",
                LastName = "Akar",
                NationalityId = "12345678910"
            });
        }
    }
}
