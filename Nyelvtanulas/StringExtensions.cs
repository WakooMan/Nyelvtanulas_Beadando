using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvtanulas
{
    public static class StringExtensions
    {
        private static Dictionary<char, char> parok = new Dictionary<char, char>();
        static StringExtensions()
        {
            char[] ekezetes = new char[] { 'á','Á','é','É','ó','Ó','ő','Ő','ö','Ö','ű','Ű','ú','Ú','ü','Ü','í','Í'};
            char[] ekezettelen = new char[] {'a','A','e','E','o','O','o','O','o','O','u','U','u','U','u','U','i','I'};
            for (int i = 0; i < ekezetes.Length;i++)
            {
                parok.Add(ekezetes[i],ekezettelen[i]);
            }
        }
        public static string Ekezettelenit(this string str)
        {
            string ekezettelen = "";
            foreach (char c in str)
            {
                ekezettelen += (parok.ContainsKey(c))?parok[c]:c;
            }
            return ekezettelen;
        }
    }
}
