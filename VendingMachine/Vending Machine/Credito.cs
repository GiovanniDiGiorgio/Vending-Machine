using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{  
		public class Credito
		{
			private static decimal _credito=0;
			public static decimal credito
			{
				get { return _credito; }
				set { _credito = value; }
			}

		}
	
}
