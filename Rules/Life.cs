namespace GameOfLife.Rules;

public abstract class Life : CellAutomaton
{
	public Life() : base() { }

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
