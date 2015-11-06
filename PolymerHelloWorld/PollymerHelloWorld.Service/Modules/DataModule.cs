using Nancy;
using Nancy.ModelBinding;

namespace PollymerHelloWorld.Service.Modules
{
	public class DataModule : NancyModule
	{
		public DataModule(IDataProvider provider)
		{
			Get["/Users"] = x =>
			{
				return Response.AsJson(provider.GetUsers());
			};

			Get["/Users/{id}"] = x =>
			{
				return Response.AsJson(provider.GetUser((int)x.id));
			};
		}
	}
}