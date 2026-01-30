using GameOfLife.Rules;

namespace GameOfLife;

public partial class GameWindow : Form
{
	private Random rand = new Random();
	private System.Windows.Forms.Timer loop = new System.Windows.Forms.Timer();

	private Bitmap p;
	private CellAutomaton Field; // TODO: Separate Matrix from CellAutomaton, let NextStep() be just strategy for processing them

	private Dictionary<string, Type> availableAutomatons = new Dictionary<string, Type>
	{
		{"Conway"                  , typeof(LifeConway)         }   ,
		{"Corridors"               , typeof(LifeCorridors)      }   ,
		{"Heat"                    , typeof(LifeHeat)           }   ,
		{"Islands"                 , typeof(LifeIslands)        }   ,
		{"WithPower"               , typeof(LifeWithPower)      }   ,
		{"BurntObsidian"           , typeof(LifeBurntObsidian)  }   ,
		{"Caves2"                  , typeof(LifeCaves2)         }   ,
		{"DepthMap"                , typeof(LifeDepthMap)       }   ,
		{"FiryWatercolour"         , typeof(LifeFiryWatercolour)}   ,
		{"Watercolour"             , typeof(LifeWatercolour)    }   ,
	};
	private int YSizeOfSettings = 77;

	public int epochs = 0;

	public int X { get { return (int)SizeX.Value; } set { SizeX.Value = value; } }
	public int Y { get { return (int)SizeY.Value; } set { SizeY.Value = value; } }
	public int W { get { return p.Width; } set { return; } }
	public int H { get { return p.Height; } set { return; } }

	public GameWindow()
	{
		InitializeComponent();
		InitAutomatonsSelector(AutomatonSelector);
		RebuildField(X, Y);
		loop.Tick += new EventHandler(GameLoop);

		SyncWindowSize();
	}
	private void InitAutomatonsSelector(ComboBox s)
	{
		if(s.Items.Count != 0)
			return;
		s.Items.Clear();
		foreach(var item in availableAutomatons.Keys)
		{
			s.Items.Add(item);
		}
		s.SelectedIndex = 0;
	}
	private void AutomatonSelector_SelectedIndexChanged(object sender, EventArgs e)
	{
		var s = (ComboBox)sender;

		var key = (string)s.Items[s.SelectedIndex];

		if(availableAutomatons.TryGetValue(key, out var type))
		{
			if(typeof(CellAutomaton).IsAssignableFrom(type))
			{
				var nF = (CellAutomaton)Activator.CreateInstance(type);
				if(Field != null)
					nF.Matrix = Field.Matrix;
				else
					nF.Matrix = CellAutomaton.ExtendArray(nF.Matrix, X, Y);
				Field = nF;
			}
		}

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
		Field.MX = x;
		Field.MY = y;
		SetEpochs(0);
		Field.AliveProbability = (int)AliveProb.Value;
		p = new(x, y);
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
		fieldBox.Image = p;
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
		Size = new Size(Math.Max(818, W), Math.Max(497, H) + YSizeOfSettings * 2);
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

	private void epochs_label_Click(object sender, EventArgs e)
	{

	}

	private void Scalex2_Click(object sender, EventArgs e)
	{
		X *= 2;
		Y *= 2;
	}

	private void DownScale2_Click(object sender, EventArgs e)
	{
		X /= 2;
		Y /= 2;
	}
}
