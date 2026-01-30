namespace GameOfLife.Rules;
internal class LifeHeat : LifeWithPower
{
	public int OutTemp = -272;
	public float alpha = .3f;
	public float beta = .3f;
	public float gamma = .1f;

	public LifeHeat() : base()
	{
		min = -273;
		max = 1000;
	}
	public override int GetNextState(int x, int y)
	{
		int T = GetState(x, y);
		int T1 = GetState(x - 1, y);
		int T2 = GetState(x + 1, y);
		int T3 = GetState(x, y - 1);
		int T4 = GetState(x, y + 1);
		//return (int)Math.Round(Math.Clamp(alpha * T + (T1 + T2 + T3 + T4)*(1 - alpha)/4, min, max));
		return (int)Math.Round(Math.Clamp(alpha * T + (T1 + T2 + T3 + T4)*(beta)/4 + (gamma) * OutTemp, min, max));
	}
	public override void Randomize(Random rand)
	{
		for(int x = 50; x < 70; x++)
			for(int y = 50; y < 70; y++)
				Matrix[x, y] = -60;
		for(int x = 10; x < 40; x++)
			for(int y = 10; y < 40; y++)
				Matrix[x, y] = 500;
		/*
				for(int x = 0; x < MX; x++)
					for(int y = 0; y < MY; y++)
					{
						if(rand.Next(0, 101) > AliveProbability)
							Matrix[x, y] = rand.Next(max / 2, max + 1);
						else
							Matrix[x, y] = rand.Next(min, max/2);
					}
		*/
	}
	public override Color GetColor(int s)
	{
		float dx = (float)(s + Math.Abs(min)) / (max + Math.Abs(min));
		float r = 255 * dx;
		float g = 255 * dx / 4;
		float b = (Math.Sign(s) == 1) ? 0 : (dx * 255);
		r = (Math.Sign(s) == 1) ? r : Math.Clamp(r - 100, 0, 255);
		g = (Math.Sign(s) == 1) ? b : Math.Clamp(g - 100, 0, 255);
		return Color.FromArgb(255, (int)r, (int)g, (int)b);
	}
}
