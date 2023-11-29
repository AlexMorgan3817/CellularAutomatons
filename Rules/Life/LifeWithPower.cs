namespace GameOfLife.Rules;

public class LifeWithPower : CellAutomaton
{
	public LifeWithPower(int mX, int mY) : base(mX, mY)
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
		return count;
	}
	protected override int GetNextState(int x, int y)
	{
		int living = CountLivings(x, y);
		int state = Matrix[x, y];
		if(state >= 1)
		{
			living--;
			int dead = 8 - living;
			if(living < 4 || 6 < living)
				state -= 1;
			else
				state = Math.Clamp(state + 1, -10, 10);
			return Math.Clamp(state - dead, -10, 10);
		}
		else
			return Math.Clamp(state + living, -10, 10);
	}
	public override void Randomize(Random rand)
	{
		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
			{
				if(rand.Next(0, 101) > AliveProbability)
				{
					Matrix[x, y] = rand.Next(1, 11);
					continue;
				}
				Matrix[x, y] = rand.Next(-10, 1);

			}
	}
}
