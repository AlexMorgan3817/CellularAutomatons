namespace GameOfLife.Rules;

public class LifeCorridors : Life
{
	public LifeCorridors(int mX, int mY) : base(mX, mY)
	{}
	private int GetHV(int x, int y, int range)
	{
		int count = 0;
		for(int j = -range; j <= range; j += range)
		{
			int X = x;
			int Y = y + j;
			if(MX <= X || MY <= Y || X < 0 || Y < 0)
				continue;
			if(Matrix[X, Y] == 1)
				count++;
			X = x + j;
			Y = y;
			if(MX <= X || MY <= Y || X < 0 || Y < 0)
				continue;
			if(Matrix[X, Y] == 1)
				count++;
		}
		return count;
	}
	private int GetH(int x, int y, int range)
	{
		int count = 0;
		if(y + range < MY && Matrix[x, y + range] == 1)
			count++;
		if(y - range > 0 && Matrix[x, y - range] == 1)
			count++;
		return count;
	}
	private int GetV(int x, int y, int range)
	{
		int count = 0;
		if(x + range < MX && Matrix[x + range, y] == 1)
			count++;
		if(x - range > 0 && Matrix[x - range, y] == 1)
			count++;
		return count;
	}

	private int GetDiagonal(int x, int y)
	{
		int count = 0;
		for(int j = -1; j <= 1; j += 2)
		{
			int X = x + j;
			int Y = y + j;
			if(MX <= X || MY <= Y || X < 0 || Y < 0)
				continue;
			if(Matrix[X, Y] == 1)
				count++;
			X = x - j;
			Y = y - j;
			if(MX <= X || MY <= Y || X < 0 || Y < 0)
				continue;
			if(Matrix[X, Y] == 1)
				count++;
		}
		return count;
	}
	protected override int GetNextState(int x, int y)
	{
		if(x == 0 || y == 0 || x == MX - 1 || y == MY - 1)
			return 1;
		int living1 = GetHV(x, y, 1);
		int living2 = GetHV(x, y, 2);
		int l1X = GetH(x, y, 1);
		int l1Y = GetV(x, y, 1);
		int l2X = GetH(x, y, 2);
		int l2Y = GetV(x, y, 2);
		int livdiag = GetDiagonal(x, y);
		if(Matrix[x, y] == 1)
		{
			if(l1X == 2 && l1Y == 2)
				return 0;
			if(1 <= living1 && living1 <= 4 && livdiag == 0)
				return 1;
			return 0;
		}
		else
		{
			if((l2X == 2 && l2Y != 2) || (l2X != 2 && l2Y == 2))
				return 1;
			if(livdiag == 0)
			{
				if(living1 <= 4 && living1 >= 1 && living2 >= 2)
					return 1;
			}
			return 0;
		}

	}
	public override void Randomize(Random rand)
	{
		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
			{
				if(rand.Next(0, 101) > AliveProbability)
				{
					Matrix[x, y] = 1;
					continue;
				}
				Matrix[x, y] = 0;

			}
	}
}
