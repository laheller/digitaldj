using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Un4seen.Bass;
using Un4seen.BassAsio;
using Un4seen.BassWasapi;

namespace digitaldj
{
	public partial class MainForm : Form
	{
		private BASS_DEVICEINFO[] dsdevs = null;
		
		public MainForm()
		{
			InitializeComponent();
			BassNet.Registration("ladislav.heller@gmail.com", "2X533725152222");
			//BassNet.ShowSplash(this, 3000, 1.0, 0);;;
			if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_LATENCY, this.Handle)) MessageBox.Show("Default DirectSound device not initialized!", "Error!");
			dsdevs = Bass.BASS_GetDeviceInfos();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Bass.BASS_Free()) MessageBox.Show("Failed to free resourced used by device!", "Error!");
		}
		
		void BtnInfoClick(object sender, EventArgs e)
		{
			SetupDialog dlg = new SetupDialog();
			dlg.ShowDialog();
			return;
			
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<dsdevs.Length; i++)
			{
				if (dsdevs[i].IsDefault) sb.AppendLine("* " + dsdevs[i].name + " *");
				else sb.AppendLine(dsdevs[i].name);
			}
			MessageBox.Show(sb.ToString(), "DirectSound devices (* means default)");
		}
	}
}
