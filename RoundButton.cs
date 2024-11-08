﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
	internal class RoundButton : Button
	{
		protected override void OnPaint(PaintEventArgs pevent)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(1, 1, ClientSize.Width-4, ClientSize.Height-4);
			this.Region = new System.Drawing.Region(graphicsPath);
			base.OnPaint(pevent);
		}
	}
}
