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
	public partial class Main : Form
	{
		private readonly IWelcomeScreen _welcomeScreen;
		DataTable _gradesDataTable = new DataTable();

		public Main(IWelcomeScreen welcomeScreen)
		{
			_welcomeScreen = welcomeScreen;
			InitializeComponent();
			InitializeState();
			ManageWelcomeScreen();
		}

		private void InitializeState()
		{
			_gradesDataTable.Columns.Add(new DataColumn("Grade", typeof(double)));
			GradesBindingSource.DataSource = _gradesDataTable;
			GradesDataGridView.DataSource = _gradesDataTable;
			GradesDataGridView.DataSource = GradesBindingSource;
			GradesDataGridView.Refresh();
		}

		private void ManageWelcomeScreen()
		{
			// Wait for welcome screen to complete
			// and then close it.
			Timer timer = new Timer
			{
				Interval = 30
			};
			timer.Tick += MonitorIsCompleteStatus;
			timer.Start();
		}

		void MonitorIsCompleteStatus(object sender, EventArgs args)
		{
			if (_welcomeScreen != null && _welcomeScreen.IsComplete)
			{
				_welcomeScreen.Close();
				((Timer)sender).Stop();
			}
		}

		private void AddGradeButton_Click(object sender, EventArgs e)
		{
			var gradeText = GradeTextbox.Text.Trim();

			if (!string.IsNullOrWhiteSpace(gradeText) && double.TryParse(gradeText, out double grade))
			{
				_gradesDataTable.Rows.Add(grade);
				CalculateAverage();
			}
		}

		private void CalculateAverage()
		{
			double gradesTotal = 0.0;
			double averagePercent = 0.0;

			foreach (DataRow row in _gradesDataTable.Rows)
			{
				gradesTotal += (double)row["Grade"];
			}

			averagePercent = gradesTotal / _gradesDataTable.Rows.Count;
			GradesPercentageLabel.Text = $@"{averagePercent}%";
		}
	}
}
