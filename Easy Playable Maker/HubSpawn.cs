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
	public partial class HubSpawn : Form
    {

        public HubSpawn()
        {
            InitializeComponent();
        }

        private void MakeFile_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //It's a step in the right direction however not what I'm looking for specifically
            string pathString = System.IO.Path.Combine(path, "Output");
            System.IO.Directory.CreateDirectory(pathString);

            if (String.IsNullOrEmpty(PrefixText.Text)) { PrefixText.Text = "Kido"; }
            if (String.IsNullOrEmpty(PlayerNameText.Text)) { PlayerNameText.Text = "PLAYERNAME"; }

            string[] X = new string[dataGridView1.Rows.Count];
            string[] Y = new string[dataGridView1.Rows.Count];
            string[] Z = new string[dataGridView1.Rows.Count];
            string[] Roll = new string[dataGridView1.Rows.Count];
            string[] Pitch = new string[dataGridView1.Rows.Count];
            string[] Yaw = new string[dataGridView1.Rows.Count];
            string[] Mesh = new string[dataGridView1.Rows.Count];
            string[] ScaleWord = new string[dataGridView1.Rows.Count];

            int num = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                X[num] = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                Y[num] = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                Z[num] = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                Roll[num] = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                Pitch[num] = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
                Yaw[num] = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : string.Empty;
                Mesh[num] = row.Cells[6].Value != null ? row.Cells[6].Value.ToString() : string.Empty;
                ScaleWord[num] = row.Cells[7].Value != null ? row.Cells[7].Value.ToString() : string.Empty;

                num++;
                
            }
            
            string fileName = PrefixText.Text + "_Player_" + PlayerNameText.Text + "Mod.uc";
            pathString = System.IO.Path.Combine(pathString, fileName);

            string text = System.IO.File.ReadAllText(pathString);
            string[] lines = System.IO.File.ReadAllLines(pathString);

            int num2 = 0;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(pathString))
            {

                for (var i = 0; i < lines.Length; i++)
                {
                    file.WriteLine(lines[i]);
                    if (lines[i].Contains("	CleanUpProps(); ") && i >= 20)
                    {
                        foreach (var item in X)
                        {
                            //Console.WriteLine(X[num2]);
                            if (X[num2] == "" && Y[num2] == "" && Z[num2] == "" && Roll[num2] == "" && Pitch[num2] == "" && Yaw[num2] == "" && Mesh[num2] == "" && ScaleWord[num2] == "")
                            {
                                //lolno
                            }
                            else
                            {
                                if (X[num2] == "") { X[num2] = "0"; }
                                if (Y[num2] == "") { Y[num2] = "0"; }
                                if (Z[num2] == "") { Z[num2] = "0"; }
                                if (Roll[num2] == "") { Roll[num2] = "0"; }
                                if (Pitch[num2] == "") { Pitch[num2] = "0"; }
                                if (Yaw[num2] == "") { Yaw[num2] = "0"; }
                                if (Mesh[num2] == "") { Mesh[num2] = "StaticMesh'HatInTime_Hub_Vince.models.pillow_fatOrange_pillow_fat'"; }
                                if (ScaleWord[num2] == "") { ScaleWord[num2] = "1"; }
                                file.WriteLine("    SpawnProp(class'" + PrefixText.Text + "_DynamicStaticActor_Deletable', " + X[num2] + ", " + Y[num2] + ", " + Z[num2] + ", " + Roll[num2] + "*DG, " + Pitch[num2] + "*DG, " + Yaw[num2] + "*DG, " + Mesh[num2] + ", " + ScaleWord[num2] + ");");
                            }
                            num2++;
                        }

                        
                    }

                    if (lines[i].Contains("	act = Spawn(C,self,,vt,rt); ") && !lines[i+1].Contains("    if (" + PrefixText.Text + "_DynamicStaticActor_Deletable(act) != None && Mesh != None)"))
                    {
                        file.WriteLine("    if (" + PrefixText.Text + "_DynamicStaticActor_Deletable(act) != None && Mesh != None)");
                        file.WriteLine("    {");
                        file.WriteLine("        " + PrefixText.Text + "_DynamicStaticActor_Deletable(act).StaticMeshComponent.SetStaticMesh(Mesh);");
                        file.WriteLine("        " + PrefixText.Text + "_DynamicStaticActor_Deletable(act).StaticMeshComponent.SetScale(s);");
                        file.WriteLine("    }");

                    }
                }
            }


            pathString = System.IO.Path.Combine(path, "Output");
            fileName = PrefixText.Text + "_DynamicStaticActor_Deletable.uc";
            pathString = System.IO.Path.Combine(pathString, fileName);

            if (!System.IO.File.Exists(pathString))
            {
                using (StreamWriter writer = new StreamWriter(pathString))
                {
                    writer.WriteLine("class "+PrefixText.Text+"_DynamicStaticActor_Deletable extends Hat_DynamicStaticActor;\n\ndefaultproperties\n{\n	Begin Object Name=MyLightEnvironment\n		bEnabled = true\n	End Object\n\n	Begin Object Name=StaticMeshComponent0\n        bUsePrecomputedShadows = false\n        LightingChannels = (Static = false, Dynamic = true)\n		LightEnvironment = MyLightEnvironment\n\n		CanBeEdgeGrabbed = false\n		CanBeWallSlid = false\n	End Object\n\n	bNoDelete = false\n}");
                }
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathString = System.IO.Path.Combine(path, "Output");
            System.IO.Directory.CreateDirectory(pathString);
            Process.Start(pathString);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            
               
        }
    }
}
