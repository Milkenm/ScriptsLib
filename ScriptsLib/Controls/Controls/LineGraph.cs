using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScriptsLib.Controls
{
	public partial class LineGraph : UserControl
	{
		public struct Line
		{
			public Line(Pen p, int startX, int startY, int endX, int endY, PositionList pos)
			{
				Pen = p;
				StartX = startX;
				StartY = startY;
				EndX = endX;
				EndY = endY;
				Position = pos;
			}

			public Pen Pen;
			public int StartX, StartY, EndX, EndY;
			public PositionList Position;
		}

		public enum PositionList
		{
			BottomLeft,
			BottomRight,
			TopLeft,
			TopRight,
		}

		private List<Line> Lines = new List<Line>();
		private Graphics Graphics;
		private int CurrentX, CurrentY;

		public LineGraph()
		{
			InitializeComponent();

			Graphics = CreateGraphics();

			Timer_Tick();
		}

		private void LineGraph_Paint(object sender, PaintEventArgs e)
		{
			Timer_Tick();
		}

		private void Timer_Tick()
		{
			Graphics.Clear(BackColor == Color.Transparent ? Color.White : BackColor);
			foreach (Line _Line in Lines)
			{
				DrawLine(_Line, false);
			}
		}

		public void DrawLine(Line line)
		{
			DrawLine(line.Pen, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, true);
		}

		public void DrawLine(Line line, bool saveLine)
		{
			DrawLine(line.Pen, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, saveLine);
		}

		public void DrawLine(Pen p, int startX, int startY, int endX, int endY, PositionList position, bool saveLine)
		{
			switch (position)
			{
				case PositionList.BottomLeft:
				{
					Graphics.DrawLine(p, startX, Size.Height - startY, endX, Size.Height - endY);
					break;
				}
				case PositionList.BottomRight:
				{
					Graphics.DrawLine(p, Size.Width - startX, Size.Height - startY, Size.Width - endX, Size.Height - endY);
					break;
				}
				case PositionList.TopLeft:
				{
					Graphics.DrawLine(p, startX, startY, endX, endY);
					break;
				}
				case PositionList.TopRight:
				{
					Graphics.DrawLine(p, Size.Width - startX, startY, Size.Width - endX, endY);
					break;
				}
			}

			if (saveLine)
			{
				Lines.Add(new Line(p, startX, startY, endX, endY, position));
			}

			CurrentX = endX;
			CurrentY = endY;
		}

		private void LineGraph_Resize(object sender, EventArgs e)
		{
			Graphics = CreateGraphics();
		}

		public void IncrementLine(Pen pen, int endX, int endY, PositionList pos, bool saveLine)
		{
			switch (pos)
			{
				case PositionList.BottomLeft:
				{
					Graphics.DrawLine(pen, CurrentX, Size.Height - CurrentY, endX, Size.Height - endY);
					break;
				}
				case PositionList.BottomRight:
				{
					Graphics.DrawLine(pen, Size.Width - CurrentX, Size.Height - CurrentY, Size.Width - endX, Size.Height - endY);
					break;
				}
				case PositionList.TopLeft:
				{
					Graphics.DrawLine(pen, CurrentX, CurrentY, endX, endY);
					break;
				}
				case PositionList.TopRight:
				{
					Graphics.DrawLine(pen, Size.Width - CurrentX, CurrentY, Size.Width - endX, endY);
					break;
				}
			}

			if (saveLine)
			{
				Lines.Add(new Line(pen, CurrentX, CurrentY, endX, endY, pos));
			}

			CurrentX = endX;
			CurrentY = endY;
		}
	}
}