using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace KomunikacijaZKLJ.Server.Hubovi
{
	public class Hub1 : Hub
	{
		private readonly Podaci _pd;
		private readonly ILogger<Hub1> _log;

		public Hub1(ILogger<Hub1> log, Podaci pd)
		{
			_pd = pd;
			_log = log;
			_log.LogInformation("Pravim hub");
		}

		public void Uvecaj()
		{
			_log.LogInformation("Uvecavam");
			_pd.Broj++;
			Vrati();
		}
		public void Vrati()
		{
			_log.LogInformation("Saljem");
			Clients.Caller.SendAsync("broj", _pd.Broj);
		}
	}
}
