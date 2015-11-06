using System;

namespace PollymerHelloWorld.Service.Modules
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime Birthdate { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
	}
}