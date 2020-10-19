using System;
using System.Collections.Generic;
using System.Linq;

namespace testes.venturus
{
    // Verificar se itens em uma lista de string são equivalentes
    // Equivalentes:
    //   Se tiver o mesmo número de caracteres
    //   Se um determinado caractere não tiver quatro a mais ou a menos em relação ao item
    // da outra lista na mesma posição.
    public class teste01
    {
        public List<string> s;
        public List<string> t;
        public teste01()
        {
            s = new List<string>() { "aaa", "bbbbb", "ddddd" };
            t = new List<string>() { "aa", "ccccc", "assss" };
        }
        public List<string> Equivalentes()
        {
            var lista = new List<string>();

            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].Length != t[i].Length)
                    lista.Add("NO");
                else
                {
                    var yes = true;

                    for (int j = 0; j < s[i].Length; j++)
                    {
                        var char_s = Convert.ToChar(s[i].Substring(j, 1));
                        var count_s = s[i].Count(x => x == char_s);
                        var count_t = t[i].Count(x => x == char_s);

                        if ((count_s - count_t) > 3 || (count_s - count_t) < -3)
                        {
                            yes = false;
                            break;
                        }
                    }
                    if (yes)
                    {
                        for (int j = 0; j < s[i].Length; j++)
                        {
                            var char_t = Convert.ToChar(t[i].Substring(j, 1));
                            var count_s = s[i].Count(x => x == char_t);
                            var count_t = t[i].Count(x => x == char_t);

                            if ((count_s - count_t) > 3 || (count_s - count_t) < -3)
                            {
                                yes = false;
                                break;
                            }
                        }
                    }

                    if (yes)
                        lista.Add("YES");
                    else
                        lista.Add("NO");

                }
            }

            return lista;
        }
    }
}