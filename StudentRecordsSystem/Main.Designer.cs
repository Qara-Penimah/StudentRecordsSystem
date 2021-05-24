
namespace StudentRecordsSystem
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.GradeTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddGradeButton = new System.Windows.Forms.Button();
			this.GradesDataGridView = new System.Windows.Forms.DataGridView();
			this.GradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.GradesPercentageLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GradesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GradesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// GradeTextbox
			// 
			this.GradeTextbox.Location = new System.Drawing.Point(12, 52);
			this.GradeTextbox.Name = "GradeTextbox";
			this.GradeTextbox.Size = new System.Drawing.Size(125, 27);
			this.GradeTextbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Grade";
			// 
			// AddGradeButton
			// 
			this.AddGradeButton.Location = new System.Drawing.Point(144, 52);
			this.AddGradeButton.Name = "AddGradeButton";
			this.AddGradeButton.Size = new System.Drawing.Size(94, 29);
			this.AddGradeButton.TabIndex = 2;
			this.AddGradeButton.Text = "Add";
			this.AddGradeButton.UseVisualStyleBackColor = true;
			this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
			// 
			// GradesDataGridView
			// 
			this.GradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GradesDataGridView.Location = new System.Drawing.Point(13, 106);
			this.GradesDataGridView.Name = "GradesDataGridView";
			this.GradesDataGridView.RowHeadersWidth = 51;
			this.GradesDataGridView.RowTemplate.Height = 29;
			this.GradesDataGridView.Size = new System.Drawing.Size(469, 258);
			this.GradesDataGridView.TabIndex = 3;
			// 
			// GradesPercentageLabel
			// 
			this.GradesPercentageLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.GradesPercentageLabel.Location = new System.Drawing.Point(332, 26);
			this.GradesPercentageLabel.Name = "GradesPercentageLabel";
			this.GradesPercentageLabel.Size = new System.Drawing.Size(150, 57);
			this.GradesPercentageLabel.TabIndex = 4;
			this.GradesPercentageLabel.Text = "0%";
			this.GradesPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 520);
			this.Controls.Add(this.GradesPercentageLabel);
			this.Controls.Add(this.GradesDataGridView);
			this.Controls.Add(this.AddGradeButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GradeTextbox);
			this.Name = "Main";
			this.Text = "Student Records System";
			((System.ComponentModel.ISupportInitialize)(this.GradesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GradesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox GradeTextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddGradeButton;
		private System.Windows.Forms.DataGridView GradesDataGridView;
		private System.Windows.Forms.BindingSource GradesBindingSource;
		private System.Windows.Forms.Label GradesPercentageLabel;
	}
}

