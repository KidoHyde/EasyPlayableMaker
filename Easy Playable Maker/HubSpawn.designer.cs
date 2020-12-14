namespace Easy_Playable_Maker
{
    partial class HubSpawn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubSpawn));
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Button();
            this.MakeFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaticMesh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefixText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(119, 202);
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(205, 20);
            this.PlayerNameText.TabIndex = 92;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(19, 205);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(89, 17);
            this.PlayerName.TabIndex = 71;
            this.PlayerName.Text = "Player Name";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(380, 263);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(149, 23);
            this.Output.TabIndex = 108;
            this.Output.Text = "Open Output Location";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // MakeFile
            // 
            this.MakeFile.Location = new System.Drawing.Point(55, 263);
            this.MakeFile.Name = "MakeFile";
            this.MakeFile.Size = new System.Drawing.Size(75, 23);
            this.MakeFile.TabIndex = 107;
            this.MakeFile.Text = "Create File";
            this.MakeFile.UseVisualStyleBackColor = true;
            this.MakeFile.Click += new System.EventHandler(this.MakeFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 24);
            this.label1.TabIndex = 109;
            this.label1.Text = "Note: Requires a gamemod file with the same name to be in the output folder";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.Roll,
            this.Pitch,
            this.Yaw,
            this.StaticMesh,
            this.Scale});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 113;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // Roll
            // 
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            // 
            // Pitch
            // 
            this.Pitch.HeaderText = "Pitch";
            this.Pitch.Name = "Pitch";
            // 
            // Yaw
            // 
            this.Yaw.HeaderText = "Yaw";
            this.Yaw.Name = "Yaw";
            // 
            // StaticMesh
            // 
            this.StaticMesh.HeaderText = "Static Mesh";
            this.StaticMesh.Name = "StaticMesh";
            // 
            // Scale
            // 
            this.Scale.HeaderText = "Scale";
            this.Scale.Name = "Scale";
            // 
            // PrefixText
            // 
            this.PrefixText.Location = new System.Drawing.Point(120, 174);
            this.PrefixText.Name = "PrefixText";
            this.PrefixText.Size = new System.Drawing.Size(205, 20);
            this.PrefixText.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Prefix";
            // 
            // HubSpawn
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(887, 331);
            this.Controls.Add(this.PrefixText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.MakeFile);
            this.Controls.Add(this.PlayerNameText);
            this.Controls.Add(this.PlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HubSpawn";
            this.Text = "Hub Spawn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button MakeFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PrefixText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaticMesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScaleWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
    }
}

