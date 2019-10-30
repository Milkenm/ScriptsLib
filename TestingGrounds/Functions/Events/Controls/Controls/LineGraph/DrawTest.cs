using System.Drawing;
using static TestingGrounds.Static;
using static ScriptsLib.Controls.LineGraph;

namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static void DrawTest()
		{
			int maxVal = MainForm.lineGraph.Height;
			int increment = 10;

			for (int i = maxVal; i > 0; i -= increment)
			{
				Pen pen = new Pen(Color.Black, 1);

				Line bl = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.BottomLeft);
				Line br = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.BottomRight);
				Line tl = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.TopLeft);
				Line tr = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.TopRight);

				MainForm.lineGraph.DrawLine(bl);
				MainForm.lineGraph.DrawLine(br);
				MainForm.lineGraph.DrawLine(tl);
				MainForm.lineGraph.DrawLine(tr);
			}
		}
	}
}