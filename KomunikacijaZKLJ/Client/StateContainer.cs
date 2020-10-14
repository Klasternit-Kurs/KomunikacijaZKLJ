using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KomunikacijaZKLJ.Client
{
	public class StateContainer
	{
		private string _sta;
		public string Sta 
		{ 
			get => _sta;
			set
			{
				_sta = value;
				OnPromena?.Invoke();
			}
		}

		private int _broj;
		public int Broj 
		{ 
			get => _broj; 
			set
			{
				_broj = value;
				OnPromena?.Invoke();
			}
		}

		public event Action OnPromena;
	}
}
