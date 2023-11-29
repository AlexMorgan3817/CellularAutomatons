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
			this.fieldBox = new System.Windows.Forms.PictureBox();
			this.Settings = new System.Windows.Forms.GroupBox();
			this.StopSim = new System.Windows.Forms.Button();
			this.AliveProb = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.StepSize = new System.Windows.Forms.NumericUpDown();
			this.StartSim = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Scale = new System.Windows.Forms.NumericUpDown();
			this.DoStep = new System.Windows.Forms.Button();
			this.RandomizeSetup = new System.Windows.Forms.Button();
			this.Apply = new System.Windows.Forms.Button();
			this.SizeY = new System.Windows.Forms.NumericUpDown();
			this.SizeX = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.fieldBox)).BeginInit();
			this.Settings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AliveProb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StepSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeX)).BeginInit();
			this.SuspendLayout();
			// 
			// fieldBox
			// 
			this.fieldBox.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.fieldBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldBox.Location = new System.Drawing.Point(0, 0);
			this.fieldBox.Name = "fieldBox";
			this.fieldBox.Size = new System.Drawing.Size(800, 450);
			this.fieldBox.TabIndex = 0;
			this.fieldBox.TabStop = false;
			this.fieldBox.Click += new System.EventHandler(this.GameField_Click);
			// 
			// Settings
			// 
			this.Settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Settings.Controls.Add(this.StopSim);
			this.Settings.Controls.Add(this.AliveProb);
			this.Settings.Controls.Add(this.label2);
			this.Settings.Controls.Add(this.StepSize);
			this.Settings.Controls.Add(this.StartSim);
			this.Settings.Controls.Add(this.label1);
			this.Settings.Controls.Add(this.Scale);
			this.Settings.Controls.Add(this.DoStep);
			this.Settings.Controls.Add(this.RandomizeSetup);
			this.Settings.Controls.Add(this.Apply);
			this.Settings.Controls.Add(this.SizeY);
			this.Settings.Controls.Add(this.SizeX);
			this.Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Settings.Location = new System.Drawing.Point(0, 373);
			this.Settings.Name = "Settings";
			this.Settings.Size = new System.Drawing.Size(800, 77);
			this.Settings.TabIndex = 1;
			this.Settings.TabStop = false;
			// 
			// StopSim
			// 
			this.StopSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StopSim.Enabled = false;
			this.StopSim.Location = new System.Drawing.Point(694, 43);
			this.StopSim.Name = "StopSim";
			this.StopSim.Size = new System.Drawing.Size(94, 29);
			this.StopSim.TabIndex = 13;
			this.StopSim.Text = "Stop";
			this.StopSim.UseVisualStyleBackColor = true;
			this.StopSim.Click += new System.EventHandler(this.StopSim_Click);
			// 
			// AliveProb
			// 
			this.AliveProb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.AliveProb.Location = new System.Drawing.Point(446, 9);
			this.AliveProb.Name = "AliveProb";
			this.AliveProb.Size = new System.Drawing.Size(73, 27);
			this.AliveProb.TabIndex = 12;
			this.AliveProb.Value = new decimal(new int[] {
            49,
            0,
            0,
            0});
			this.AliveProb.ValueChanged += new System.EventHandler(this.AliveProb_ValueChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(608, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Step Size";
			// 
			// StepSize
			// 
			this.StepSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StepSize.Location = new System.Drawing.Point(684, 10);
			this.StepSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.StepSize.Name = "StepSize";
			this.StepSize.Size = new System.Drawing.Size(104, 27);
			this.StepSize.TabIndex = 10;
			this.StepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.StepSize.ValueChanged += new System.EventHandler(this.StepSize_ValueChanged);
			// 
			// StartSim
			// 
			this.StartSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StartSim.Location = new System.Drawing.Point(594, 43);
			this.StartSim.Name = "StartSim";
			this.StartSim.Size = new System.Drawing.Size(94, 29);
			this.StartSim.TabIndex = 9;
			this.StartSim.Text = "Begin";
			this.StartSim.UseVisualStyleBackColor = true;
			this.StartSim.Click += new System.EventHandler(this.StartSim_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Scale";
			// 
			// Scale
			// 
			this.Scale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Scale.Location = new System.Drawing.Point(197, 38);
			this.Scale.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.Scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Scale.Name = "Scale";
			this.Scale.Size = new System.Drawing.Size(58, 27);
			this.Scale.TabIndex = 7;
			this.Scale.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.Scale.ValueChanged += new System.EventHandler(this.Scale_ValueChanged);
			// 
			// DoStep
			// 
			this.DoStep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.DoStep.Location = new System.Drawing.Point(346, 42);
			this.DoStep.Name = "DoStep";
			this.DoStep.Size = new System.Drawing.Size(94, 29);
			this.DoStep.TabIndex = 6;
			this.DoStep.Text = "Step";
			this.DoStep.UseVisualStyleBackColor = true;
			this.DoStep.Click += new System.EventHandler(this.DoStep_Click);
			// 
			// RandomizeSetup
			// 
			this.RandomizeSetup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.RandomizeSetup.Location = new System.Drawing.Point(346, 7);
			this.RandomizeSetup.Name = "RandomizeSetup";
			this.RandomizeSetup.Size = new System.Drawing.Size(94, 29);
			this.RandomizeSetup.TabIndex = 4;
			this.RandomizeSetup.Text = "Randomize setup";
			this.RandomizeSetup.UseVisualStyleBackColor = true;
			this.RandomizeSetup.Click += new System.EventHandler(this.RandomizeSetup_Click);
			// 
			// Apply
			// 
			this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Apply.Location = new System.Drawing.Point(76, 26);
			this.Apply.Name = "Apply";
			this.Apply.Size = new System.Drawing.Size(60, 29);
			this.Apply.TabIndex = 2;
			this.Apply.Text = "Apply";
			this.Apply.UseVisualStyleBackColor = true;
			this.Apply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// SizeY
			// 
			this.SizeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SizeY.Location = new System.Drawing.Point(12, 38);
			this.SizeY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.SizeY.Name = "SizeY";
			this.SizeY.Size = new System.Drawing.Size(58, 27);
			this.SizeY.TabIndex = 1;
			this.SizeY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// SizeX
			// 
			this.SizeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SizeX.Location = new System.Drawing.Point(12, 9);
			this.SizeX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.SizeX.Name = "SizeX";
			this.SizeX.Size = new System.Drawing.Size(58, 27);
			this.SizeX.TabIndex = 0;
			this.SizeX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Settings);
			this.Controls.Add(this.fieldBox);
			this.MaximizeBox = false;
			this.Name = "GameWindow";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.fieldBox)).EndInit();
			this.Settings.ResumeLayout(false);
			this.Settings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AliveProb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StepSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeX)).EndInit();
			this.ResumeLayout(false);

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
	}
}