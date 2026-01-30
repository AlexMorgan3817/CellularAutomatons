using GameOfLife;
using GameOfLife.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomatons.Rules;
public class LifeWatercolour : LifeWithPower
{
	public LifeWatercolour(int mX, int mY) : base(mX, mY)
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
		if(state >= 0)
		{
			if(state >= 2)
			{
				if(living > 4)
					return Math.Clamp(state + living, -10, 10);
			}
			if(living >= 0)
				return Math.Clamp(state * living, -10, 10);
			if(living < 0)
				return Math.Clamp(state + living, -10, 10);
		}
		return Math.Clamp(state + living, -10, 10);
	}
	public override Color GetColor(int s)
	{
		int m = Math.Abs(s);
		if(s <= 0)
		{
			m = 10 - m;
			return Color.FromArgb(255, 0, m * 5, m * 10);
			// OBSIDIAN   return Color.FromArgb(255, m * 5, 0, 0);
		}
		else
		{
			int dx = (max - min) / (max);
			return Color.FromArgb(255, (int)(m * 5), (int)(m * 15), 0);
			// OBSIDIAN   return Color.FromArgb(255, 55 + (int)(m * 10), 0, 25 + (int)(m * 5));
		}
	}
}
