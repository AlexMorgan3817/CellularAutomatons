namespace GameOfLife;

public abstract class CellAutomaton
{
	public int MX = 8;
	public int MY = 8;

	public int AliveProbability = 50;

	public int[,] Matrix = new int[8, 8];

	public CellAutomaton(int mX, int mY)
	{
		MX = mX;
		MY = mY;
		Matrix = new int[MX, MY];
	}
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
