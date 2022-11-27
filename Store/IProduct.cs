using System;
namespace Store
{
    public interface IProduct
    {
        Product GetProduct(string name); 

        double CalculateTotal(); // ei tule runkoa
    }
}
