using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string str = "sweet";
        char ch = 'e';

        int freq = str.Count(f => (f == ch));
        Console.WriteLine(freq);
        Console.ReadLine();
    }
}