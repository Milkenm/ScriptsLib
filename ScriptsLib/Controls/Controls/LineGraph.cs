#region Usings
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
#endregion Usings



namespace ScriptsLib.Controls
{
	public partial class LineGraph : UserControl
	{
		private List<Line> lines = new List<Line>();
		private Graphics g;
		private int currentX, currentY;
		private Timer t = new Timer();

		public LineGraph()
		{
			InitializeComponent();

			g = this.CreateGraphics();

			t.Interval = 500;
			t.Tick += this.T_Tick;
			t.Start();
		}

		private void LineGraph_Paint(object sender, PaintEventArgs e) => t.Start();

		private void T_Tick(object sender, System.EventArgs e)
		{
			g.Clear(this.BackColor == Color.Transparent ? Color.White : this.BackColor);
			foreach (Line _Line in lines) DrawLine(_Line, false);

			t.Stop();
		}

		public struct Line
		{
			public Pen Pen;
			public int StartX, StartY, EndX, EndY;
			public PositionList Position;

			public Line(Pen p, int startX, int startY, int endX, int endY, PositionList pos)
			{
				this.Pen = p;
				this.StartX = startX;
				this.StartY = startY;
				this.EndX = endX;
				this.EndY = endY;
				this.Position = pos;
			}
		}

		public enum PositionList
		{
			BottomLeft,
			BottomRight,
			TopLeft,
			TopRight,
		}
		
		public void DrawLine(Line line) => DrawLine(line.Pen, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, true);
		public void DrawLine(Line line, bool saveLine) => DrawLine(line.Pen, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, saveLine);
		public void DrawLine(Pen p, int startX, int startY, int endX, int endY, PositionList position, bool saveLine)
		{
			switch (position)
			{
				case PositionList.BottomLeft:
					{
						g.DrawLine(p, startX, this.Size.Height - startY, endX, this.Size.Height - endY);
						break;
					}
				case PositionList.BottomRight:
					{
						g.DrawLine(p, this.Size.Width - startX, this.Size.Height - startY, this.Size.Width - endX, this.Size.Height - endY);
						break;
					}
				case PositionList.TopLeft:
					{
						g.DrawLine(p, startX, startY, endX, endY);
						break;
					}
				case PositionList.TopRight:
					{
						g.DrawLine(p, this.Size.Width - startX, startY, this.Size.Width - endX, endY);
						break;
					}
			}

			if (saveLine) lines.Add(new Line(p, startX, startY, endX, endY, position));

			currentX = endX;
			currentY = endY;
		}
		
		public void IncrementLine(Pen pen, int endX, int endY, PositionList pos, bool saveLine)
		{
			switch (pos)
			{
				case PositionList.BottomLeft:
					{
						g.DrawLine(pen, currentX, this.Size.Height - currentY, endX, this.Size.Height - endY);
						break;
					}
				case PositionList.BottomRight:
					{
						g.DrawLine(pen, this.Size.Width - currentX, this.Size.Height - currentY, this.Size.Width - endX, this.Size.Height - endY);
						break;
					}
				case PositionList.TopLeft:
					{
						g.DrawLine(pen, currentX, currentY, endX, endY);
						break;
					}
				case PositionList.TopRight:
					{
						g.DrawLine(pen, this.Size.Width - currentX, currentY, this.Size.Width - endX, endY);
						break;
					}
			}

			if (saveLine) lines.Add(new Line(pen, currentX, currentY, endX, endY, pos));

			currentX = endX;
			currentY = endY;
		}
	}
}
