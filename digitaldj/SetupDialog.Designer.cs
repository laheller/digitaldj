/*
 * Created by SharpDevelop.
 * User: lhe
 * Date: 7. 1. 2016
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace digitaldj
{
	partial class SetupDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tcSettings = new System.Windows.Forms.TabControl();
			this.tpAudio = new System.Windows.Forms.TabPage();
			this.tpOther = new System.Windows.Forms.TabPage();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbAudioAPI = new System.Windows.Forms.GroupBox();
			this.rbDirectSound = new System.Windows.Forms.RadioButton();
			this.rbASIO = new System.Windows.Forms.RadioButton();
			this.rbWASAPI = new System.Windows.Forms.RadioButton();
			this.tcSettings.SuspendLayout();
			this.tpAudio.SuspendLayout();
			this.gbAudioAPI.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcSettings
			// 
			this.tcSettings.Controls.Add(this.tpAudio);
			this.tcSettings.Controls.Add(this.tpOther);
			this.tcSettings.Location = new System.Drawing.Point(12, 12);
			this.tcSettings.Name = "tcSettings";
			this.tcSettings.SelectedIndex = 0;
			this.tcSettings.Size = new System.Drawing.Size(260, 195);
			this.tcSettings.TabIndex = 0;
			// 
			// tpAudio
			// 
			this.tpAudio.Controls.Add(this.gbAudioAPI);
			this.tpAudio.Location = new System.Drawing.Point(4, 22);
			this.tpAudio.Name = "tpAudio";
			this.tpAudio.Padding = new System.Windows.Forms.Padding(3);
			this.tpAudio.Size = new System.Drawing.Size(252, 169);
			this.tpAudio.TabIndex = 0;
			this.tpAudio.Text = "Audio";
			this.tpAudio.UseVisualStyleBackColor = true;
			// 
			// tpOther
			// 
			this.tpOther.Location = new System.Drawing.Point(4, 22);
			this.tpOther.Name = "tpOther";
			this.tpOther.Padding = new System.Windows.Forms.Padding(3);
			this.tpOther.Size = new System.Drawing.Size(252, 169);
			this.tpOther.TabIndex = 1;
			this.tpOther.Text = "Other";
			this.tpOther.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(12, 227);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(197, 227);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// gbAudioAPI
			// 
			this.gbAudioAPI.Controls.Add(this.rbWASAPI);
			this.gbAudioAPI.Controls.Add(this.rbASIO);
			this.gbAudioAPI.Controls.Add(this.rbDirectSound);
			this.gbAudioAPI.Location = new System.Drawing.Point(6, 6);
			this.gbAudioAPI.Name = "gbAudioAPI";
			this.gbAudioAPI.Size = new System.Drawing.Size(123, 113);
			this.gbAudioAPI.TabIndex = 0;
			this.gbAudioAPI.TabStop = false;
			this.gbAudioAPI.Text = "Audio API";
			// 
			// rbDirectSound
			// 
			this.rbDirectSound.Checked = true;
			this.rbDirectSound.Location = new System.Drawing.Point(6, 19);
			this.rbDirectSound.Name = "rbDirectSound";
			this.rbDirectSound.Size = new System.Drawing.Size(104, 24);
			this.rbDirectSound.TabIndex = 0;
			this.rbDirectSound.TabStop = true;
			this.rbDirectSound.Text = "DirectSound";
			this.rbDirectSound.UseVisualStyleBackColor = true;
			// 
			// rbASIO
			// 
			this.rbASIO.Location = new System.Drawing.Point(6, 49);
			this.rbASIO.Name = "rbASIO";
			this.rbASIO.Size = new System.Drawing.Size(104, 24);
			this.rbASIO.TabIndex = 0;
			this.rbASIO.Text = "ASIO";
			this.rbASIO.UseVisualStyleBackColor = true;
			// 
			// rbWASAPI
			// 
			this.rbWASAPI.Location = new System.Drawing.Point(6, 79);
			this.rbWASAPI.Name = "rbWASAPI";
			this.rbWASAPI.Size = new System.Drawing.Size(104, 24);
			this.rbWASAPI.TabIndex = 0;
			this.rbWASAPI.Text = "WASAPI";
			this.rbWASAPI.UseVisualStyleBackColor = true;
			// 
			// SetupDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tcSettings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetupDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SetupDialog";
			this.tcSettings.ResumeLayout(false);
			this.tpAudio.ResumeLayout(false);
			this.gbAudioAPI.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TabPage tpOther;
		private System.Windows.Forms.RadioButton rbDirectSound;
		private System.Windows.Forms.RadioButton rbASIO;
		private System.Windows.Forms.RadioButton rbWASAPI;
		private System.Windows.Forms.GroupBox gbAudioAPI;
		private System.Windows.Forms.TabPage tpAudio;
		private System.Windows.Forms.TabControl tcSettings;
	}
}
