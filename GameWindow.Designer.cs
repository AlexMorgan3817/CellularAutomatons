namespace GameOfLife
{
	partial class GameWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			fieldBox = new PictureBox();
			Settings = new GroupBox();
			panel3 = new Panel();
			label2 = new Label();
			epochs_label = new Label();
			StartSim = new Button();
			StopSim = new Button();
			StepSize = new NumericUpDown();
			panel2 = new Panel();
			RandomizeSetup = new Button();
			AliveProb = new NumericUpDown();
			DoStep = new Button();
			jumpsize = new NumericUpDown();
			AutomatonSelector = new ComboBox();
			panel1 = new Panel();
			SizeX = new NumericUpDown();
			SizeY = new NumericUpDown();
			Apply = new Button();
			Scale = new NumericUpDown();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)fieldBox).BeginInit();
			Settings.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)StepSize).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AliveProb).BeginInit();
			((System.ComponentModel.ISupportInitialize)jumpsize).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SizeX).BeginInit();
			((System.ComponentModel.ISupportInitialize)SizeY).BeginInit();
			((System.ComponentModel.ISupportInitialize)Scale).BeginInit();
			SuspendLayout();
			// 
			// fieldBox
			// 
			fieldBox.BackColor = SystemColors.WindowFrame;
			fieldBox.Dock = DockStyle.Fill;
			fieldBox.Location = new Point(0, 0);
			fieldBox.Name = "fieldBox";
			fieldBox.Size = new Size(968, 296);
			fieldBox.SizeMode = PictureBoxSizeMode.StretchImage;
			fieldBox.TabIndex = 0;
			fieldBox.TabStop = false;
			fieldBox.Click += GameField_Click;
			fieldBox.Paint += pictureBox1_Paint;
			// 
			// Settings
			// 
			Settings.BackColor = SystemColors.ButtonHighlight;
			Settings.Controls.Add(panel3);
			Settings.Controls.Add(panel2);
			Settings.Controls.Add(panel1);
			Settings.Dock = DockStyle.Bottom;
			Settings.Location = new Point(0, 188);
			Settings.Name = "Settings";
			Settings.Size = new Size(968, 108);
			Settings.TabIndex = 1;
			Settings.TabStop = false;
			Settings.Enter += Settings_Enter;
			// 
			// panel3
			// 
			panel3.Controls.Add(label2);
			panel3.Controls.Add(epochs_label);
			panel3.Controls.Add(StartSim);
			panel3.Controls.Add(StopSim);
			panel3.Controls.Add(StepSize);
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(750, 23);
			panel3.Name = "panel3";
			panel3.Size = new Size(215, 82);
			panel3.TabIndex = 21;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(513, 23);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 11;
			label2.Text = "Step Size";
			// 
			// epochs_label
			// 
			epochs_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			epochs_label.AutoSize = true;
			epochs_label.Location = new Point(67, 19);
			epochs_label.Name = "epochs_label";
			epochs_label.Size = new Size(56, 20);
			epochs_label.TabIndex = 17;
			epochs_label.Text = "Epochs";
			epochs_label.Click += epochs_label_Click;
			// 
			// StartSim
			// 
			StartSim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StartSim.Location = new Point(3, 18);
			StartSim.Name = "StartSim";
			StartSim.Size = new Size(58, 29);
			StartSim.TabIndex = 9;
			StartSim.Text = "Begin";
			StartSim.UseVisualStyleBackColor = true;
			StartSim.Click += StartSim_Click;
			// 
			// StopSim
			// 
			StopSim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StopSim.Enabled = false;
			StopSim.Location = new Point(2, 48);
			StopSim.Name = "StopSim";
			StopSim.Size = new Size(59, 29);
			StopSim.TabIndex = 13;
			StopSim.Text = "Stop";
			StopSim.UseVisualStyleBackColor = true;
			StopSim.Click += StopSim_Click;
			// 
			// StepSize
			// 
			StepSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StepSize.Location = new Point(67, 48);
			StepSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			StepSize.Name = "StepSize";
			StepSize.Size = new Size(104, 27);
			StepSize.TabIndex = 10;
			StepSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
			StepSize.ValueChanged += StepSize_ValueChanged;
			// 
			// panel2
			// 
			panel2.Controls.Add(RandomizeSetup);
			panel2.Controls.Add(AliveProb);
			panel2.Controls.Add(DoStep);
			panel2.Controls.Add(jumpsize);
			panel2.Controls.Add(AutomatonSelector);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(220, 23);
			panel2.Name = "panel2";
			panel2.Size = new Size(745, 82);
			panel2.TabIndex = 20;
			// 
			// RandomizeSetup
			// 
			RandomizeSetup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			RandomizeSetup.Location = new Point(6, 48);
			RandomizeSetup.Name = "RandomizeSetup";
			RandomizeSetup.Size = new Size(94, 29);
			RandomizeSetup.TabIndex = 4;
			RandomizeSetup.Text = "Randomize setup";
			RandomizeSetup.UseVisualStyleBackColor = true;
			RandomizeSetup.Click += RandomizeSetup_Click;
			// 
			// AliveProb
			// 
			AliveProb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			AliveProb.Location = new Point(106, 50);
			AliveProb.Name = "AliveProb";
			AliveProb.Size = new Size(73, 27);
			AliveProb.TabIndex = 12;
			AliveProb.Value = new decimal(new int[] { 49, 0, 0, 0 });
			AliveProb.ValueChanged += AliveProb_ValueChanged;
			// 
			// DoStep
			// 
			DoStep.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			DoStep.Location = new Point(6, 19);
			DoStep.Name = "DoStep";
			DoStep.Size = new Size(94, 29);
			DoStep.TabIndex = 6;
			DoStep.Text = "Step";
			DoStep.UseVisualStyleBackColor = true;
			DoStep.Click += DoStep_Click;
			// 
			// jumpsize
			// 
			jumpsize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			jumpsize.Location = new Point(106, 21);
			jumpsize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			jumpsize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			jumpsize.Name = "jumpsize";
			jumpsize.Size = new Size(56, 27);
			jumpsize.TabIndex = 16;
			jumpsize.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// AutomatonSelector
			// 
			AutomatonSelector.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			AutomatonSelector.FormattingEnabled = true;
			AutomatonSelector.Location = new Point(185, 51);
			AutomatonSelector.Name = "AutomatonSelector";
			AutomatonSelector.Size = new Size(151, 28);
			AutomatonSelector.TabIndex = 18;
			AutomatonSelector.SelectedIndexChanged += AutomatonSelector_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.Controls.Add(SizeX);
			panel1.Controls.Add(SizeY);
			panel1.Controls.Add(Apply);
			panel1.Controls.Add(Scale);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(3, 23);
			panel1.Name = "panel1";
			panel1.Size = new Size(217, 82);
			panel1.TabIndex = 19;
			// 
			// SizeX
			// 
			SizeX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			SizeX.Location = new Point(9, 21);
			SizeX.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
			SizeX.Name = "SizeX";
			SizeX.Size = new Size(58, 27);
			SizeX.TabIndex = 0;
			SizeX.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// SizeY
			// 
			SizeY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			SizeY.Location = new Point(9, 50);
			SizeY.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
			SizeY.Name = "SizeY";
			SizeY.Size = new Size(58, 27);
			SizeY.TabIndex = 1;
			SizeY.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// Apply
			// 
			Apply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Apply.Location = new Point(73, 38);
			Apply.Name = "Apply";
			Apply.Size = new Size(60, 29);
			Apply.TabIndex = 2;
			Apply.Text = "Apply";
			Apply.UseVisualStyleBackColor = true;
			Apply.Click += Apply_Click;
			// 
			// Scale
			// 
			Scale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Scale.Location = new Point(139, 50);
			Scale.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
			Scale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			Scale.Name = "Scale";
			Scale.ReadOnly = true;
			Scale.Size = new Size(58, 27);
			Scale.TabIndex = 7;
			Scale.Value = new decimal(new int[] { 1, 0, 0, 0 });
			Scale.ValueChanged += Scale_ValueChanged;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(139, 27);
			label1.Name = "label1";
			label1.Size = new Size(44, 20);
			label1.TabIndex = 8;
			label1.Text = "Scale";
			// 
			// GameWindow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(968, 296);
			Controls.Add(Settings);
			Controls.Add(fieldBox);
			MaximizeBox = false;
			Name = "GameWindow";
			Text = "Form1";
			SizeChanged += GameWindow_SizeChanged;
			((System.ComponentModel.ISupportInitialize)fieldBox).EndInit();
			Settings.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)StepSize).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)AliveProb).EndInit();
			((System.ComponentModel.ISupportInitialize)jumpsize).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)SizeX).EndInit();
			((System.ComponentModel.ISupportInitialize)SizeY).EndInit();
			((System.ComponentModel.ISupportInitialize)Scale).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox fieldBox;
		private GroupBox Settings;
		private NumericUpDown SizeX;
		private NumericUpDown SizeY;
		private Button Apply;
		private Button RandomizeSetup;
		private Button DoStep;
		private Label label1;
		private NumericUpDown Scale;
		private Label label2;
		private NumericUpDown StepSize;
		private Button StartSim;
		private NumericUpDown AliveProb;
		private Button StopSim;
		private NumericUpDown jumpsize;
		private Label epochs_label;
		private ComboBox AutomatonSelector;
		private Panel panel1;
		private Panel panel3;
		private Panel panel2;
	}
}