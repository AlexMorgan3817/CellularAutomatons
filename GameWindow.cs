using CellularAutomatons.Rules;
using GameOfLife.Rules;

namespace GameOfLife;

public partial class GameWindow : Form
{
	private Random rand = new Random();
	private System.Windows.Forms.Timer loop = new System.Windows.Forms.Timer();

	private ScaledBitmap p;
	private CellAutomaton Field;

	private int YSizeOfSettings = 77;

	public int epochs = 0;

	public GameWindow()
	{
		InitializeComponent();
		int x = (int)SizeX.Value;
		int y = (int)SizeY.Value;
		RebuildField(x, y);
		loop.Tick += new EventHandler(GameLoop);
		SyncWindowSize();
	}
	private void pictureBox1_Paint(object sender, PaintEventArgs e)
	{
		PictureBox pb = (PictureBox)sender;
		if(pb.Image == null)
			return;
		var g = e.Graphics;
		g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
		g.DrawImage(
			pb.Image,
			new Rectangle(0, 0, pb.Width, pb.Height),
			new Rectangle(0, 0, pb.Image.Width, pb.Image.Height),
			GraphicsUnit.Pixel
		);
	}


	private Color GetColor(int s)
	{
		return Field.GetColor(s);
	}

	private void RebuildField(int x, int y)
	{
		Field = new LifeCaves2(x, y);
		SetEpochs(0);
		Field.AliveProbability = (int)AliveProb.Value;
		p = new(x, y, (int)Scale.Value);
		UpdateField();
	}
	public void MakeStep()
	{
		makeStep((int)jumpsize.Value, false);
		UpdateField();
	}
	public void makeStep(int v = 1, bool update = true)
	{
		for(var i = 0; i < v; i++)
			Field.Process();
		if(update)
			UpdateField();
		SetEpochs(epochs + v);
		epochs_label.Text = epochs.ToString();
	}
	private void SetEpochs(int v)
	{
		epochs = v;
		epochs_label.Text = epochs.ToString();
	}
	private void GameLoop(Object myObject, EventArgs myEventArgs) => MakeStep();

	private void UpdateField()
	{
		for(int x = 0; x < Field.MX; x++)
			for(int y = 0; y < Field.MY; y++)
				p.SetPixel(x, y, GetColor(Field.Matrix[x, y]));
		fieldBox.Image = p.src;
	}

	public void RandomizeField()
	{
		SetEpochs(0);
		Field.Randomize(rand);
		UpdateField();
	}

	#region UI
	public void SyncWindowSize()
	{
		Size = new Size(Math.Max(818, p.src.Width), Math.Max(497, p.src.Height) + YSizeOfSettings * 2);
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
		//SyncWindowSize();
	}
	private void GameField_Click(object sender, EventArgs e)
	{
		ToogleSettings();
	}
	private void RandomizeSetup_Click(object sender, EventArgs e)
	{
		RandomizeField();
		//SyncWindowSize();
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
		StopSim_Click(sender, e);
		loop.Interval = (int)Math.Max(StepSize.Value, 1);
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

	private void GameWindow_SizeChanged(object sender, EventArgs e)
	{
		//fieldBox.Width;
	}

	private void Settings_Enter(object sender, EventArgs e)
	{

	}
}
