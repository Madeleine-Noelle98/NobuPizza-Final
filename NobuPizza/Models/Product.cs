namespace NobuPizza.Models
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Cost { get; set; }
		public decimal Discount { get; set; }
		public decimal Weight { get; set; }

		public decimal Calories { get; set; }
		public DateTime CreatedOn { get; set; }
		public bool Availability { get; set; }

		public int Quantity { get; set; }


	}
}
