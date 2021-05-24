
namespace StudentRecordsSystem
{
	partial class Splash
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
			this.applicationNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::StudentRecordsSystem.Images.WelcomeBackground;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 385);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// loadingProgressBar
			// 
			this.loadingProgressBar.Location = new System.Drawing.Point(12, 409);
			this.loadingProgressBar.Name = "loadingProgressBar";
			this.loadingProgressBar.Size = new System.Drawing.Size(776, 29);
			this.loadingProgressBar.TabIndex = 1;
			// 
			// applicationNameLabel
			// 
			this.applicationNameLabel.AutoSize = true;
			this.applicationNameLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.applicationNameLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.applicationNameLabel.Location = new System.Drawing.Point(145, 172);
			this.applicationNameLabel.Name = "applicationNameLabel";
			this.applicationNameLabel.Size = new System.Drawing.Size(500, 57);
			this.applicationNameLabel.TabIndex = 2;
			this.applicationNameLabel.Text = "Students Record System";
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.applicationNameLabel);
			this.Controls.Add(this.loadingProgressBar);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.Splash_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar loadingProgressBar;
		private System.Windows.Forms.Label applicationNameLabel;
	}
}