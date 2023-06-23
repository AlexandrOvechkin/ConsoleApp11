using System;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static string Reverse(this string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("input:");
        string lines = Console.ReadLine();


        if (lines.Length % 2 == 0)
        {
            int i = lines.Length / 2;
            string first = lines[..i];
            string second = lines[i..];

            string reverseFirst = first.Reverse();
            string reversSecond = second.Reverse();
            string FullName = reverseFirst + reversSecond;
            Console.WriteLine(FullName);

        }
        else
        {
            string reverse = lines.Reverse();
            Console.WriteLine($"output" + reverse + lines);
        }

    }
}





