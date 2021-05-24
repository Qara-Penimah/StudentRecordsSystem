using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordsSystem
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Create and show welcome screen
			Splash welcomeScreen = new Splash();
			welcomeScreen.Show();

			// Hand welcome screen over to the main form
			// to enable the main form to manage and close
			// the welcome screen. No memory leak.
			Application.Run(new Main(welcomeScreen));
		}
	}
}
