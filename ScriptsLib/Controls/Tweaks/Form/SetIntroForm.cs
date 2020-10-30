using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptsLib.Controls.Tweaks
{
	public static partial class SlForm
	{
		/// <summary>Makes the form slightly appear over time (animation).</summary>
		/// <param name="form">The form to animate.</param>
		/// <param name="bloomRatio">Number between 0 and 1 being 0 no animation, 0.5 medium fast animation and 1 fast animation.</param>
		/// <param name="makeTransparent">Make the form transparent?</param>
		/// <param name="onTop">Does the form stay on top of other windows?</param>
		/// <param name="nextForm">The form to switch to after the animation completes and _NextChangeDelay is passed.</param>
		/// <param name="nextFormChangeDelay">The time to wait after the animation completes to change the form.</param>
		/// <param name="msDelay">The delay of each animation frame in milliseconds.</param>
		public static async void SetIntroForm(System.Windows.Forms.Form form, double bloomRatio, bool makeTransparent, bool onTop = false, System.Windows.Forms.Form nextForm = null, int nextFormChangeDelay = 0, int msDelay = 1)
		{
			await Task.Factory.StartNew(() =>
			{
				form.Invoke(new Action(() =>
				{
					form.Hide();
					form.Opacity = 0;
					form.Show();

					if (onTop == true)
					{
						form.TopMost = true;
					}
					if (makeTransparent == true)
					{
						form.BackColor = Color.White;
						form.TransparencyKey = Color.White;
					}

					System.Windows.Forms.Timer _SetIntroFormTimer = new System.Windows.Forms.Timer();
					_SetIntroFormTimer.Tick += new EventHandler((s, e) => SetIntroFormTimerEvent(form, bloomRatio, nextForm, nextFormChangeDelay, _SetIntroFormTimer));
					_SetIntroFormTimer.Interval = msDelay;
					_SetIntroFormTimer.Start();
				}));
			});
		}

		private static void SetIntroFormTimerEvent(Form form, double bloomRatio, Form nextForm, int nextFormChangeDelay, System.Windows.Forms.Timer _Timer)
		{
			if (form.Opacity < 1)
			{
				form.Opacity += bloomRatio;
			}
			else
			{
				_Timer.Stop();

				if (nextForm != null)
				{
					Thread.Sleep(nextFormChangeDelay);

					form.Hide();
					nextForm.Show();
				}
			}
		}
	}
}
