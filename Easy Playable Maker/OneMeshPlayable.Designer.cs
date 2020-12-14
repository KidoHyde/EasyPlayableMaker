namespace Easy_Playable_Maker
{
	partial class OneMeshPlayable
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneMeshPlayable));
            this.MakeFile = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.Label();
            this.Full = new System.Windows.Forms.Label();
            this.RGB = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.Eyes = new System.Windows.Forms.Label();
            this.Face = new System.Windows.Forms.Label();
            this.Ponytail = new System.Windows.Forms.Label();
            this.IceStatue = new System.Windows.Forms.Label();
            this.PlayerIcon = new System.Windows.Forms.Label();
            this.Exp = new System.Windows.Forms.Label();
            this.ExpComp = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PrefixText = new System.Windows.Forms.TextBox();
            this.IceStatueText = new System.Windows.Forms.TextBox();
            this.PlayerIconText = new System.Windows.Forms.TextBox();
            this.FullModelText = new System.Windows.Forms.TextBox();
            this.BText = new System.Windows.Forms.TextBox();
            this.GText = new System.Windows.Forms.TextBox();
            this.RText = new System.Windows.Forms.TextBox();
            this.BaseEXPText = new System.Windows.Forms.TextBox();
            this.PonytailText = new System.Windows.Forms.TextBox();
            this.FaceText = new System.Windows.Forms.TextBox();
            this.EyesText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PitchText = new System.Windows.Forms.TextBox();
            this.VoicePitch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeFile
            // 
            this.MakeFile.Location = new System.Drawing.Point(177, 394);
            this.MakeFile.Name = "MakeFile";
            this.MakeFile.Size = new System.Drawing.Size(75, 23);
            this.MakeFile.TabIndex = 0;
            this.MakeFile.Text = "Create File";
            this.MakeFile.UseVisualStyleBackColor = true;
            this.MakeFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(22, 41);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(89, 17);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "Player Name";
            // 
            // Prefix
            // 
            this.Prefix.AutoSize = true;
            this.Prefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prefix.Location = new System.Drawing.Point(45, 15);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(43, 17);
            this.Prefix.TabIndex = 3;
            this.Prefix.Text = "Prefix";
            // 
            // Full
            // 
            this.Full.AutoSize = true;
            this.Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full.Location = new System.Drawing.Point(11, 117);
            this.Full.Name = "Full";
            this.Full.Size = new System.Drawing.Size(110, 17);
            this.Full.TabIndex = 5;
            this.Full.Text = "Full Model Mesh";
            // 
            // RGB
            // 
            this.RGB.AutoSize = true;
            this.RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGB.Location = new System.Drawing.Point(13, 181);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(106, 17);
            this.RGB.TabIndex = 8;
            this.RGB.Text = "RGB Skin Color";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(57, 208);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 17);
            this.R.TabIndex = 9;
            this.R.Text = "R";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(57, 235);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(19, 17);
            this.G.TabIndex = 10;
            this.G.Text = "G";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(58, 261);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(17, 17);
            this.B.TabIndex = 11;
            this.B.Text = "B";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.Location = new System.Drawing.Point(364, 181);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(110, 17);
            this.Index.TabIndex = 12;
            this.Index.Text = "Material Indexes";
            // 
            // Eyes
            // 
            this.Eyes.AutoSize = true;
            this.Eyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eyes.Location = new System.Drawing.Point(400, 207);
            this.Eyes.Name = "Eyes";
            this.Eyes.Size = new System.Drawing.Size(39, 17);
            this.Eyes.TabIndex = 13;
            this.Eyes.Text = "Eyes";
            // 
            // Face
            // 
            this.Face.AutoSize = true;
            this.Face.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Face.Location = new System.Drawing.Point(400, 234);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(39, 17);
            this.Face.TabIndex = 14;
            this.Face.Text = "Face";
            // 
            // Ponytail
            // 
            this.Ponytail.AutoSize = true;
            this.Ponytail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ponytail.Location = new System.Drawing.Point(390, 260);
            this.Ponytail.Name = "Ponytail";
            this.Ponytail.Size = new System.Drawing.Size(58, 17);
            this.Ponytail.TabIndex = 15;
            this.Ponytail.Text = "Ponytail";
            // 
            // IceStatue
            // 
            this.IceStatue.AutoSize = true;
            this.IceStatue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IceStatue.Location = new System.Drawing.Point(365, 15);
            this.IceStatue.Name = "IceStatue";
            this.IceStatue.Size = new System.Drawing.Size(109, 17);
            this.IceStatue.TabIndex = 16;
            this.IceStatue.Text = "Ice Statue Mesh";
            // 
            // PlayerIcon
            // 
            this.PlayerIcon.AutoSize = true;
            this.PlayerIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIcon.Location = new System.Drawing.Point(380, 41);
            this.PlayerIcon.Name = "PlayerIcon";
            this.PlayerIcon.Size = new System.Drawing.Size(78, 17);
            this.PlayerIcon.TabIndex = 17;
            this.PlayerIcon.Text = "Player Icon";
            // 
            // Exp
            // 
            this.Exp.AutoSize = true;
            this.Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exp.Location = new System.Drawing.Point(366, 117);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(106, 17);
            this.Exp.TabIndex = 30;
            this.Exp.Text = "Base Character";
            // 
            // ExpComp
            // 
            this.ExpComp.AutoSize = true;
            this.ExpComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpComp.Location = new System.Drawing.Point(339, 90);
            this.ExpComp.Name = "ExpComp";
            this.ExpComp.Size = new System.Drawing.Size(160, 17);
            this.ExpComp.TabIndex = 27;
            this.ExpComp.Text = "Expression Components";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(534, 394);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(149, 23);
            this.Output.TabIndex = 43;
            this.Output.Text = "Open Output Location";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(117, 40);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(205, 20);
            this.PlayerNameText.TabIndex = 45;
            // 
            // PrefixText
            // 
            this.PrefixText.Location = new System.Drawing.Point(117, 14);
            this.PrefixText.Name = "PrefixText";
            this.PrefixText.Size = new System.Drawing.Size(205, 20);
            this.PrefixText.TabIndex = 46;
            // 
            // IceStatueText
            // 
            this.IceStatueText.Location = new System.Drawing.Point(483, 14);
            this.IceStatueText.Name = "IceStatueText";
            this.IceStatueText.Size = new System.Drawing.Size(205, 20);
            this.IceStatueText.TabIndex = 48;
            // 
            // PlayerIconText
            // 
            this.PlayerIconText.Location = new System.Drawing.Point(483, 40);
            this.PlayerIconText.Name = "PlayerIconText";
            this.PlayerIconText.Size = new System.Drawing.Size(205, 20);
            this.PlayerIconText.TabIndex = 47;
            // 
            // FullModelText
            // 
            this.FullModelText.Location = new System.Drawing.Point(117, 115);
            this.FullModelText.Name = "FullModelText";
            this.FullModelText.Size = new System.Drawing.Size(205, 20);
            this.FullModelText.TabIndex = 52;
            this.FullModelText.TextChanged += new System.EventHandler(this.FullModelText_TextChanged);
            // 
            // BText
            // 
            this.BText.Location = new System.Drawing.Point(117, 259);
            this.BText.Name = "BText";
            this.BText.Size = new System.Drawing.Size(205, 20);
            this.BText.TabIndex = 63;
            // 
            // GText
            // 
            this.GText.Location = new System.Drawing.Point(117, 233);
            this.GText.Name = "GText";
            this.GText.Size = new System.Drawing.Size(205, 20);
            this.GText.TabIndex = 62;
            // 
            // RText
            // 
            this.RText.Location = new System.Drawing.Point(117, 206);
            this.RText.Name = "RText";
            this.RText.Size = new System.Drawing.Size(205, 20);
            this.RText.TabIndex = 61;
            // 
            // BaseEXPText
            // 
            this.BaseEXPText.Location = new System.Drawing.Point(483, 115);
            this.BaseEXPText.Name = "BaseEXPText";
            this.BaseEXPText.Size = new System.Drawing.Size(205, 20);
            this.BaseEXPText.TabIndex = 64;
            // 
            // PonytailText
            // 
            this.PonytailText.Location = new System.Drawing.Point(483, 258);
            this.PonytailText.Name = "PonytailText";
            this.PonytailText.Size = new System.Drawing.Size(205, 20);
            this.PonytailText.TabIndex = 74;
            // 
            // FaceText
            // 
            this.FaceText.Location = new System.Drawing.Point(483, 232);
            this.FaceText.Name = "FaceText";
            this.FaceText.Size = new System.Drawing.Size(205, 20);
            this.FaceText.TabIndex = 73;
            // 
            // EyesText
            // 
            this.EyesText.Location = new System.Drawing.Point(483, 205);
            this.EyesText.Name = "EyesText";
            this.EyesText.Size = new System.Drawing.Size(205, 20);
            this.EyesText.TabIndex = 72;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(852, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 461);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.WordWrap = false;
            // 
            // TestBox
            // 
            this.TestBox.AcceptsReturn = true;
            this.TestBox.AcceptsTab = true;
            this.TestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBox.Location = new System.Drawing.Point(1008, 12);
            this.TestBox.Multiline = true;
            this.TestBox.Name = "TestBox";
            this.TestBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TestBox.Size = new System.Drawing.Size(170, 461);
            this.TestBox.TabIndex = 85;
            this.TestBox.WordWrap = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(705, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 84;
            this.checkBox1.Text = "Use Custom Voice Lines";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PitchText
            // 
            this.PitchText.Location = new System.Drawing.Point(483, 300);
            this.PitchText.Name = "PitchText";
            this.PitchText.Size = new System.Drawing.Size(205, 20);
            this.PitchText.TabIndex = 88;
            // 
            // VoicePitch
            // 
            this.VoicePitch.AutoSize = true;
            this.VoicePitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoicePitch.Location = new System.Drawing.Point(380, 302);
            this.VoicePitch.Name = "VoicePitch";
            this.VoicePitch.Size = new System.Drawing.Size(78, 17);
            this.VoicePitch.TabIndex = 87;
            this.VoicePitch.Text = "Voice Pitch";
            // 
            // OneMeshPlayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 482);
            this.Controls.Add(this.PitchText);
            this.Controls.Add(this.VoicePitch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PonytailText);
            this.Controls.Add(this.FaceText);
            this.Controls.Add(this.EyesText);
            this.Controls.Add(this.BaseEXPText);
            this.Controls.Add(this.BText);
            this.Controls.Add(this.GText);
            this.Controls.Add(this.RText);
            this.Controls.Add(this.FullModelText);
            this.Controls.Add(this.IceStatueText);
            this.Controls.Add(this.PlayerIconText);
            this.Controls.Add(this.PrefixText);
            this.Controls.Add(this.PlayerNameText);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.ExpComp);
            this.Controls.Add(this.PlayerIcon);
            this.Controls.Add(this.IceStatue);
            this.Controls.Add(this.Ponytail);
            this.Controls.Add(this.Face);
            this.Controls.Add(this.Eyes);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.Full);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.MakeFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OneMeshPlayable";
            this.Text = "One Mesh Playable";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button MakeFile;
		private System.Windows.Forms.Label PlayerName;
		private System.Windows.Forms.Label Prefix;
		private System.Windows.Forms.Label Full;
		private System.Windows.Forms.Label RGB;
		private System.Windows.Forms.Label R;
		private System.Windows.Forms.Label G;
		private System.Windows.Forms.Label B;
		private System.Windows.Forms.Label Index;
		private System.Windows.Forms.Label Eyes;
		private System.Windows.Forms.Label Face;
		private System.Windows.Forms.Label Ponytail;
		private System.Windows.Forms.Label IceStatue;
		private System.Windows.Forms.Label PlayerIcon;
		private System.Windows.Forms.Label Exp;
		private System.Windows.Forms.Label ExpComp;
		private System.Windows.Forms.Button Output;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.TextBox IceStatueText;
		private System.Windows.Forms.TextBox PlayerIconText;
		private System.Windows.Forms.TextBox PrefixText;
		private System.Windows.Forms.TextBox PlayerNameText;
		private System.Windows.Forms.TextBox FullModelText;
		private System.Windows.Forms.TextBox PonytailText;
		private System.Windows.Forms.TextBox FaceText;
		private System.Windows.Forms.TextBox EyesText;
		private System.Windows.Forms.TextBox BaseEXPText;
		private System.Windows.Forms.TextBox BText;
		private System.Windows.Forms.TextBox GText;
		private System.Windows.Forms.TextBox RText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox PitchText;
        private System.Windows.Forms.Label VoicePitch;
    }
}

