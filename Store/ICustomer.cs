using System;
namespace Store
{
    public interface ICustomer
    {
        Customer GetCustomer(string name);

        double GetBonus(); 
    }
}
