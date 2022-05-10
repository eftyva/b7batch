using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class VowelCounter
    {
        public string GetCounts(string text)
        {
            int[] b = new int[5] { 0, 0, 0, 0, 0 };
            for (int ind = 0; ind < text.Length; ind++)
            {
                if (text[ind] == 'a' || text[ind] == 'A')
                {
                    b[0]++;
                }
                else if (text[ind] == 'e' || text[ind] == 'E')
                {
                    b[1]++;
                }
                else if (text[ind] == 'i' || text[ind] == 'I')
                {
                    b[2]++;
                }
                else if (text[ind] == 'o' || text[ind] == 'O')
                {
                    b[3]++;
                }
                else if (text[ind] == 'u' || text[ind] == 'U')
                {
                    b[4]++;
                }
            }
            string result = String.Join("", b);
            return result;
        }
    }
}
