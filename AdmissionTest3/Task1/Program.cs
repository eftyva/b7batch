using Task1;

string x = Console.ReadLine();
VowelCounter obj = new VowelCounter();
string ans = obj.GetCounts(x);
char[] _char1 = ans.ToCharArray();
int i = 0;
while( i< _char1.Length)
{
    if (i == 0)
        Console.Write("a-" + _char1[i] + ",");
    else if (i == 1)
        Console.Write("e-" + _char1[i] + ",");
    else if (i == 2)
        Console.Write("i-" + _char1[i] + ",");
    else if (i == 3)
        Console.Write("o-" + _char1[i] + ",");
    else if (i == 4)
        Console.Write("u-" + _char1[i]);
    i++;
}

    