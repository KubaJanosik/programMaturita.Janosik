using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programMaturita
{
    class vojak
    {
		public string Jmeno;
		public string Zbran;
		public int PocetZivotu;
		public int PocetNaboju;
		public static int PocetVojaku;
		public vojak(string jmeno, string zbran, int pocetZivotu, int pocetNaboju)
		{
			Jmeno = jmeno;
			Zbran = zbran;
			PocetZivotu = pocetZivotu;
			PocetNaboju = pocetNaboju;
			PocetVojaku++;
		}
		public void hlaseni()
		{
			Console.WriteLine("Pane, vojak {0} vyzbrojen zbrani {1} se hlasi do sluzby!\nPocet naboju: {3}, momentalni zdravotni stav: {2}", Jmeno, Zbran, PocetZivotu, PocetNaboju);
		}
		public void strelba(int vystreleneNaboje)
		{
			if (PocetNaboju < vystreleneNaboje)
			{
				Console.WriteLine("Nedostatek munice!");
			}
			else if (Zbran == "pistole")
			{
				PocetNaboju = PocetNaboju - vystreleneNaboje;
				Console.WriteLine("*pif paf*\nPocet naboju: {0}", PocetNaboju);
			}
			else if (Zbran == "samopal")
			{
				PocetNaboju = PocetNaboju - vystreleneNaboje * 3;
				Console.WriteLine("*ratata*\nPocet naboju: {0}", PocetNaboju);
			}
			else if (Zbran == "tezky kulomet")
			{
				PocetNaboju = PocetNaboju - vystreleneNaboje * 12;
				Console.WriteLine("*ratatatatatatatata*\nPocet naboju: {0}", PocetNaboju);
			}
			else if (Zbran == "bazuka")
			{
				PocetNaboju = PocetNaboju - vystreleneNaboje;
				Console.WriteLine("*bum*\nPocet naboju: {0}", PocetNaboju);
			}
		}
		public void doplnitMunici()
		{
			if(Zbran == "pistole")
			{
				PocetNaboju = 7;
			}
			else if (Zbran == "samopal")
			{
				PocetNaboju = 21;
			}
			else if (Zbran == "tezky kulomet")
			{
				PocetNaboju = 120;
			}
			else if (Zbran == "bazuka")
			{
				PocetNaboju = 3;
			}
			Console.WriteLine("Munice doplnena!\nPocet naboju: {0}", PocetNaboju);
		}
		public void zmenitZbran()
		{
			Console.Clear();
			Console.WriteLine("Kterou zbran chcete vojakovi dat?\n1 - pistoli\n2 - samopal\n3 - tezky kulomet\n4 - bazuku");
			int rozkaz1 = 0;
			rozkaz1 = Int32.Parse(Console.ReadLine());
			Console.Clear();
			switch (rozkaz1)
			{
				case 1:
					Zbran = "pistole";
					PocetNaboju = 7;
					break;
				case 2:
					Zbran = "samopal";
					PocetNaboju = 21;
					break;
				case 3:
					Zbran = "tezky kulomet";
					PocetNaboju = 120;
					break;
				case 4:
					Zbran = "bazuka";
					PocetNaboju = 3;
					break;
			}
		}
	}
}
