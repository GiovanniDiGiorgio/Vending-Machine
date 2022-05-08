using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
	public class Menu
	{

		static public void menu()
		{
			int a = 0;
			int b = 0;
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
					Console.WriteLine("Desideri caricare la macchina?");
					Console.WriteLine("Premi 1 per ok");
					Console.WriteLine("Premi 2 per annullare");
					b = Convert.ToInt32(Console.ReadLine());

					Funzioni.CaricaMacchina(b); //Funzione caricaMAcchina


				}

				else if (a == 2)
				{
					//Funzione preleva denaro
					Funzioni.Preleva();
				}

				else if (a == 3)
				{

					Funzioni.Compra();
				}

				else if (a == 4)
				{

					Funzioni.VisualizzaCredito();
				}
				else { Menu.menu(); }	

			}
			while (a != 5);
		}
	}

}
