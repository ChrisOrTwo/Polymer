using System;
using Topshelf;
using Topshelf.HostConfigurators;
using Topshelf.ServiceConfigurators;

namespace PollymerHelloWorld.Service.Host
{
	public class ServiceTopShelf
	{
		public void Run()
		{
			HostFactory.Run(FactoryConfiguration());
		}

		private static Action<HostConfigurator> FactoryConfiguration()
		{
			return c =>
			{
				c.Service(ServiceConfiguration());
				c.RunAsLocalSystem();
				c.SetDescription("PolymerHelloWorld Service Host");
				c.SetDisplayName("PolymerHelloWorldNancySelfHost");
				c.SetServiceName("PolymerHelloWorldNancySelfHost");
			};
		}

		private static Action<ServiceConfigurator<IServiceHost>> ServiceConfiguration()
		{
			return s =>
			{
				s.ConstructUsing(name => new ServiceHost());
				s.WhenStarted(x => x.Start());
				s.WhenStopped(x => x.Stop());
			};
		}
	}
}