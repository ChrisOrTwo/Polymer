using System;
using Nancy.Hosting.Self;
using PollymerHelloWorld.Service.Bootstrap;

namespace PollymerHelloWorld.Service.Host
{
	public class ServiceHost : IServiceHost
	{
		private NancyHost _host;

		public void Start()
		{
			const string connectionString = "http://localhost:8989/nancy/";

			var configuration = new HostConfiguration();
			configuration.UrlReservations = new UrlReservations();
			configuration.UrlReservations.CreateAutomatically = true;
			_host = new NancyHost(new Uri(connectionString), new ServiceBootstraper(), configuration);

			_host.Start();
			Console.WriteLine("Nancy is now listening on: {0}", connectionString);
		}

		public void Stop()
		{
			_host.Stop();
			_host.Dispose();
			Console.WriteLine("Stopped. Good bye!");
		}
	}
}