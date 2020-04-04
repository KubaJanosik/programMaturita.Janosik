using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programMaturita
{
    class general : vojak
    {
		string Titul;
		public general(string jmeno, string zbran, int pocetZivotu, int pocetNaboju, string titul) : base(jmeno, zbran, pocetZivotu, pocetNaboju)
		{
			Titul = titul;
		}
		public void povyseni()
		{
			Console.WriteLine("Pane, vojak {0} byl povysen do funkce {1}!", Jmeno, Titul);
		}
	}
}