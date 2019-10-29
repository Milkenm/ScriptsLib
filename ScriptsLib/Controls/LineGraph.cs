#region Usings
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
#endregion Usings



namespace Testing.LineGraph
{
	public partial class LineGraph : UserControl
	{
		private  List<Line> lines = new List<Line>();
		private Graphics g;
		private int CurrentX, CurrentY;

		public LineGraph()
		{
			InitializeComponent();

			g = this.CreateGraphics();


		}

		private void LineGraph_Paint(object sender, PaintEventArgs e)
		{
			g.Clear(Color.White);

			foreach (Line l in lines)
			{
				DrawLine(l, false);
			}
		}

		public struct Line
		{
			public Pen P;
			public int StartX, StartY, EndX, EndY;
			public PositionList Position;

			public Line(Pen _P, int _StartX, int _StartY, int _EndX, int _EndY, PositionList _Pos)
			{
				P = _P;
				StartX = _StartX;
				StartY = _StartY;
				EndX = _EndX;
				EndY = _EndY;
				Position = _Pos;
			}
		}

		public enum PositionList
		{
			BottomLeft,
			BottomRight,
			TopLeft,
			TopRight,
		}
		
		public void DrawLine(Line line) => DrawLine(line.P, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, true);
		public void DrawLine(Line line, bool SaveLine) => DrawLine(line.P, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, SaveLine);
		public void DrawLine(Pen pen, int StartX, int StartY, int EndX, int EndY, PositionList Pos, bool SaveLine)
		{
			switch (Pos)
			{
				case PositionList.BottomLeft:
					{
						g.DrawLine(pen, StartX, this.Size.Height - StartY, EndX, this.Size.Height - EndY);
						break;
					}
				case PositionList.BottomRight:
					{
						g.DrawLine(pen, this.Size.Width - StartX, this.Size.Height - StartY, this.Size.Width - EndX, this.Size.Height - EndY);
						break;
					}
				case PositionList.TopLeft:
					{
						g.DrawLine(pen, StartX, StartY, EndX, EndY);
						break;
					}
				case PositionList.TopRight:
					{
						g.DrawLine(pen, this.Size.Width - StartX, StartY, this.Size.Width - EndX, EndY);
						break;
					}
			}

			if (SaveLine) lines.Add(new Line(pen, StartX, StartY, EndX, EndY, Pos));

			CurrentX = EndX;
			CurrentY = EndY;
		}

		public void IncrementLine(Pen pen, int EndX, int EndY, PositionList Pos, bool SaveLine)
		{
			switch (Pos)
			{
				case PositionList.BottomLeft:
					{
						g.DrawLine(pen, CurrentX, this.Size.Height - CurrentY, EndX, this.Size.Height - EndY);
						break;
					}
				case PositionList.BottomRight:
					{
						g.DrawLine(pen, this.Size.Width - CurrentX, this.Size.Height - CurrentY, this.Size.Width - EndX, this.Size.Height - EndY);
						break;
					}
				case PositionList.TopLeft:
					{
						g.DrawLine(pen, CurrentX, CurrentY, EndX, EndY);
						break;
					}
				case PositionList.TopRight:
					{
						g.DrawLine(pen, this.Size.Width - CurrentX, CurrentY, this.Size.Width - EndX, EndY);
						break;
					}
			}

			if (SaveLine) lines.Add(new Line(pen, CurrentX, CurrentY, EndX, EndY, Pos));

			CurrentX = EndX;
			CurrentY = EndY;
		}
	}
}
