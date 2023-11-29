using GameOfLife.Rules;

namespace GameOfLife;

public partial class GameWindow : Form
{
	private Random rand = new Random();
	private System.Windows.Forms.Timer loop = new System.Windows.Forms.Timer();

	private ScaledBitmap p;
	private LifeConway Field;
	private bool UsingLifeWithPower = false;

	public int YSizeOfSettings = 77;

	public GameWindow()
	{
		InitializeComponent();
		int x = (int)SizeX.Value;
		int y = (int)SizeY.Value;
		Field = new(x, y);
		p = new(x, y, (int)Scale.Value);
		UpdateField();
		loop.Tick += new EventHandler(GameLoop);
	}
	private void RebuildField(int x, int y)
	{
		Field = new(x, y);
		p = new(x, y, (int)Scale.Value);
		UpdateField();
	}
	public void MakeStep()
	{
		Field.Process();
		UpdateField();
	}
	private void GameLoop(Object myObject, EventArgs myEventArgs) => MakeStep();

	private Color GetColor(int s)
	{
		if(UsingLifeWithPower)
		{
			int m = Math.Abs(s);
			if(s <= 0)
			{
				m = 10 - m;
				return Color.FromArgb(255, m * 5, m * 5, m * 5);
			}
			else
				return Color.FromArgb(255, 0, 55 + (int)(m * 20), 0);
		}
		else
		{
			if(s == 1)
				return Color.Green;
			return Color.Black;
		}
	}
	private void UpdateField()
	{
		for(int x = 0; x < Field.MX; x++)
			for(int y = 0; y < Field.MY; y++)
				p.SetPixel(x, y, GetColor(Field.Matrix[x, y]));
		fieldBox.Image = p.src;
	}

	public void RandomizeField()
	{
		Field.Randomize(rand);
		
		/*Field.Matrix[1, 3] = 1;
		Field.Matrix[2, 4] = 1;
		Field.Matrix[3, 2] = 1;
		Field.Matrix[3, 3] = 1;
		Field.Matrix[3, 4] = 1;*/

		UpdateField();
	}

	#region UI
	public void SyncWindowSize()
	{
		Size = new Size(Math.Max(818, p.src.Width), Math.Max(497, p.src.Height) + YSizeOfSettings*2);
	}

	public void ToogleSettings()
	{
		if(Settings.Size.Height > 0)
		{
			YSizeOfSettings = Settings.Size.Height;
			Settings.Size = new Size(Settings.Size.Width, 0);
			return;
		}
		Settings.Size = new Size(Settings.Size.Width, YSizeOfSettings);
	}
	private void Apply_Click(object sender, EventArgs e)
	{
		RebuildField((int)SizeX.Value, (int)SizeY.Value);
		SyncWindowSize();
	}
	private void GameField_Click(object sender, EventArgs e)
	{
		ToogleSettings();
	}
	private void RandomizeSetup_Click(object sender, EventArgs e)
	{
		RandomizeField();
		SyncWindowSize();
	}
	private void DoStep_Click(object sender, EventArgs e)
	{
		MakeStep();
	}
	private void StartSim_Click(object sender, EventArgs e)
	{
		loop.Interval = (int)StepSize.Value;
		loop.Start();
		StartSim.Enabled = false;
		StopSim.Enabled = true;
		DoStep.Enabled = false;
		RandomizeSetup.Enabled = false;
		Apply.Enabled = false;
	}

	private void StopSim_Click(object sender, EventArgs e)
	{
		loop.Stop();
		StartSim.Enabled = true;
		StopSim.Enabled = false;
		DoStep.Enabled = true;
		RandomizeSetup.Enabled = true;
		Apply.Enabled = true;
	}
	private void StepSize_ValueChanged(object sender, EventArgs e)
	{
		loop.Interval = (int)StepSize.Value;
	}

	private void Scale_ValueChanged(object sender, EventArgs e)
	{
		p = new(p.X, p.Y, (int)Scale.Value);
		UpdateField();
	}
	private void AliveProb_ValueChanged(object sender, EventArgs e)
	{
		Field.AliveProbability = (int)AliveProb.Value;
	}
	#endregion
}
