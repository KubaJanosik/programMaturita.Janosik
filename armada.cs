using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programMaturita
{
    class armada
    {
        List<vojak> listVojaku = new List<vojak>();

        public armada()
        {

        }
		public vojak naverbovatVojaka()
		{
            vojak novyVojak = new vojak("jmeno", "samopal", 3, 21);
            Console.Write("Zadejte jmeno vojaka: ");
            novyVojak.Jmeno = Console.ReadLine();
            Console.Write("Kterou zbran chcete vojakovi dat?\n1 - pistoli\n2 - samopal\n3 - tezky kulomet\n4 - bazuku\n\n");
            int rozkaz2 = Int32.Parse(Console.ReadLine());
            switch (rozkaz2)
            {
                case 1:
                    novyVojak.Zbran = "pistole";
                    novyVojak.PocetNaboju = 7;
                    break;
                case 2:
                    novyVojak.Zbran = "samopal";
                    novyVojak.PocetNaboju = 21;
                    break;
                case 3:
                    novyVojak.Zbran = "tezky kulomet";
                    novyVojak.PocetNaboju = 120;
                    break;
                case 4:
                    novyVojak.Zbran = "bazuka";
                    novyVojak. PocetNaboju = 3;
                    break;
            }
            Console.Clear();
            listVojaku.Add(novyVojak);
            return listVojaku[listVojaku.Count - 1];
        }
        public void pridatVojaka(vojak defaultniVojak) //prida MacMillana do listu vojaku
        {
            listVojaku.Add(defaultniVojak);
        }
        public vojak vybratVojaka()
        {
            int vybraneCisloVojaka = vybratCisloVojaka();
            return listVojaku[vybraneCisloVojaka];
        }
        public void propustitVojaka()
        {
            for (int i = 0; i < listVojaku.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, listVojaku[i].Jmeno);
            }
            Console.Write("Vyberte vojaka ze seznamu: ");
            int cisloVojaka = Int32.Parse(Console.ReadLine()) - 1;
            if (cisloVojaka >= 0 && cisloVojaka < listVojaku.Count)
            {
                Console.WriteLine("Vojak {0} byl propusten pane!", listVojaku[cisloVojaka].Jmeno);
                listVojaku.RemoveAt(cisloVojaka);
            }
            else
            {
                Console.WriteLine("Spatne cislo, zkuste znovu.");
            }
        }
        private int vybratCisloVojaka() //vola se jen v armade
        {
            for (int i = 0; i < listVojaku.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, listVojaku[i].Jmeno);
            }
            Console.Write("\nCelkem vojaku: {0}\nVyberte vojaka ze seznamu: ", vojak.PocetVojaku);
            int cisloVojaka = Int32.Parse(Console.ReadLine()) - 1;
            if (cisloVojaka >= 0 && cisloVojaka < listVojaku.Count)
            {
                return cisloVojaka;
            }
            else
            {
                Console.WriteLine("Spatne cislo!");
                return -1;
            }
        }
    }
}
