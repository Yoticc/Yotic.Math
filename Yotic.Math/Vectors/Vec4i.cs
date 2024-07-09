public struct Vec4i
{
    public Vec4i(int x, int y, int z, int w)
    {
        X = x;
        Y = y;
        Z = z;
        W = w;
    }

    public int X, Y, Z, W;

    public int Width { get => Z - X; set => Z = X + value; }
    public int Height { get => W - Y; set => W = Y + value; }

    public Vec2i LowerVec2i => new(X, Y);
    public Vec2i HigherVec2i => new(Z, W);
    public Vec2i SizeVec2i => new(Width, Height);

    public static implicit operator (int X, int Y, int Z, int W)(Vec4i from) => (from.X, from.Y, from.Z, from.W);
    public static implicit operator Vec4i((int X, int Y, int Z, int W) from) => new(from.X, from.Y, from.Z, from.W);
}