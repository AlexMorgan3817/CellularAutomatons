namespace GameOfLife.Rules;

public class LifeIslands : Life
{
	public int MergingCoefficient = 1;
	public LifeIslands(int mX, int mY) : base(mX, mY)
	{
	}
	protected int CountLivings(int x, int y)
	{
		int count = 0;
		for(int i = -1; i <= 1; i++)
			for(int j = -1; j <= 1; j++)
			{
				int X = x + i;
				int Y = y + j;
				if(MX <= X || MY <= Y || X < 0 || Y < 0)
					continue;
				if(Matrix[X, Y] >= 1)
					count++;
			}
		/* 1 : (-2, 0); 2 : (0, -2); 3 : (0, 2); 4 : (2, 0) */
		for(int i = -2; i <= 2; i += 4)
		{
			int X = x;
			int Y = y + i;
			if(MX > X && MY > Y && X >= 0 && Y >= 0)
				if(Matrix[X, Y] >= 1)
					count++;
			X = x + i;
			Y = y;
			if(MX > X && MY > Y && X >= 0 && Y >= 0)
				if(Matrix[X, Y] >= 1)
					count++;
		}
		return count;
	}
	public override int GetNextState(int x, int y)
	{
		int living = CountLivings(x, y);
		int state = Matrix[x, y];
		if(state >= 1)
		{
			living--;
			int dead = 8 - living;
			if(living < 6)
				return state - 1;
			else
				state = state + 1;
			return Math.Clamp(state - dead, -10, 10);
		}
		else
			return Math.Clamp(state - 1 + living / MergingCoefficient, -10, 10);
	}
	public override void Randomize(Random rand)
	{
		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
			{
				if(x == 0 || y == 0 || x == MX-1 || y == MY-1)
				{
					Matrix[x, y] = 10;
					continue;
				}
				if(rand.Next(0, 101) > AliveProbability)
				{
					Matrix[x, y] = rand.Next(1, 11);
					continue;
				}
				Matrix[x, y] = rand.Next(-10, 1);

			}
	}
}