using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;
using NUnit.Framework;

namespace Tutoring;




internal class Program
{
    public static void Main(string[] args)
    {

        var users = new User[]
        {
            new User(1, "Oleg", "+7837298579238", 28, EducationType.University),
            new User(2, "Anton", "+78123123238", 48, EducationType.School),
            new User(3, "Andrey", "+783724657456238", 8, EducationType.University),
            new User(4, "Salimov", "+7837898679238", 80, EducationType.University)
        };
        var data = new DataHandler(users);
        
        var a = new MyLinkedList<int>();
        a.Add(1);
        a.Add(2);
        a.Add(3);
        a.Add(4);
        a.Add(5);
        a.Add(6);

        var b = a.Where(n => n % 2 == 0).ToArray();
        Console.WriteLine(new string(b.SelectMany(n => n.ToString() + " ").ToArray()));
    }

    public static bool IsPalindrome(string str)
    {
        string strReverse = String.Empty;
        
        for (int i = str.Length - 1; i <= 0; i--)
        {
            strReverse += str[i];
        }
        return str.Equals(strReverse);       
    }

    public static string UcString(string str)
    {
        var result = str[0].ToString().ToUpper();
        for (var i = 1; i < str.Length; i++)
        {
            if (str[i - 1] == ' ')
            {
                
            }
        }

        return default;
    }


    public static void Matrix(int n)
    {
        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Console.Write($"{i * j}\t");
            } 
            Console.Write($"{i * n}");
        }

        Console.WriteLine();
    }
    


}
