namespace WindowsFormsApp1
{
	partial class LogControl
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._richTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// _richTextBox
			// 
			this._richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._richTextBox.Location = new System.Drawing.Point(0, 0);
			this._richTextBox.Name = "_richTextBox";
			this._richTextBox.Size = new System.Drawing.Size(150, 150);
			this._richTextBox.TabIndex = 0;
			this._richTextBox.Text = "";
			// 
			// LogControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this._richTextBox);
			this.Name = "LogControl";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _richTextBox;
	}
}
