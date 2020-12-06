using Easy_Playable_Maker.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Easy_Playable_Maker
{
	public partial class MainView : Form
    {

        public MainView()
        {
            InitializeComponent();

            var UpdateChk = new UpdateChecker(BuildData.CurrentVersion, BuildData.UpdateUrl, new Action(() => {
                this.Invoke(new MethodInvoker(() =>
                {
                    var dialog = MessageBox.Show(this, "New version of Easy Playable Maker is avaiable!\nDownload now?", "Update checker", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start(BuildData.ReleasesPage);
                    }
                }));
            }));
            UpdateChk.CheckForUpdatesAsync();
        }

        private void PlayerSwapper_Load(object sender, EventArgs e)
        {

        }


        private void Player_Click(object sender, EventArgs e)
        {
            var Player = new MainPlayableWindow();
            Player.Show();
        }

        private void PlayerSwapper_Click(object sender, EventArgs e)
        {
            var PlayerSwapper = new PlayerSwapper();
            PlayerSwapper.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KidoHyde/EasyPlayableMaker");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var HubSpawn = new HubSpawn();
            HubSpawn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var OneMeshPlayable = new OneMeshPlayable();
            OneMeshPlayable.Show();
        }

        private void ExpressionComponent_Click(object sender, EventArgs e)
        {
            var ExpressionComponent = new ExpressionComponent();
            ExpressionComponent.Show();
        }
    }
}
