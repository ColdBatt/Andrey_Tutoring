using System;
using System.Collections;
using System.Collections.Generic;

namespace Tutoring;

public static class Practice
{
    public static string CastObjectToString(object item)
    {
        // На вход подается объект, скастить к стрингу, если не получиться выбросить ArgumentException
         var result = item as string;
         if (result == null)
             throw new ArgumentException("ХУЙНЯ А НЕ СТРОКА");
         return result;
        
        if (item is string str)
            return str;
        throw new ArgumentException("ХУЙНЯ А НЕ СТРОКА");

    }
    
    public static IEnumerable<string> F()
    {
        var arr = new[] { "a", "b", "c" };
        foreach (var s in arr)
        {
            yield return s;
        }
        yield return "";
    }
}