﻿namespace MegaDesk2
{

	partial class SearchQuotes
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
            this.returnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnHome
            // 
            this.returnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHome.Location = new System.Drawing.Point(12, 415);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(103, 23);
            this.returnHome.TabIndex = 0;
            this.returnHome.Text = "Main Menu";
            this.returnHome.UseVisualStyleBackColor = true;
            this.returnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.returnHome);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button returnHome;
	}
}