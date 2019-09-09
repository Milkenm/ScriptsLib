#region Usings
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib.nControls
{
	public static partial class SlForm
	{
		/// <summary>Makes the form slightly appear over time (animation).</summary>
		/// <param name="_Form">The form to animate.</param>
		/// <param name="_BloomRatio">Number between 0 and 1 being 0 no animation, 0.5 medium fast animation and 1 fast animation.</param>
		/// <param name="_Transparent">Make the form transparent?</param>
		/// <param name="_OnTop">Does the form stay on top of other windows?</param>
		/// <param name="_NextForm">The form to switch to after the animation completes and _NextChangeDelay is passed.</param>
		/// <param name="_NextFormChangeDelay">The time to wait after the animation completes to change the form.</param>
		/// <param name="_MsDelay">The delay of each animation frame in milliseconds.</param>
		public static async void SetIntroForm(System.Windows.Forms.Form _Form, double _BloomRatio, bool _Transparent, bool _OnTop = false, System.Windows.Forms.Form _NextForm = null, int _NextFormChangeDelay = 0, int _MsDelay = 1)
		{
			try
			{
				await Task.Factory.StartNew(() =>
				{
					_Form.Invoke(new Action(() =>
					{
						_Form.Hide();
						_Form.Opacity = 0;
						_Form.Show();

						if (_OnTop == true)
						{
							_Form.TopMost = true;
						}
						if (_Transparent == true)
						{
							_Form.BackColor = Color.White;
							_Form.TransparencyKey = Color.White;
						}

						System.Windows.Forms.Timer _SetIntroFormTimer = new System.Windows.Forms.Timer();
						_SetIntroFormTimer.Tick += new EventHandler((_Sender, _Event) => SetIntroFormTimerEvent(_Sender, _Event, _Form, _BloomRatio, _NextForm, _NextFormChangeDelay, _SetIntroFormTimer));
						_SetIntroFormTimer.Interval = _MsDelay;
						_SetIntroFormTimer.Start();
					}));
				});
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}

		#region Timer Event
		private static void SetIntroFormTimerEvent(object _Sender, EventArgs _Event, System.Windows.Forms.Form _Form, double _BloomRatio, System.Windows.Forms.Form _NextForm, int _NextFormChangeDelay, System.Windows.Forms.Timer _Timer)
		{
			try
			{
				if (_Form.Opacity < 1)
				{
					_Form.Opacity = _Form.Opacity + _BloomRatio;
				}
				else
				{
					_Timer.Stop();

					if (_NextForm != null)
					{
						Thread.Sleep(_NextFormChangeDelay);

						_Form.Hide();
						_NextForm.Show();
					}
				}
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
			}
		}
		#endregion Timer Event
	}
}
