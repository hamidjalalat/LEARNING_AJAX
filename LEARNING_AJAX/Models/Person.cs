namespace Models
{
	public class Person : System.Object
	{
		public Person()
		{
			Id = System.Guid.NewGuid();
		}

		public System.Guid Id { get; set; }

		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "First Name")]
		public string LastName { get; set; }

		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Last Name")]
		public string FirstName { get; set; }
	}
}
