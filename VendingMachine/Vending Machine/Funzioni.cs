using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    internal class Funzioni
    {

		public static void CaricaMacchina(int b)
		{

			if (b != 1) { Menu.menu(); }
			else
			{
				int c = 0;
				Console.WriteLine("Quale prodotto desideri caricare?");
				Console.WriteLine("Premi 1 per Fanta");
				Console.WriteLine("Premi 2 per Coca Cola");
				Console.WriteLine("premi 3 per tornare al menù:");
				c = Convert.ToInt32(Console.ReadLine());
				if (c == 1)
				{
					int d = 0;
					Console.WriteLine("Quanti pezzi sono in totale? ");
					d = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Imposta prezzo");
					Prodotti.prezzoFanta = Convert.ToDecimal(Console.ReadLine());
					Prodotti.fanta = d;
				}
				else if (c == 2)
				{
					int q = 0;
					Console.WriteLine("Quanti pezzi sono in totale? ");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Imposta prezzo");
					Prodotti.prezzoCocaCola = Convert.ToDecimal(Console.ReadLine());
					Prodotti.cocaCola = q;
				}
				else { Menu.menu(); }
				Console.WriteLine("Le fanta sono: " + Prodotti.fanta + " le coca Cola sono: " + Prodotti.cocaCola + "\n");

			}




		}
		//funzione ritira denaro
		public static void Preleva()
		{
			Console.WriteLine("Quanto denaro vuoi lasciare?");
			Credito.credito = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Il credito totale è: " + Credito.credito + " euro \n");
		}

		public static void Compra()
		{
			int e = 0;
			Console.WriteLine("Resto totale disponibile: \n"+ Credito.credito);
			Console.WriteLine("Quale prodotto vuoi acquistare?: \n");
			Console.WriteLine("Premi 1 per Fanta");
			Console.WriteLine("Premi 2 per Coca Cola");
			Console.WriteLine("premi 3 per tornare al menù:");
			e = Convert.ToInt32(Console.ReadLine());

			if (e == 1)
			{
				if (Prodotti.fanta == 0)
				{
					Console.WriteLine("Prodotto non disponibile, aggiungere prima il prodotto");
					Menu.menu();
				}
				else
				{
					int f = 0;
					Console.WriteLine("COSTO: "+Prodotti.prezzoFanta + " EURO");
					Console.WriteLine("premi 1 per confermare");
					Console.WriteLine("premi 2 per annullare");
					f = Convert.ToInt32(Console.ReadLine());
					if (f == 1)
					{
						decimal g;
						Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
						g = Convert.ToDecimal(Console.ReadLine());
						decimal resto = Convert.ToDecimal(g - Prodotti.prezzoFanta);
						if (resto < 0)
						{
							int conferma = 0;
							Console.WriteLine("mancano ancora: " + Decimal.Round(resto,3));
							Console.WriteLine("Vuoi inserie le monete rimanenti? ");
							Console.WriteLine("premi 1 per confermare");
							Console.WriteLine("premi 2 per annullare");
							conferma = Convert.ToInt32(Console.ReadLine());
							if (conferma == 1)
							{
								decimal s;

								Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
								s=Convert.ToDecimal(Console.ReadLine())+g;
								resto = Convert.ToDecimal(s - Prodotti.prezzoFanta);
								if (resto < 0)
								{
								
									Console.WriteLine("mancano ancora: " + Decimal.Round(resto,3));
									Console.WriteLine("Vuoi inserie le monete rimanenti? ");
									Console.WriteLine("premi 1 per confermare");
									Console.WriteLine("premi 2 per annullare");
									
									conferma = Convert.ToInt32(Console.ReadLine());
									if (conferma == 1)
									{
									decimal t = 0;

										Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
										t = Convert.ToDecimal(Console.ReadLine()) + s;
										decimal resto2 = Convert.ToDecimal(t - Prodotti.prezzoFanta);
										if (resto2 < 0)
										{
											Console.WriteLine("Non hai abbastanza denaro, erogazione monete in corso");

											Menu.menu();
										}
										else
										{

											Console.WriteLine("il tuo resto è pari a: " + Decimal.Round(resto2,3));
                                            if (resto2 > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
											Prodotti.fanta--;
											Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
											
											Credito.credito += Prodotti.prezzoFanta;
										}
									}
									else
									{
										Console.WriteLine("il tuo resto è pari a: " + Decimal.Round(s, 3));
										if (s > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
										Menu.menu();
									}
								}
								else
								{
									Prodotti.fanta--;
									Credito.credito += Prodotti.prezzoFanta;
									Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
									Menu.menu();
								}
								
							}
							else
							{
								Console.WriteLine("Erogazione :" + g+" Euro in corso");
								Menu.menu();
							}
						}
						else {
							Console.WriteLine("il tuo resto è pari a: " + Decimal.Round(resto, 3));
							if (resto > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
							Prodotti.fanta--;
							Credito.credito += Prodotti.prezzoFanta;

							Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
							Menu.menu();
						}
						
					}
					else { 
						
						Menu.menu(); 
					}

					
					
				}
			}
			else if (e == 2)
			{
				if (Prodotti.cocaCola == 0)
				{
					Console.WriteLine("Prodotto non disponibile, aggiungere prima il prodotto");
					Menu.menu();
				}
				else
				{
					int f = 0;
					Console.WriteLine("COSTO: "+Prodotti.prezzoCocaCola+" EURO");
					Console.WriteLine("premi 1 per confermare");
					Console.WriteLine("premi 2 per annullare");
					f = Convert.ToInt32(Console.ReadLine());
					if (f == 1)
					{
						decimal g;
						Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
						g = Convert.ToDecimal(Console.ReadLine());
						decimal resto = Convert.ToDecimal(g - Prodotti.prezzoCocaCola);
						if (resto < 0)
						{
							int conferma = 0;
							Console.WriteLine("mancano ancora: " + Decimal.Round(resto, 3));
							Console.WriteLine("Vuoi inserie le monete rimanenti? ");
							Console.WriteLine("premi 1 per confermare");
							Console.WriteLine("premi 2 per annullare");
							conferma = Convert.ToInt32(Console.ReadLine());
							if (conferma == 1)
							{
								decimal s;

								Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
								s = Convert.ToDecimal(Console.ReadLine()) + g;
								resto = Convert.ToDecimal(s - Prodotti.prezzoCocaCola);
								if (resto < 0)
								{

									Console.WriteLine("mancano ancora: " + Decimal.Round(resto, 3));
									Console.WriteLine("Vuoi inserie le monete rimanenti? ");
									Console.WriteLine("premi 1 per confermare");
									Console.WriteLine("premi 2 per annullare");
									conferma = Convert.ToInt32(Console.ReadLine());
									if (conferma == 1)
									{
										decimal t = 0;

										Console.WriteLine("inserisci moneta, quanto vuoi inserire? \n");
										t = Convert.ToDecimal(Console.ReadLine()) + s;
										decimal resto2 = Convert.ToDecimal(t - Prodotti.prezzoCocaCola);
										if (resto2 < 0)
										{
											Console.WriteLine("Non hai abbastanza credito, erogazione monete in corso");

											Menu.menu();
										}
										else
										{
											Console.WriteLine("il tuo resto è pari a: " + Decimal.Round(resto2,3));
											if (resto2 > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
											Prodotti.cocaCola--;
											Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
											
											Credito.credito += Prodotti.prezzoCocaCola;
										}
									}
									else
									{

										Console.WriteLine("il tuo resto è pari a: " + s);
										
										Menu.menu();
									}
								}
								else
								{
									Console.WriteLine("il tuo resto è pari a: " + resto);
									if (resto > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
									Prodotti.cocaCola--;
									Credito.credito += Prodotti.prezzoCocaCola;
									Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
									Menu.menu();
								}
								
							}
							else
							{
								Console.WriteLine("Erogazione :" + g + " Euro in corso");
								Menu.menu();
							}
						}
						else
						{
							Console.WriteLine("il tuo resto è pari a: " + Decimal.Round(resto, 3));
							if (resto > Credito.credito) { Console.WriteLine("Resto non disponibile "); }
							Prodotti.cocaCola--;
							Credito.credito += Prodotti.prezzoCocaCola;

							Console.WriteLine("Prodotto in erogazione.....Le fanta rimaste sono: " + Prodotti.fanta + " le Coca Cola rimaste sono: " + Prodotti.cocaCola + "\n");
							Menu.menu();
						}

					}
					else { Menu.menu(); }



				}
			}
		}

		public static void VisualizzaCredito()
        {
			Console.WriteLine("Il credito totale è: " + Credito.credito);
			Menu.menu();
        }

	}
}
