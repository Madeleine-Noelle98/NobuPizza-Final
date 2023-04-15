namespace NobuPizza.Models.ViewModels
{
    public class ProductPlus: Product
    {
        public decimal Price => Cost - Cost * Discount / 100 + Cost * 20/100;

        public decimal GetPrice()
        {
            return Cost - Cost * Discount / 100 + Cost * 20 / 100;
        }
    }
}
