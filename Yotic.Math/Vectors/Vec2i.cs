public struct Vec2i
{
    public Vec2i(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X, Y;

    public static implicit operator (int X, int Y)(Vec2i from) => (from.X, from.Y);
    public static implicit operator Vec2i((int X, int Y) from) => new(from.X, from.Y);
}