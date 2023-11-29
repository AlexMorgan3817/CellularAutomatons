public class ScaledBitmap
{
	public readonly Bitmap src;
	public readonly int Scale;
	public readonly int X, Y;

	public ScaledBitmap(int _x, int _y, int scale = 1)
	{
		X = _x;
		Y = _y;
		Scale = scale;
		src = new Bitmap(X * Scale, Y * Scale);
	}

	public void SetPixel(int x, int y, Color c)
	{
		for(int i = 0; i < Scale; i++)
			for(int j = 0; j < Scale; j++)
				src.SetPixel(x * Scale + i, y * Scale + j, c);
	}
}
