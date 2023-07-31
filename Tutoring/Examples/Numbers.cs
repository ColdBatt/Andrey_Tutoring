using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tutoring;


public class Numbers : IEnumerable<int>
{
    private int[] _numbers;
    private int _count;

    public Numbers(int count)
    {
        _numbers = Enumerable.Range(1, 10).ToArray();
        _count = count;
    }

    public int[] GetValues()
    {
        var result = new int[_count];
        for (int i = 0; i < _count; i++)
        {
            result[i] = _numbers[i];
        }

        return result;
    }


    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _numbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}