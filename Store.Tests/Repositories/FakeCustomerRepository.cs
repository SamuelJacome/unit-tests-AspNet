using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;
//Mocks
namespace Store.Domain.Repositories.Interfaces
{
   public class FakeCustomerRepository : ICustomerRepository
   {
      public Customer Get(string document)
      {
         if (document == "1234567811")
            return new Customer("Bruce Wayne", "batman@balta.io");

         return null;

      }
   }
}