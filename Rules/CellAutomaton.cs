namespace GameOfLife;

public abstract class CellAutomaton
{
	//public int MX = 10;
	//public int MY = 10;
	public static T[,] ExtendArray<T>(T[,] a, int nX, int nY)
	{
		var X = Math.Clamp(a.GetLength(0), 0, nX);
		var Y = Math.Clamp(a.GetLength(1), 0, nY);

		var nM = new T[nX, nY];
		for(var x = 0; x < X; x++)
			for(var y = 0; y < Y; y++)
				nM[x, y] = a[x, y];
		return nM;
	}

	public int MX
	{
		get {return Matrix.GetLength(0);}
		set
		{
			Matrix = ExtendArray(Matrix, value, MY);
		}
	}
	public int MY
	{
		get{return Matrix.GetLength(1);}
		set
		{
			Matrix = ExtendArray(Matrix, MX, value);
		}
	}

	public int AliveProbability = 50;

	public int[,] Matrix = new int[1, 1];

	public int GetState(int x, int y)
	{
		if(x < 0 || y < 0 || x >= MX || y >= MY)
		{
			return 0;
		}
		return Matrix[x, y];
	}

	public abstract int GetNextState(int x, int y);
	public abstract void Randomize(Random rand);
	public virtual Color GetColor(int s)
	{
		if(s >= 1)
			return Color.Green;
		return Color.Black;
	}
	public void Process()
	{
		int[,] nextStates = new int[MX, MY];
		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
				nextStates[x, y] = GetNextState(x, y);

		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
				Matrix[x, y] = nextStates[x, y];
	}
}
