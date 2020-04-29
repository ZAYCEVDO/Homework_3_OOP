namespace WindowsFormsApp1
{
	partial class SettingsControl
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
			this._btnOpenFile = new System.Windows.Forms.Button();
			this._btnOpenFolder = new System.Windows.Forms.Button();
			this._btnStart = new System.Windows.Forms.Button();
			this._btnPause = new System.Windows.Forms.Button();
			this._btnStop = new System.Windows.Forms.Button();
			this._btnBack = new System.Windows.Forms.Button();
			this._btnForward = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _btnOpenFile
			// 
			this._btnOpenFile.BackColor = System.Drawing.Color.White;
			this._btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnOpenFile.Location = new System.Drawing.Point(3, 32);
			this._btnOpenFile.Name = "_btnOpenFile";
			this._btnOpenFile.Size = new System.Drawing.Size(114, 23);
			this._btnOpenFile.TabIndex = 0;
			this._btnOpenFile.Text = "Открыть файл";
			this._btnOpenFile.UseVisualStyleBackColor = false;
			// 
			// _btnOpenFolder
			// 
			this._btnOpenFolder.BackColor = System.Drawing.Color.White;
			this._btnOpenFolder.Location = new System.Drawing.Point(123, 32);
			this._btnOpenFolder.Name = "_btnOpenFolder";
			this._btnOpenFolder.Size = new System.Drawing.Size(129, 23);
			this._btnOpenFolder.TabIndex = 1;
			this._btnOpenFolder.Text = "Открыть папку";
			this._btnOpenFolder.UseVisualStyleBackColor = false;
			// 
			// _btnStart
			// 
			this._btnStart.BackColor = System.Drawing.Color.White;
			this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnStart.Location = new System.Drawing.Point(3, 3);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(55, 23);
			this._btnStart.TabIndex = 2;
			this._btnStart.Text = "Старт";
			this._btnStart.UseVisualStyleBackColor = false;
			// 
			// _btnPause
			// 
			this._btnPause.BackColor = System.Drawing.Color.White;
			this._btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnPause.Location = new System.Drawing.Point(64, 3);
			this._btnPause.Name = "_btnPause";
			this._btnPause.Size = new System.Drawing.Size(53, 23);
			this._btnPause.TabIndex = 3;
			this._btnPause.Text = "Пауза";
			this._btnPause.UseVisualStyleBackColor = false;
			// 
			// _btnStop
			// 
			this._btnStop.BackColor = System.Drawing.Color.White;
			this._btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnStop.ForeColor = System.Drawing.Color.Maroon;
			this._btnStop.Location = new System.Drawing.Point(123, 3);
			this._btnStop.Name = "_btnStop";
			this._btnStop.Size = new System.Drawing.Size(47, 23);
			this._btnStop.TabIndex = 4;
			this._btnStop.Text = "Стоп";
			this._btnStop.UseVisualStyleBackColor = false;
			// 
			// _btnBack
			// 
			this._btnBack.BackColor = System.Drawing.Color.White;
			this._btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnBack.Location = new System.Drawing.Point(176, 3);
			this._btnBack.Name = "_btnBack";
			this._btnBack.Size = new System.Drawing.Size(35, 23);
			this._btnBack.TabIndex = 5;
			this._btnBack.Text = "<<";
			this._btnBack.UseVisualStyleBackColor = false;
			// 
			// _btnForward
			// 
			this._btnForward.BackColor = System.Drawing.Color.White;
			this._btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnForward.Location = new System.Drawing.Point(217, 3);
			this._btnForward.Name = "_btnForward";
			this._btnForward.Size = new System.Drawing.Size(35, 23);
			this._btnForward.TabIndex = 6;
			this._btnForward.Text = ">>";
			this._btnForward.UseVisualStyleBackColor = false;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this._btnForward);
			this.Controls.Add(this._btnBack);
			this.Controls.Add(this._btnStop);
			this.Controls.Add(this._btnPause);
			this.Controls.Add(this._btnStart);
			this.Controls.Add(this._btnOpenFolder);
			this.Controls.Add(this._btnOpenFile);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(927, 175);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnOpenFile;
		private System.Windows.Forms.Button _btnOpenFolder;
		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnPause;
		private System.Windows.Forms.Button _btnStop;
		private System.Windows.Forms.Button _btnBack;
		private System.Windows.Forms.Button _btnForward;
	}
}
