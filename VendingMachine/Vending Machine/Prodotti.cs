using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
	public class Prodotti
	{

		private static int _cocaCola;
		private static int _fanta;
        private static decimal _prezzoFanta;
		private static decimal _prezzoCocaCola;

		public static int cocaCola
		{
			get { return _cocaCola; }
			set { _cocaCola = value; }
		}

		public static int fanta
		{
			get { return _fanta; }
			set { _fanta = value; }
		}
		public static decimal prezzoFanta
		{
			get { return _prezzoFanta; }
			set { _prezzoFanta = value; }
		}
		public static decimal prezzoCocaCola
		{
			get { return _prezzoCocaCola; }
			set { _prezzoCocaCola = value; }
		}



	}
}
