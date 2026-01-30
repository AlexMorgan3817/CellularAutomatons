namespace GameOfLife.Rules;

public class LifeConway : Life
{
	public LifeConway(int mX, int mY) : base(mX, mY)
	{}
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
				if(Matrix[X, Y] == 1)
					count++;
			}
		return count;
	}
	public override int GetNextState(int x, int y)
	{
		int state = Matrix[x, y];
		int living = CountLivings(x, y);
		if(state >= 1)
			living--;
		if(living < 2 || 3 < living)
			return 0;
		else
		if(living == 3)
			return 1;
		return state;
	}
}

