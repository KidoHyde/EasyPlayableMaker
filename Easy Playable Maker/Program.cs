using Easy_Playable_Maker.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Easy_Playable_Maker
{
	static class Program
	{
        //Version.txt and BuildData.cs need regular updates

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainView());
        }
	}
}
