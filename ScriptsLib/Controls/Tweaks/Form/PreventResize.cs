using System.Drawing;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		public static void PreventResize(Form form, bool preventResize)
		{
			if (preventResize)
			{
				form.MinimumSize = form.Size;
				form.MaximumSize = form.Size;
			}
			else
			{
				form.MinimumSize = new Size(0, 0);
				form.MaximumSize = new Size(0, 0);
			}
		}
	}
}