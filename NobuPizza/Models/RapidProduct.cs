namespace NobuPizza.Models
{


	public class RapidProduct
	{
		public int id { get; set; }
		public string title { get; set; }
		public string image { get; set; }
		public float price { get; set; }
		public string[] cuisines { get; set; }
		public string[] dishTypes { get; set; }
		public string[] diets { get; set; }
	}


}
