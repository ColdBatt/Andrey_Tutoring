using System;
using System.Runtime.CompilerServices;

namespace Tutoring;

public interface ITransport
{
    public void Move();
}

public class Car : ITransport
{
    public void Move()
    {
        Console.WriteLine("Машина едет");
    }

    public void Stop()
    {
        Console.WriteLine("Машина остановилась");
    }
}

public class Ship : ITransport
{
    public void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
    public void Stop()
    {
        Console.WriteLine("Кораль остановился");
    }
}
