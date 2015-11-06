using System.Linq;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using PollymerHelloWorld.Service.Modules;

namespace PollymerHelloWorld.Service.Bootstrap
{
	public class ServiceBootstraper : DefaultNancyBootstrapper
	{
		protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
		{
			//CORS Enabled
			pipelines.AfterRequest.AddItemToEndOfPipeline(ctx =>
			{
				ctx.Response
					.WithHeader("Access-Control-Allow-Origin", "*")
					.WithHeader("Access-Control-Allow-Methods", "POST,GET")
					.WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
			});
		}

		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{
			container.Register<IDataProvider, DataProvider>();
			container.Register<INancyModule, DataModule>().AsSingleton();
		}
	}
}