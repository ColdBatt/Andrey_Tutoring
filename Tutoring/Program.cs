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
        var ls = new MyLinkedList<int>();
        ls.Add(1);
        ls.Add(2);
        ls.Add(3);

        foreach (var value in ls)
        {
            Console.WriteLine(value);
        }
    }
}
