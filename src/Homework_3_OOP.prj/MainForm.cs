using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			ProjectSettings prjSet;

			var playerControl = new PlayerControl();
			_pnlPlayer.Controls.Add(playerControl);
			playerControl.Dock = DockStyle.Fill;

			var logControl = new LogControl();
			_pnlLog.Controls.Add(logControl);
			logControl.Dock = DockStyle.Fill;

			var settingsControl = new SettingsControl();
			_pnlSettings.Controls.Add(settingsControl);
			settingsControl.Dock = DockStyle.Fill;
		}

	}
}
