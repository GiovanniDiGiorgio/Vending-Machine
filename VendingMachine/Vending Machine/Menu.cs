using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
	public class Menu
	{
		private static string _password="";
		public static string password
        {
			get { return _password; }	
			set { _password = value; }
        }
		public static void impostaPassword()
        {
			Console.WriteLine("Questo è il tuo primo accesso, imposta una password: ");
			password = Console.ReadLine();
		}

		static public void menu()
		{
			int a = 0;
			int b = 0;
			
			

			if (Menu.password == "")
			{
				Menu.impostaPassword();
				
			}
			do
			{
				

				Console.WriteLine("scegli una delle seguenti opzioni:");
				Console.WriteLine("permi 1 per Caricare macchina");
				Console.WriteLine("permi 2 prelevare denaro");
				Console.WriteLine("premi 3 per Acquistare");
				Console.WriteLine("premi 4 per Visualizzate Credito Totale");

				a = Convert.ToInt32(Console.ReadLine());

				if (a == 1)
				{
					string pas = "";
					Console.WriteLine("inserire password");
					pas = Console.ReadLine();
					if (pas == password)
					{
						Console.WriteLine("Desideri caricare la macchina?");
						Console.WriteLine("Premi 1 per ok");
						Console.WriteLine("Premi 2 per annullare");
						b = Convert.ToInt32(Console.ReadLine());

						Funzioni.CaricaMacchina(b); //Funzione caricaMAcchina
					}
					else
					{
						Console.WriteLine("password errata");
						Menu.menu();
					}
					


				}

				else if (a == 2)
				{
					string pas = "";
					Console.WriteLine("inserire password");
					pas = Console.ReadLine();
					if (pas == password) { 
					//Funzione preleva denaro
					Funzioni.Preleva();
					}
                    else
                    {
						Console.WriteLine("password errata");
						Menu.menu();
                    }
				}

				else if (a == 3)
				{

					Funzioni.Compra();
				}

				else if (a == 4)
				{
					string pas = "";
					Console.WriteLine("inserire password");
					pas = Console.ReadLine();
					if (pas == password)
					{
						Funzioni.VisualizzaCredito();
					}
					else
					{
						Console.WriteLine("password errata");
						Menu.menu();
					}
					
				}
				else { Menu.menu(); }	

			}
			while (a != 5);
		}
	}

}
