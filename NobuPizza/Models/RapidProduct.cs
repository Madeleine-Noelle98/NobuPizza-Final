namespace NobuPizza.Models
{
	//public class RapidProduct
	//{
	//}
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
	public class MediumPan
	{
		public int price { get; set; }
	}

	public class Mediumstuffedcrustcheesemax
	{
		public int price { get; set; }
	}

	public class Mediumstuffedcrustvegkebab
	{
		public int price { get; set; }
	}

	public class RapidProduct
	{
		public int id { get; set; }
		public string name { get; set; }
		public bool veg { get; set; }
		public int price { get; set; }
		public string description { get; set; }
		public int quantity { get; set; }
		public string img { get; set; }
		public List<Sizeandcrust> sizeandcrust { get; set; }
	}

	public class Sizeandcrust
	{
		public List<MediumPan> mediumPan { get; set; }
		public List<Mediumstuffedcrustcheesemax> mediumstuffedcrustcheesemax { get; set; }
		public List<Mediumstuffedcrustvegkebab> mediumstuffedcrustvegkebab { get; set; }
	}


}
