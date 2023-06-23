using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

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
        Regex newReg = new Regex(@"[^a-z]", RegexOptions.None);
        MatchCollection matches = newReg.Matches(lines);
        if (matches.Count > 0)
        {
            foreach (Match mat in matches)
            {
                Console.WriteLine(@"Ошибка,недопустимый символ:" + mat.Value);
            }
        }
        else
        {
            int m = lines.Length / 2;
            string first = lines[..m];
            string second = lines[m..];
            string reverseFirst = first.Reverse();
            string reversSecond = second.Reverse();
            string FullName = reverseFirst + reversSecond;
            var arr = FullName.ToCharArray();
            var qu = arr.Distinct();
            string reverse = lines.Reverse() + lines;
            Console.WriteLine("===================================================================");
            if (lines.Length % 2 == 0)
            {
                Console.WriteLine($"output:" + FullName);
                Console.WriteLine("===================================================================");
                foreach (var z in qu)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", z, FullName.Count(c => c == z));
                }
                Console.WriteLine("===================================================================");
                var result1 = Regex.Matches(FullName, @"[aeiouy]+\w*[aeiouy]", RegexOptions.IgnoreCase);
                foreach (var item in result1)
                {
                    Console.WriteLine($"substring:" + item);


                }
            }
            else
            {

                Console.WriteLine($"output:" + reverse);
                foreach (var z in qu)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", z, reverse.Count(c => c == z));
                }

                Console.WriteLine("===================================================================");
                var result = Regex.Matches(reverse, @"[aeiouy]+\w*[aeiouy]", RegexOptions.IgnoreCase);
                foreach (var item in result)
                {
                    Console.WriteLine($"substring:" + item);
                }
            }
        }
    }
}







