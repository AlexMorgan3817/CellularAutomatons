using GameOfLife;
using GameOfLife.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomatons.Rules;
public class LifeBurntObsidian : LifeWithPower
{
	public LifeBurntObsidian(int mX, int mY) : base(mX, mY)
	{
	}
	public override int CountLivings(int x, int y)
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
			if(state >= 8 && living > 4)
				return Math.Clamp(state - 4 * living, -10, 10);
			return Math.Clamp(state + 2*living - 9, -10, 10);
		}
		else
			return Math.Clamp(state + living, -10, 10);
	}
	protected override Color getNegativeColor(int m)
	{
		return Color.FromArgb(255, m * 5, 0, 0);
	}
	protected override Color getPositiveColor(int dx)
	{
		return Color.FromArgb(255, 55 + (int)(dx * 10), 0, 25 + (int)(dx * 5));
	}
}