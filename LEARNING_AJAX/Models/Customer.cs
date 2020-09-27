namespace Models
{
	public class Customer : System.Object
	{
		public Customer()
		{
		}

		public int Age { get; set; }

		[System.ComponentModel.DataAnnotations.Required]
		public string FullName { get; set; }
	}
}
