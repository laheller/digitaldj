using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace digitaldj
{
	public partial class JogDial : UserControl
	{
		public JogDial()
		{
			InitializeComponent();
		}
		
		protected override Size DefaultSize
		{
			 get { return new Size(100, 100); }
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			Rectangle r = ClientRectangle;
			r.Width -= 1;
			r.Height -= 1;
			g.DrawEllipse(new Pen(Color.Red), r);
		}
		
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.Height = this.Width;
		}
	}
}
