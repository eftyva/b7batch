namespace Task1
{
    public class VowelCounter
    {
        public string GetCounts(string str1)
        {
            int[] vowel = new int[5];
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == 'a' || str1[i] == 'A')
                {
                    vowel[0]++;
                }
                else if (str1[i] == 'e' || str1[i] == 'E')
                {
                    vowel[1]++;
                }
                else if (str1[i] == 'i' || str1[i] == 'I')
                {
                   vowel[2]++;
                }
                else if (str1[i] == 'o' || str1[i] == 'O')
                {
                    vowel[3]++;
                }
                else if (str1[i] == 'u' || str1[i] == 'U')
                {
                    vowel[4]++;
                }
            }
            string str = String.Join("", vowel);
            return str;
        }
    }
}