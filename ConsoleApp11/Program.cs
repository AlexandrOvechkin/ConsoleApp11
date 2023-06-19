﻿using Microsoft.VisualBasic.FileIO;
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
        if(matches.Count > 0 )
        {
            foreach(Match mat in matches)
            {
                Console.WriteLine(@"Ошибка,недопустимый символ:" + mat.Value) ;
            }
            
        }
        else
        {
           if (lines.Length%2 == 0)
           {
                int m = lines.Length/2;
                string first = lines[..m];
                string second = lines[m..];
                string reverseFirst = first.Reverse();
                string reversSecond = second.Reverse();           
                string FullName = reverseFirst + reversSecond;
                Console.WriteLine($"output:" + FullName);
                var arr = FullName.ToCharArray();

                var qu = arr.Distinct();

                foreach (var z in qu)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", z, FullName.Count(c => c == z));
                }
            }     
           else
           {
                string reverse = lines.Reverse()+lines;                 
                Console.WriteLine($"output:" + reverse);
                var arr = reverse.ToCharArray();

                var qu = arr.Distinct();

                foreach (var z in qu)
                {
                    Console.WriteLine("{0} повторяется {1} раз(а)", z, reverse.Count(c => c == z));
                }
            }
        }                            
    }             
}    


