using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2OCP.WITH_ACP
{
    public class DiscountService
    {
        private IDiscountStrategy _discountStrategy;

        public DiscountService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double GetDiscount(Product product)
        {
            return _discountStrategy.ApplyDiscount(product);
        }
    }
}
