using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2OCP.NO_OCP
{
    public class DiscountServiceNoOCP
    {
        public double GetDiscount(ProductNoOCP product, string customerType)
        {
            if (customerType == "Regular")
            {
                return product.Price * 0.1; // 10% de desconto 
            }
            else if (customerType == "VIP")
            {
                return product.Price * 0.2; // 20 % de desconto
            }
            else if (customerType == "Premim")
            {
                return product.Price * 0.3; // 30 % de desconto
            }
            else
            {
                return 0.0; // zero desconto adicional 
            }
        }
    }
}
