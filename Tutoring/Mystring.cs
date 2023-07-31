using System.Linq;

namespace Tutoring;

public class MyString
{

    private string _str;
    public MyString(string str)
    {
        _str = str;
    }

    public string Reverse()
    {
        var result = "";
        for (var i = _str.Length - 1; i >= 0; i--)
        {
            result += _str[i];
        }
        return result;
    }
}