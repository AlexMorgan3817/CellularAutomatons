using GameOfLife;
using GameOfLife.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomatons.Rules;
public class LifeCaves2 : LifeWithPower
{
	public LifeCaves2(int mX, int mY) : base(mX, mY)
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
				//if(Matrix[X, Y] >= 1)
				count += Matrix[X, Y];
			}
		return count;
	}
	public override int GetNextState(int x, int y)
	{
		int living = CountLivings(x, y);
		int state = Matrix[x, y];
		return Math.Clamp(state + living, -10, 10);
	}
}