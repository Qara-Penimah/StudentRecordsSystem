using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordsSystem
{
	public partial class Splash : Form, IWelcomeScreen
	{
		private Timer _timer;

		public Splash()
		{
			InitializeComponent();
			applicationNameLabel.BackColor = Color.Transparent;
		}

		private void Splash_Shown(object sender, EventArgs e)
		{
			// Create a timer that will execute every 30 milliseconds.
			// 30ms * 100 (progress bar steps) equals 3 seconds.
			// Close the welcome screen after 3 seconds.

			_timer = new Timer
			{
				Interval = 30	// 30 milliseconds
			};

			_timer.Start();
			_timer.Tick += TimerAction;
		}

		void TimerAction(object sender, EventArgs e)
		{
			loadingProgressBar.PerformStep();

			if(loadingProgressBar.Value == 100)
			{
				IsComplete = true;
				_timer.Stop();
			}
		}

		#region Implementation of IWelcomeScreen

		public bool IsComplete { get; private set; }

		#endregion
	}
}
