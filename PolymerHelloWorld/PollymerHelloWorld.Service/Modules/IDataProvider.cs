using System.Collections.Generic;

namespace PollymerHelloWorld.Service.Modules
{
	public interface IDataProvider
	{
		IList<User> GetUsers();

		User GetUser(int id);
	}
}