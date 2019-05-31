#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Dev;

using static ScriptsLib.Dev.Debug;
#endregion Usings



namespace ScriptsLib.Controls
{
	public class Controls
	{
		#region Refs
		// # ================================================================================================ #
		Debug _Debug = new Debug();
		Tools.Tools _Tools = new Tools.Tools();
		// # ================================================================================================ #
		#endregion Refs










		public class TextBox : Controls
		{
			#region Only Numbers
			// # ================================================================================================ #
			public void OnlyNumbers(System.Windows.Forms.TextBox _TextBox, bool _Decimal = false, bool _Enabled = true)
			{
				_TextBox.KeyPress += new KeyPressEventHandler((_Sender, _Event) => OnlyNumbersEvent(_Sender, _Event, _Decimal, _Enabled));
			}
			// # ================================================================================================ #
			private void OnlyNumbersEvent(object _Sender, KeyPressEventArgs _Event, bool _Decimal, bool _Enabled)
			{
				///
				// https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
				///



				if (_Enabled == true)
				{
					if (!Char.IsControl(_Event.KeyChar) && !Char.IsDigit(_Event.KeyChar) && _Event.KeyChar != '.')
					{
						_Event.Handled = true;
					}

					if (_Event.KeyChar == '.' && (_Sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1 || _Event.KeyChar == '.' && _Decimal == false)
					{
						_Event.Handled = true;
					}
				}
			}
			// # ================================================================================================ #
			#endregion Only Numbers
		}



		public class ComboBox : Controls
		{
			#region Resize
			///
			// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
			///



			// # ================================================================================================ #
			[DllImport("user32.dll")]
			static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
			private const int CB_SETITEMHEIGHT = 0x153;

			public void Resize(System.Windows.Forms.ComboBox _ComboBox, int _Hight)
			{
				try
				{
					SendMessage(_ComboBox.Handle, CB_SETITEMHEIGHT, -1, _Hight - 6);
					_ComboBox.Refresh();
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}
			}
			// # ================================================================================================ #
			#endregion Resize
		}



		public class Form : Controls
		{
			#region Is Open
			public bool IsOpen(string _FormName)
			{
				FormCollection _Forms = Application.OpenForms;
				foreach (System.Windows.Forms.Form _Form in _Forms)
				{
					if (_Form.Name == _FormName)
					{
						return true;
					}
				}
				return false;
			}
			#endregion Is Open



			#region Get Open Forms
			public List<System.Windows.Forms.Form> GetOpenForms()
			{
				List<System.Windows.Forms.Form> _Forms = new List<System.Windows.Forms.Form>();
				foreach (System.Windows.Forms.Form _Form in Application.OpenForms)
				{
					_Forms.Add(_Form);
				}
				return _Forms;
			}
			#endregion Get Open Forms



			#region Set Intro Form
			public async void SetIntroForm(System.Windows.Forms.Form _Form, double _BloomRatio, bool _Transparent, bool _OnTop = false, System.Windows.Forms.Form _NextForm = null, int _NextFormChangeDelay = 0, int _MsDelay = 1)
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
							_SetIntroFormTimer.Tick += new EventHandler((_Sender, _Event) => _SetIntroFormTimerEvent(_Sender, _Event, _Form, _BloomRatio, _NextForm, _NextFormChangeDelay, _SetIntroFormTimer));
							_SetIntroFormTimer.Interval = _MsDelay;
							_SetIntroFormTimer.Start();
						}));
					});
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}
			}

			private void _SetIntroFormTimerEvent(object _Sender, EventArgs _Event, System.Windows.Forms.Form _Form, double _BloomRatio, System.Windows.Forms.Form _NextForm, int _NextFormChangeDelay, System.Windows.Forms.Timer _Timer)
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
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}
			}
			#endregion Set Intro Form
		}
	}
}
