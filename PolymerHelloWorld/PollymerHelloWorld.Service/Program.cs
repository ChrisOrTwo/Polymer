using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PollymerHelloWorld.Service.Host;

namespace PollymerHelloWorld.Service
{
	class Program
	{
		static void Main(string[] args)
		{
			var topshelf = new ServiceTopShelf();
			topshelf.Run();
		}
	}
}
