namespace Easy_Playable_Maker
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.Player = new System.Windows.Forms.Button();
            this.PlayerSwapper = new System.Windows.Forms.Button();
            this.githubpage = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExpressionComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.Location = new System.Drawing.Point(33, 57);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(158, 64);
            this.Player.TabIndex = 0;
            this.Player.Text = "Make A New Player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // PlayerSwapper
            // 
            this.PlayerSwapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSwapper.Location = new System.Drawing.Point(33, 127);
            this.PlayerSwapper.Name = "PlayerSwapper";
            this.PlayerSwapper.Size = new System.Drawing.Size(158, 73);
            this.PlayerSwapper.TabIndex = 1;
            this.PlayerSwapper.Text = "Make A New Player Swapper";
            this.PlayerSwapper.UseVisualStyleBackColor = true;
            this.PlayerSwapper.Click += new System.EventHandler(this.PlayerSwapper_Click);
            // 
            // githubpage
            // 
            this.githubpage.AutoSize = true;
            this.githubpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubpage.Location = new System.Drawing.Point(12, 360);
            this.githubpage.Name = "githubpage";
            this.githubpage.Size = new System.Drawing.Size(194, 24);
            this.githubpage.TabIndex = 2;
            this.githubpage.TabStop = true;
            this.githubpage.Text = "View the github Page!";
            this.githubpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Spawn an item in the Hub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "One Mesh Playable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExpressionComponent
            // 
            this.ExpressionComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressionComponent.Location = new System.Drawing.Point(197, 127);
            this.ExpressionComponent.Name = "ExpressionComponent";
            this.ExpressionComponent.Size = new System.Drawing.Size(158, 73);
            this.ExpressionComponent.TabIndex = 5;
            this.ExpressionComponent.Text = "Expression Component";
            this.ExpressionComponent.UseVisualStyleBackColor = true;
            this.ExpressionComponent.Click += new System.EventHandler(this.ExpressionComponent_Click);
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this.ExpressionComponent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.githubpage);
            this.Controls.Add(this.PlayerSwapper);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.PlayerSwapper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.Button PlayerSwapper;
        private System.Windows.Forms.LinkLabel githubpage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExpressionComponent;
    }
}

