using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Kalkulator
    {
        List<int> cifra;
        List<char> znach;
        public Kalkulator()
        {
            cifra = new List<int>();
            znach = new List<char>();
        }
        public void Vvod()
        {
            string vvod = Console.ReadLine();
            string[] massivchisel = vvod.Split(new char[] { '+', '-', '/', '*' });
            for (int i = 0; i < massivchisel.Length; i++)
            {
                cifra.Add(Convert.ToInt32(massivchisel[i]));
            }
            foreach (char i in vvod)
            {
                if (i == '+' || i == '-' || i == '*' || i == '/')
                {
                    znach.Add(i);
                }
            }
        }
        public void Iskat()
        {
            for (int v = 0; v <= znach.Count; v++)
            {
              
                for (int i = 0; i < znach.Count; i++)
                {
                    if (znach[i] == '+')
                    {
                        cifra[i] = cifra[i] + cifra[i + 1];
                        znach.RemoveAt(i);
                        cifra.RemoveAt(i + 1);
                    }
                    else if (znach[i] == '-')
                    {
                        cifra[i] = cifra[i] - cifra[i + 1];
                        znach.RemoveAt(i);
                        cifra.RemoveAt(i + 1);
                    }
                }
                for (int i = 0; i < znach.Count; i++)
                {
                    if (znach[i] == '/')
                    {
                        cifra[i] = cifra[i] / cifra[i + 1];
                        znach.RemoveAt(i);
                        cifra.RemoveAt(i + 1);
                    }
                    else if (znach[i] == '*')
                    {
                        cifra[i] = cifra[i] * cifra[i + 1];
                        znach.RemoveAt(i);
                        cifra.RemoveAt(i + 1);
                    }

                }
            }
            Console.WriteLine(cifra[0]);
        }

    }
}