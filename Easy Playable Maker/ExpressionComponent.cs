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
	public partial class ExpressionComponent : Form
	{
		public ExpressionComponent()
		{
			InitializeComponent();
           
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
			string pathString = System.IO.Path.Combine(path, "Output");

			if (String.IsNullOrEmpty(PrefixText.Text)) { PrefixText.Text = "Kido"; }
			if (String.IsNullOrEmpty(PlayerNameText.Text)) { PlayerNameText.Text = "PLAYERNAME"; }
			if (String.IsNullOrEmpty(FaceText.Text)) { FaceText.Text = "-1"; }
			if (String.IsNullOrEmpty(EyesText.Text)) { EyesText.Text = "-1"; }

            if (String.IsNullOrEmpty(T_P.Text)) { T_P.Text = "None"; }
            if (String.IsNullOrEmpty(FU_P.Text)) { FU_P.Text = "None"; }
            if (String.IsNullOrEmpty(Smu_P.Text)) { Smu_P.Text = "None"; }
            if (String.IsNullOrEmpty(N_P.Text)) { N_P.Text = "None"; }
            if (String.IsNullOrEmpty(Det_P.Text)) { Det_P.Text = "None"; }
            if (String.IsNullOrEmpty(FOE_P.Text)) { FOE_P.Text = "None"; }
            if (String.IsNullOrEmpty(F_P.Text)) { F_P.Text = "None"; }
            if (String.IsNullOrEmpty(M_P.Text)) { M_P.Text = "None"; }
            if (String.IsNullOrEmpty(Dis_P.Text)) { Dis_P.Text = "None"; }
            if (String.IsNullOrEmpty(C_P.Text)) { C_P.Text = "None"; }
            if (String.IsNullOrEmpty(St_P.Text)) { St_P.Text = "None"; }
            if (String.IsNullOrEmpty(Sl_P.Text)) { Sl_P.Text = "None"; }
            if (String.IsNullOrEmpty(T_EW.Text)) { T_EW.Text = "None"; }
            if (String.IsNullOrEmpty(FU_EW.Text)) { FU_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Smu_EW.Text)) { Smu_EW.Text = "None"; }
            if (String.IsNullOrEmpty(N_EW.Text)) { N_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Det_EW.Text)) { Det_EW.Text = "None"; }
            if (String.IsNullOrEmpty(FOE_EW.Text)) { FOE_EW.Text = "None"; }
            if (String.IsNullOrEmpty(F_EW.Text)) { F_EW.Text = "None"; }
            if (String.IsNullOrEmpty(M_EW.Text)) { M_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Dis_EW.Text)) { Dis_EW.Text = "None"; }
            if (String.IsNullOrEmpty(C_EW.Text)) { C_EW.Text = "None"; }
            if (String.IsNullOrEmpty(St_EW.Text)) { St_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Sl_EW.Text)) { Sl_EW.Text = "None"; }
            if (String.IsNullOrEmpty(T_EL.Text)) { T_EL.Text = "None"; }
            if (String.IsNullOrEmpty(FU_EL.Text)) { FU_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Smu_EL.Text)) { Smu_EL.Text = "None"; }
            if (String.IsNullOrEmpty(N_EL.Text)) { N_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Det_EL.Text)) { Det_EL.Text = "None"; }
            if (String.IsNullOrEmpty(FOE_EL.Text)) { FOE_EL.Text = "None"; }
            if (String.IsNullOrEmpty(F_EL.Text)) { F_EL.Text = "None"; }
            if (String.IsNullOrEmpty(M_EL.Text)) { M_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Dis_EL.Text)) { Dis_EL.Text = "None"; }
            if (String.IsNullOrEmpty(C_EL.Text)) { C_EL.Text = "None"; }
            if (String.IsNullOrEmpty(St_EL.Text)) { St_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Sl_EL.Text)) { Sl_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Sm_P.Text)) { Sm_P.Text = "None"; }
            if (String.IsNullOrEmpty(Di_P.Text)) { Di_P.Text = "None"; }
            if (String.IsNullOrEmpty(I_P.Text)) { I_P.Text = "None"; }
            if (String.IsNullOrEmpty(De_P.Text)) { De_P.Text = "None"; }
            if (String.IsNullOrEmpty(Sc_P.Text)) { Sc_P.Text = "None"; }
            if (String.IsNullOrEmpty(Se_P.Text)) { Se_P.Text = "None"; }
            if (String.IsNullOrEmpty(Hu_P.Text)) { Hu_P.Text = "None"; }
            if (String.IsNullOrEmpty(S_P.Text)) { S_P.Text = "None"; }
            if (String.IsNullOrEmpty(H_P.Text)) { H_P.Text = "None"; }
            if (String.IsNullOrEmpty(HB_P.Text)) { HB_P.Text = "None"; }
            if (String.IsNullOrEmpty(A_P.Text)) { A_P.Text = "None"; }
            if (String.IsNullOrEmpty(D_P.Text)) { D_P.Text = "None"; }
            if (String.IsNullOrEmpty(Sm_EW.Text)) { Sm_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Di_EW.Text)) { Di_EW.Text = "None"; }
            if (String.IsNullOrEmpty(I_EW.Text)) { I_EW.Text = "None"; }
            if (String.IsNullOrEmpty(De_EW.Text)) { De_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Sc_EW.Text)) { Sc_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Se_EW.Text)) { Se_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Hu_EW.Text)) { Hu_EW.Text = "None"; }
            if (String.IsNullOrEmpty(S_EW.Text)) { S_EW.Text = "None"; }
            if (String.IsNullOrEmpty(H_EW.Text)) { H_EW.Text = "None"; }
            if (String.IsNullOrEmpty(HB_EW.Text)) { HB_EW.Text = "None"; }
            if (String.IsNullOrEmpty(A_EW.Text)) { A_EW.Text = "None"; }
            if (String.IsNullOrEmpty(D_EW.Text)) { D_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Sm_EL.Text)) { Sm_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Di_EL.Text)) { Di_EL.Text = "None"; }
            if (String.IsNullOrEmpty(I_EL.Text)) { I_EL.Text = "None"; }
            if (String.IsNullOrEmpty(De_EL.Text)) { De_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Sc_EL.Text)) { Sc_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Se_EL.Text)) { Se_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Hu_EL.Text)) { Hu_EL.Text = "None"; }
            if (String.IsNullOrEmpty(S_EL.Text)) { S_EL.Text = "None"; }
            if (String.IsNullOrEmpty(H_EL.Text)) { H_EL.Text = "None"; }
            if (String.IsNullOrEmpty(HB_EL.Text)) { HB_EL.Text = "None"; }
            if (String.IsNullOrEmpty(A_EL.Text)) { A_EL.Text = "None"; }
            if (String.IsNullOrEmpty(D_EL.Text)) { D_EL.Text = "None"; }
            if (String.IsNullOrEmpty(Co_P.Text)) { Co_P.Text = "None"; }
            if (String.IsNullOrEmpty(Co_EW.Text)) { Co_EW.Text = "None"; }
            if (String.IsNullOrEmpty(Co_EL.Text)) { Co_EL.Text = "None"; }


            string fileName = PrefixText.Text+ "_ExpressionComponent_" + PlayerNameText.Text+".uc";
			pathString = System.IO.Path.Combine(pathString, fileName);


			if (!System.IO.File.Exists(pathString))
			{
				using (StreamWriter writer = new StreamWriter(pathString))
				{
					writer.WriteLine("class " + PrefixText.Text + "_ExpressionComponent_" + PlayerNameText.Text + " extends Hat_ExpressionComponent;\n\ndefaultproperties\n{\n	FaceIndex="+FaceText.Text+";\n	EyeIndex="+EyesText.Text+";\n}");
                    
                }
            }

		}

		private void Output_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //It's a step in the right direction however not what I'm looking for specifically
			string pathString = System.IO.Path.Combine(path, "Output");
			System.IO.Directory.CreateDirectory(pathString);
			Process.Start(pathString);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void FullModelText_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
