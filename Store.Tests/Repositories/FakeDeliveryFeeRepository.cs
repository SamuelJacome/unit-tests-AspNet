using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;
//Mocks
namespace Store.Domain.Repositories.Interfaces
{
   public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
   {
      public decimal Get(string zipCode)
      {
         return 10;
      }
   }
}