using System.Collections.Generic;
using System.Linq;

namespace PollymerHelloWorld.Service.Modules
{
	public class DataProvider : IDataProvider
	{
		private readonly List<User> _users;

		public DataProvider()
		{
			_users = Faker.Extensions.EnumerableExtensions.Times(20, id => new User()
			{
				Name = Faker.Name.First(),
				Surname = Faker.Name.Last(),
				Address = Faker.Address.StreetAddress(),
				Phone = Faker.Phone.Number(),
				Id = id,
			}).ToList();
		}

		public IList<User> GetUsers()
		{
			return _users;
		}

		public User GetUser(int id)
		{
			return _users.FirstOrDefault(x => x.Id == id);
		}
	}
}