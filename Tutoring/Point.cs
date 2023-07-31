namespace Tutoring;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"X == {X}   Y == {Y}";
    }

    public override bool Equals(object obj)
    {
        Point otherPoint;
        if (obj is Point)
            otherPoint = (Point)obj;
        else
        {
            return false;
        }

        return X == otherPoint.X && Y == otherPoint.Y;
        
    }
}