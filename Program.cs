using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programMaturita
{
	class Program
	{
		static void Main(string[] args)
		{
			armada Armada = new armada();
			vojak macMillan = new vojak("John MacMillan", "samopal", 3, 21);
			vojak currentVojak = macMillan;
			Armada.pridatVojaka(macMillan);

			int rozkaz0 = 0;
			do
			{
				Console.WriteLine("Pane, cekame na vase rozkazy!\n1 - hlaseni\n2 - strelba\n3 - doplnit munici\n4 - zmenit zbran\n5 - vybrat vojaka\n6 - naverbovat vojaka\n7 - propustit vojaka\n8 - povysit soucasneho vojaka\n9 - opustit armadu\n");
				rozkaz0 = Int32.Parse(Console.ReadLine());
				Console.Clear();
				switch (rozkaz0)
				{
					case 1:
						currentVojak.hlaseni();
						break;
					case 2:
						currentVojak.strelba(1);
						break;
					case 3:
						currentVojak.doplnitMunici();
						break;
					case 4:
						currentVojak.zmenitZbran();
						break;
					case 5:
						currentVojak = Armada.vybratVojaka();
						break;
					case 6:
						currentVojak = Armada.naverbovatVojaka();
						break;
					case 7:
						Armada.propustitVojaka();
						break;
					case 8:
						general General = new general(currentVojak.Jmeno, currentVojak.Zbran, currentVojak.PocetZivotu, currentVojak.PocetNaboju, "porucik");
						General.povyseni();
						break;
				}
			}
			while (rozkaz0 != 9);
		}
	}
}
