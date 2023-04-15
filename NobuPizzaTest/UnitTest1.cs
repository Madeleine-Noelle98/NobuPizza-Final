using NobuPizza.Models.ViewModels;

namespace NobuPizzaTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckPriceProperty()
        {
            ProductPlus product = new ProductPlus();

            product.Cost = 500;
            product.Discount = 5;

            Assert.Equal(product.Price, 575);
        }

        [Fact]
        public void CheckGetPriceMethod()
        {
            ProductPlus product = new ProductPlus();

            product.Cost = 100;
            product.Discount = 10;

            Assert.Equal(product.GetPrice(), 110);
        }
    }
}