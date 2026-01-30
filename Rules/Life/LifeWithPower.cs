namespace GameOfLife.Rules;

public class LifeWithPower : Life
{
	public int max = 10;
	public int min = -10;

	public LifeWithPower(int mX, int mY) : base(mX, mY)
	{
	}
	public virtual int CountLivings(int x, int y)
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
	public override int GetNextState(int x, int y)
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
				state = Math.Clamp(state + 1, min, max);
			return Math.Clamp(state - dead, min, max);
		}
		else
			return Math.Clamp(state + living, min, max);
	}
	public override void Randomize(Random rand)
	{
		for(int x = 0; x < MX; x++)
			for(int y = 0; y < MY; y++)
			{
				if(rand.Next(0, 101) > AliveProbability)
					Matrix[x, y] = rand.Next(1, max + 1);
				else
					Matrix[x, y] = rand.Next(min, 1);
			}
	}
	protected virtual Color getNegativeColor(int m)
	{
		return Color.FromArgb(255, m * 5, 0, 0);
	}
	protected virtual Color getPositiveColor(int dx)
	{
		return Color.FromArgb(255, (int)255 * dx, (int)255 * dx, (int)0);
	}

	public override Color GetColor(int s)
	{
		int m = Math.Abs(s);
		if(s <= 0)
		{
			m = 10 - m;
			return getNegativeColor(m);
			// WATERCOLOR return Color.FromArgb(255, 0, m * 5, m * 10);
			// OBSIDIAN   return Color.FromArgb(255, m * 5, 0, 0);
		}
		else
		{
			var dx = m / this.max;
			return getPositiveColor(dx);
			// WATERCOLOR return Color.FromArgb(255, (int)(m * 5), (int)(m * 15), 0);
			// OBSIDIAN   return Color.FromArgb(255, 55 + (int)(m * 10), 0, 25 + (int)(m * 5));
		}
	}
}
