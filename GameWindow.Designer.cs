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
			epochs_label = new Label();
			jumpsize = new NumericUpDown();
			StopSim = new Button();
			AliveProb = new NumericUpDown();
			label2 = new Label();
			StepSize = new NumericUpDown();
			StartSim = new Button();
			label1 = new Label();
			Scale = new NumericUpDown();
			DoStep = new Button();
			RandomizeSetup = new Button();
			Apply = new Button();
			SizeY = new NumericUpDown();
			SizeX = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)fieldBox).BeginInit();
			Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)jumpsize).BeginInit();
			((System.ComponentModel.ISupportInitialize)AliveProb).BeginInit();
			((System.ComponentModel.ISupportInitialize)StepSize).BeginInit();
			((System.ComponentModel.ISupportInitialize)Scale).BeginInit();
			((System.ComponentModel.ISupportInitialize)SizeY).BeginInit();
			((System.ComponentModel.ISupportInitialize)SizeX).BeginInit();
			SuspendLayout();
			// 
			// fieldBox
			// 
			fieldBox.BackColor = SystemColors.WindowFrame;
			fieldBox.Dock = DockStyle.Fill;
			fieldBox.Location = new Point(0, 0);
			fieldBox.Name = "fieldBox";
			fieldBox.Size = new Size(1074, 450);
			fieldBox.SizeMode = PictureBoxSizeMode.StretchImage;
			fieldBox.TabIndex = 0;
			fieldBox.TabStop = false;
			fieldBox.Click += GameField_Click;
			fieldBox.Paint += pictureBox1_Paint;
			// 
			// Settings
			// 
			Settings.BackColor = SystemColors.ButtonHighlight;
			Settings.Controls.Add(epochs_label);
			Settings.Controls.Add(jumpsize);
			Settings.Controls.Add(StopSim);
			Settings.Controls.Add(AliveProb);
			Settings.Controls.Add(label2);
			Settings.Controls.Add(StepSize);
			Settings.Controls.Add(StartSim);
			Settings.Controls.Add(label1);
			Settings.Controls.Add(Scale);
			Settings.Controls.Add(DoStep);
			Settings.Controls.Add(RandomizeSetup);
			Settings.Controls.Add(Apply);
			Settings.Controls.Add(SizeY);
			Settings.Controls.Add(SizeX);
			Settings.Dock = DockStyle.Bottom;
			Settings.Location = new Point(0, 360);
			Settings.Name = "Settings";
			Settings.Size = new Size(1074, 90);
			Settings.TabIndex = 1;
			Settings.TabStop = false;
			Settings.Enter += Settings_Enter;
			// 
			// epochs_label
			// 
			epochs_label.Anchor = AnchorStyles.Bottom;
			epochs_label.AutoSize = true;
			epochs_label.Location = new Point(618, 23);
			epochs_label.Name = "epochs_label";
			epochs_label.Size = new Size(44, 20);
			epochs_label.TabIndex = 17;
			epochs_label.Text = "Scale";
			// 
			// jumpsize
			// 
			jumpsize.Anchor = AnchorStyles.Bottom;
			jumpsize.Location = new Point(539, 56);
			jumpsize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			jumpsize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			jumpsize.Name = "jumpsize";
			jumpsize.Size = new Size(73, 27);
			jumpsize.TabIndex = 16;
			jumpsize.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// StopSim
			// 
			StopSim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StopSim.Enabled = false;
			StopSim.Location = new Point(968, 56);
			StopSim.Name = "StopSim";
			StopSim.Size = new Size(94, 29);
			StopSim.TabIndex = 13;
			StopSim.Text = "Stop";
			StopSim.UseVisualStyleBackColor = true;
			StopSim.Click += StopSim_Click;
			// 
			// AliveProb
			// 
			AliveProb.Anchor = AnchorStyles.Bottom;
			AliveProb.Location = new Point(539, 23);
			AliveProb.Name = "AliveProb";
			AliveProb.Size = new Size(73, 27);
			AliveProb.TabIndex = 12;
			AliveProb.Value = new decimal(new int[] { 49, 0, 0, 0 });
			AliveProb.ValueChanged += AliveProb_ValueChanged;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(882, 25);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 11;
			label2.Text = "Step Size";
			// 
			// StepSize
			// 
			StepSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StepSize.Location = new Point(958, 23);
			StepSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			StepSize.Name = "StepSize";
			StepSize.Size = new Size(104, 27);
			StepSize.TabIndex = 10;
			StepSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
			StepSize.ValueChanged += StepSize_ValueChanged;
			// 
			// StartSim
			// 
			StartSim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			StartSim.Location = new Point(868, 56);
			StartSim.Name = "StartSim";
			StartSim.Size = new Size(94, 29);
			StartSim.TabIndex = 9;
			StartSim.Text = "Begin";
			StartSim.UseVisualStyleBackColor = true;
			StartSim.Click += StartSim_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(197, 28);
			label1.Name = "label1";
			label1.Size = new Size(44, 20);
			label1.TabIndex = 8;
			label1.Text = "Scale";
			// 
			// Scale
			// 
			Scale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Scale.Location = new Point(197, 51);
			Scale.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
			Scale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			Scale.Name = "Scale";
			Scale.ReadOnly = true;
			Scale.Size = new Size(58, 27);
			Scale.TabIndex = 7;
			Scale.Value = new decimal(new int[] { 1, 0, 0, 0 });
			Scale.ValueChanged += Scale_ValueChanged;
			// 
			// DoStep
			// 
			DoStep.Anchor = AnchorStyles.Bottom;
			DoStep.Location = new Point(439, 56);
			DoStep.Name = "DoStep";
			DoStep.Size = new Size(94, 29);
			DoStep.TabIndex = 6;
			DoStep.Text = "Step";
			DoStep.UseVisualStyleBackColor = true;
			DoStep.Click += DoStep_Click;
			// 
			// RandomizeSetup
			// 
			RandomizeSetup.Anchor = AnchorStyles.Bottom;
			RandomizeSetup.Location = new Point(439, 21);
			RandomizeSetup.Name = "RandomizeSetup";
			RandomizeSetup.Size = new Size(94, 29);
			RandomizeSetup.TabIndex = 4;
			RandomizeSetup.Text = "Randomize setup";
			RandomizeSetup.UseVisualStyleBackColor = true;
			RandomizeSetup.Click += RandomizeSetup_Click;
			// 
			// Apply
			// 
			Apply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Apply.Location = new Point(76, 39);
			Apply.Name = "Apply";
			Apply.Size = new Size(60, 29);
			Apply.TabIndex = 2;
			Apply.Text = "Apply";
			Apply.UseVisualStyleBackColor = true;
			Apply.Click += Apply_Click;
			// 
			// SizeY
			// 
			SizeY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			SizeY.Location = new Point(12, 51);
			SizeY.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
			SizeY.Name = "SizeY";
			SizeY.Size = new Size(58, 27);
			SizeY.TabIndex = 1;
			SizeY.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// SizeX
			// 
			SizeX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			SizeX.Location = new Point(12, 22);
			SizeX.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
			SizeX.Name = "SizeX";
			SizeX.Size = new Size(58, 27);
			SizeX.TabIndex = 0;
			SizeX.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// GameWindow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1074, 450);
			Controls.Add(Settings);
			Controls.Add(fieldBox);
			MaximizeBox = false;
			Name = "GameWindow";
			Text = "Form1";
			SizeChanged += GameWindow_SizeChanged;
			((System.ComponentModel.ISupportInitialize)fieldBox).EndInit();
			Settings.ResumeLayout(false);
			Settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)jumpsize).EndInit();
			((System.ComponentModel.ISupportInitialize)AliveProb).EndInit();
			((System.ComponentModel.ISupportInitialize)StepSize).EndInit();
			((System.ComponentModel.ISupportInitialize)Scale).EndInit();
			((System.ComponentModel.ISupportInitialize)SizeY).EndInit();
			((System.ComponentModel.ISupportInitialize)SizeX).EndInit();
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
	}
}