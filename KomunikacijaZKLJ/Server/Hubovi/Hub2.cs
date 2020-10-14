using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikacijaZKLJ.Server.Hubovi
{
	public class Hub2 : Hub
	{
		private readonly Podaci _pd;
		private readonly ILogger<Hub2> _log;

		public Hub2(ILogger<Hub2> log, Podaci pd)
		{
			_pd = pd;
			_log = log;
			_log.LogInformation("Pravim hub");
		}

		public void Uvecaj()
		{
			_log.LogInformation("Uvecavam");
			_pd.Broj *= 2;
			Vrati();
		}
		public void Vrati()
		{
			_log.LogInformation("Saljem");
			Clients.Caller.SendAsync("broj", _pd.Broj);
		}
	}
}
