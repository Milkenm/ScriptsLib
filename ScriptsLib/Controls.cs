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










		/// <summary>TextBox tweaks.</summary>
		public class TextBox : Controls
		{
			#region Only Numbers
			// # ================================================================================================ #
			/// <summary>Makes the TextBox only accept numbers.</summary>
			/// <param name="_TextBox">The TextBox that will only accept numbers.</param>
			/// <param name="_Decimal">Does the TextBox accept decimal numbers?</param>
			/// <param name="_Enabled">Toggle between number only and text mode.</param>
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



		/// <summary>ComboBox tweaks.</summary>
		public class ComboBox : Controls
		{
			#region Resize
			// # = #
			// https://stackoverflow.com/questions/3158004/how-do-i-set-the-height-of-a-combobox
			// # = #



			// # ================================================================================================ #
			[DllImport("user32.dll")]
			static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

			/// <summary>Sets the heigh of the ComboBox.</summary>
			/// <param name="_ComboBox">The ComboBox to be resized.</param>
			/// <param name="_Hight">The height to be applied to the selected ComboBox.</param>
			public void Resize(System.Windows.Forms.ComboBox _ComboBox, int _Hight)
			{
				try
				{
					SendMessage(_ComboBox.Handle, 0x153, -1, _Hight - 6);
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



		/// <summary>Form tweaks.</summary>
		public class Form : Controls
		{
			#region Is Open
			// # ================================================================================================ #
			/// <summary>Gets if the given form name is open or not.</summary>
			/// <param name="_FormName">The form to check if is open.</param>
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
			// # ================================================================================================ #
			#endregion Is Open



			#region Get Open Forms
			// # ================================================================================================ #
			/// <summary>Returns a list with the open forms.</summary>
			public List<System.Windows.Forms.Form> GetOpenForms()
			{
				List<System.Windows.Forms.Form> _Forms = new List<System.Windows.Forms.Form>();
				foreach (System.Windows.Forms.Form _Form in Application.OpenForms)
				{
					_Forms.Add(_Form);
				}
				return _Forms;
			}
			// # ================================================================================================ #
			#endregion Get Open Forms



			#region Set Intro Form
			// # ================================================================================================ #
			/// <summary>Makes the form slightly appear over time (animation).</summary>
			/// <param name="_Form">The form to animate.</param>
			/// <param name="_BloomRatio">Number between 0 and 1 being 0 no animation, 0.5 medium fast animation and 1 fast animation.</param>
			/// <param name="_Transparent">Make the form transparent?</param>
			/// <param name="_OnTop">Does the form stay on top of other windows?</param>
			/// <param name="_NextForm">The form to switch to after the animation completes and _NextChangeDelay is passed.</param>
			/// <param name="_NextFormChangeDelay">The time to wait after the animation completes to change the form.</param>
			/// <param name="_MsDelay">The delay of each animation frame in milliseconds.</param>
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
			// # ================================================================================================ #
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
			// # ================================================================================================ #
			#endregion Set Intro Form



			#region Bring To Front
			/// <summary>Brings the selected form to the front.</summary>
			/// <param name="_FormName">The name of the form to bring to the front.</param>
			public void BringToFront(string _FormName)
			{
				try
				{
					foreach (System.Windows.Forms.Form _Form in Application.OpenForms)
					{
						if(_Form.Name == _FormName)
						{
							_Form.BringToFront();
						}
					}
				}
				catch (Exception _Exception)
				{
					_Debug.Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				}
			}
			#endregion Bring To Front
		}



		/// <summary>MessageBox tweaks.</summary>
		public class MessageBox : Controls
		{
			#region Show Confirmation Dialog
			/// <summary>Shows a MessageBox with yes and no options.</summary>
			/// <param name="_Title">The title of the confirmation dialog.</param>
			/// <param name="_Message">The message to be displayed in the confirmation dialog.</param>
			/// <param name="_Icon">Icon of the confirmation dialog.</param>
			public bool ShowConfirmationDialog(string _Title, string _Message, MessageBoxIcon? _Icon = null)
			{
				DialogResult _Dialog;

				if (_Icon != null)
				{
					_Dialog = System.Windows.Forms.MessageBox.Show(_Message, _Title, MessageBoxButtons.YesNo, (MessageBoxIcon)_Icon);
				}
				else
				{
					_Dialog = System.Windows.Forms.MessageBox.Show(_Message, _Title, MessageBoxButtons.YesNo);
				}

				if (_Dialog == DialogResult.Yes)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			#endregion Show Confirmation Dialog
		}
	}
}
