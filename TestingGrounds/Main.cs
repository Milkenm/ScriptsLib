#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScriptsLib.Controls;
using ScriptsLib.Databases;
using ScriptsLib.Generators;
using ScriptsLib.Network;
using ScriptsLib.Tools;
#endregion Usings



namespace TestingGrounds
{
	public partial class Main : Form
	{
		#region Refs
		// # ================================================================================================ #
		SqlServerDatabase _SqlDatabase = new SqlServerDatabase();
		AccessDatabase _AccessDatabase = new AccessDatabase();
		MySqlDatabase _MySqlDatabase = new MySqlDatabase();
		
		Tools _Tools = new Tools();
		Tools.DatabaseTools _DatabaseTools = new Tools.DatabaseTools();
		Generators _Generators = new Generators();
		ScriptsLib.Math.Math _Math = new ScriptsLib.Math.Math();
		Network.Packets _Packets = new Network.Packets();

		Controls.ComboBox _ComboBox = new Controls.ComboBox();
		Controls.TextBox _TextBox = new Controls.TextBox();
		Controls.Form _Form = new Controls.Form();
		Controls.MessageBox _MessageBox = new Controls.MessageBox();
		// # ================================================================================================ #
		#endregion Refs

		#region Form
		// # ================================================================================================ #
		public Main()
		{
			InitializeComponent();
		}
		// # ================================================================================================ #
		private void Main_Load(object sender, EventArgs e)
		{
			_Form.SetIntroForm(this, 0.035, false);


			ScriptsLib.Dev.Debug._Debug = true;
			ScriptsLib.Dev.Debug._ErrorsOnly = true;

			fileDialog_tg_searchGif.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


			SqlServerDatabase._DatabasePath = @"C:\Milkenm\Data\Tests.mdf";

			AccessDatabase._DatabasePath = @"C:\Milkenm\Data\TestsAccess.mdb";

			MySqlDatabase._Server = "127.0.0.1";
			MySqlDatabase._Port = 3306;
			MySqlDatabase._Database = "test";
			MySqlDatabase._User = "root";
			MySqlDatabase._Password = "";
			MySqlDatabase._SslMode = "none";



			#region Perform Actions
			textBox_tools_databaseTools_checkLogin_user.Text = "User1";
			textBox_tools_databaseTools_checkLogin_pass.Text = "Pass1";

			textBox_generators_generatePassword_password.Text = _Generators.GeneratePassword((int)numeric_generators_generatePassword_length.Value);

			textBox_tools_databaseTools_filterSql_text.Text = "ABC;DEF;GHI'JKL'MNO";

			comboBox_tg_databaseType.SelectedIndex = 2;

			comboBox_tools_log_logType.SelectedIndex = 0;
			_ComboBox.Resize(comboBox_tools_log_logType, 20);

			button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {button_controls_comboBox_resizeComboBox_resize.Height} | {comboBox_controls_comboBox_resizeComboBox_resize.Height}";

			textBox_tools_databaseTools_selectUnique_table.Text = "Unique";
			textBox_tools_databaseTools_selectUnique_column.Text = "Value";

			checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked = true;

			textBox_tg_version.Text = ScriptsLib.Info.Info._Version;
			#endregion Perform Actions
		}
		// # ================================================================================================ #
		#endregion Form

		#region Stuff
		// # ================================================================================================ #
		private void Ex(Exception _Exception)
		{
			MessageBox.Show(_Exception.Message, _Exception.Source);
		}
		// # ================================================================================================ #
		#endregion Stuff










		#region Database
		// # ================================================================================================ #
		private void button_criarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					List<SqlServerDatabase.TableFields> _Fields = new List<SqlServerDatabase.TableFields>();
					SqlServerDatabase.TableFields _Field = new SqlServerDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Number;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = SqlServerDatabase.SqlDataTypes.Text;
					_Fields.Add(_Field);


					_SqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_tg_databaseType.SelectedIndex == 1)
				{
					List<AccessDatabase.TableFields> _Fields = new List<AccessDatabase.TableFields>();
					AccessDatabase.TableFields _Field = new AccessDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = AccessDatabase.AccessDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = AccessDatabase.AccessDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = AccessDatabase.AccessDataTypes.Text;
					_Fields.Add(_Field);


					_AccessDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				else if (comboBox_tg_databaseType.SelectedIndex == 2)
				{
					List<MySqlDatabase.TableFields> _Fields = new List<MySqlDatabase.TableFields>();
					MySqlDatabase.TableFields _Field = new MySqlDatabase.TableFields();


					_Field.Name = "ID";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Key;
					_Fields.Add(_Field);

					_Field.Name = "Name";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
					_Fields.Add(_Field);

					_Field.Name = "Password";
					_Field.DataType = MySqlDatabase.MySqlDataTypes.Text;
					_Fields.Add(_Field);


					_MySqlDatabase.CreateTable("Users", _Fields).GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_apagarTabela_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_SqlDatabase.DeleteTable("Users").GetAwaiter();
				}
				else
				{
					_AccessDatabase.DeleteTable("Users").GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_insert_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_SqlDatabase.InsertInto("Users", "ID, Name, Password", "1, 'User1', 'Pass1'").GetAwaiter();
				}
				else
				{
					_AccessDatabase.InsertInto("[Users]", "[Name], [Password]", "'User1', 'Pass1'").GetAwaiter();
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_criarBd_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_SqlDatabase.CreateDatabase(@"C:\Milkenm\Data\Tests.mdf").GetAwaiter();
				}
				else
				{
					MessageBox.Show("There is no 'Create Database' yet.");
					return;
				}
				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_select_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					foreach (var _Loop in _SqlDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
				else
				{
					foreach (var _Loop in _AccessDatabase.Select("Users"))
					{
						MessageBox.Show($"{_Loop}", "Selected values");
					}
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void button_delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_SqlDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}
				else // Access MDB
				{
					_AccessDatabase.Delete("Users", "ID = 1").GetAwaiter();
				}

				MessageBox.Show("Done.");
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Database



		#region Tools
		#region Database Tools
		#region Check Login
		// # ================================================================================================ #
		private void button_login_Click(object sender, EventArgs e)
		{
			try
			{
				bool _Success;
				if (comboBox_tg_databaseType.SelectedIndex == 0) // SQL Server
				{
					_Success = _DatabaseTools.CheckLogin("Users", textBox_tools_databaseTools_checkLogin_user.Text, textBox_tools_databaseTools_checkLogin_pass.Text, "Name", "Password", Tools.DatabaseTools.DatabaseType.SqlServer);
				}
				else
				{
					_Success = _DatabaseTools.CheckLogin("Users", textBox_tools_databaseTools_checkLogin_user.Text, textBox_tools_databaseTools_checkLogin_pass.Text, "Name", "Password", Tools.DatabaseTools.DatabaseType.Access);
				}

				if (_Success == true)
				{
					MessageBox.Show("Logged in.");
				}
				else
				{
					MessageBox.Show("Invalid login credentials.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Check Login



		#region SQL Filter
		// # ================================================================================================ #
		private void button_sqlFilter_Click(object sender, EventArgs e)
		{
			try
			{
				textBox_tools_databaseTools_filterSql_text.Text = _DatabaseTools.FilterSql(textBox_tools_databaseTools_filterSql_text.Text);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion SQL Filter



		#region Select Unique
		// # ================================================================================================ #
		private void button_selectUnique_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tg_databaseType.SelectedIndex == 1)
				{
					List<string> _Select = _DatabaseTools.SelectUnique(textBox_tools_databaseTools_selectUnique_table.Text, textBox_tools_databaseTools_selectUnique_column.Text, Tools.DatabaseTools.DatabaseType.Access);

					string _String = null;
					foreach (string _Value in _Select)
					{
						if (!String.IsNullOrEmpty(_String))
						{
							_String = $"{_String}, {_Value}";
						}
						else
						{
							_String = _Value;
						}
					}

					MessageBox.Show(_String);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Select Unique
		#endregion Database Tools



		#region Crash
		// # ================================================================================================ #
		private void button_crash_Click(object sender, EventArgs e)
		{
			_Tools.Crash().GetAwaiter();
		}
		// # ================================================================================================ #
		#endregion Crash



		#region Log
		// # ================================================================================================ #
		private void button_log_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_tools_log_logType.SelectedIndex == 0) // INFO
				{
					_Tools.Log(textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_tools_log_logSource.Text, Tools.LogType.Info).GetAwaiter();
				}
				else if (comboBox_tools_log_logType.SelectedIndex == 1) // ERROR
				{
					_Tools.Log(textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_tools_log_logSource.Text, Tools.LogType.Error).GetAwaiter();
				}
				else if (comboBox_tools_log_logType.SelectedIndex == 2) // WARNING
				{
					_Tools.Log(textBox_tools_log_logMessage.Text, @"C:\Milkenm\Data\ScriptsLib Log.txt", textBox_tools_log_logSource.Text, Tools.LogType.Warning).GetAwaiter();
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Log



		#region Hash
		// # ================================================================================================ #
		private void button_hash_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_Tools.Hash(textBox_tools_hash_text.Text));
		}
		// # ================================================================================================ #
		private void textBox_hash_TextChanged(object sender, EventArgs e)
		{
			textBox_tools_hash_hashed.Text = _Tools.Hash(textBox_tools_hash_text.Text);
		}
		// # ================================================================================================ #
		#endregion Hash



		#region Get Date
		// # ================================================================================================ #
		private void timer_date_Tick(object sender, EventArgs e)
		{
			label_tools_getDate_date.Text = _Tools.GetDate();
		}
		// # ================================================================================================ #
		#endregion Get Date



		#region Set Wallpaper & Get GIF Frames
		// # ================================================================================================ #
		static Image[] _Frames;
		// # ================================================================================================ #
		private void button_searchGif_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog_tg_searchGif.ShowDialog();
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void fileDialog_searchGif_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!String.IsNullOrEmpty(fileDialog_tg_searchGif.FileName))
			{
				_Frames = _Tools.GetGifFrames(Image.FromFile(fileDialog_tg_searchGif.FileName));

				UseGifFrames();
			}
		}
		// # ================================================================================================ #
		void UseGifFrames()
		{
			foreach (Image _Frame in _Frames)
			{
				pictureBox_tools_setWallpaper6getGifFrames_gif.BackgroundImage = _Frame;
			}
		}
		// # ================================================================================================ #
		private void button_setWallpaper_Click(object sender, EventArgs e)
		{
			Task.Factory.StartNew(() =>
			{
				while (true)
				{
					foreach (Image _Frame in _Frames)
					{
						_Tools.SetWallpaper(_Frame, Tools.WallpaperStyle.Centered).GetAwaiter();
					}
				}
			});
		}
		// # ================================================================================================ #
		#endregion Set Wallpaper & Get GIF Frames



		#region Get Text File Content
		// # ================================================================================================ #
		private void button_readfile_Click(object sender, EventArgs e)
		{
			try
			{
				fileDialog_tg_readFile.ShowDialog();
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		private void fileDialog_readFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileDialog_tg_readFile.FileName))
				{
					MessageBox.Show(_Tools.GetTextFileContent(fileDialog_tg_readFile.FileName), "Read File");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Get Text File Content



		#region Replace String
		// # ================================================================================================ #
		private void button_replace_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(_Tools.ReplaceString(textBox_tools_replaceString_original.Text, textBox_tools_replaceString_replace.Text, textBox_tools_replaceString_replacewith.Text));
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Replace String
		#endregion Tools



		#region Generators
		#region Generate Password
		// # ================================================================================================ #
		private void button_generatePassword_Click(object sender, EventArgs e)
		{
			try
			{
				textBox_generators_generatePassword_password.Text = _Generators.GeneratePassword((int)numeric_generators_generatePassword_length.Value);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Generate Password
		#endregion Generators



		#region Controls
		#region ComboBox
		#region Resize ComboBox
		// # ================================================================================================ #
		private void button_resizeCombobox_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_controls_comboBox_resizeComboBox_resize.Height == 37)
				{
					_ComboBox.Resize(comboBox_controls_comboBox_resizeComboBox_resize, 21);
				}
				else
				{
					_ComboBox.Resize(comboBox_controls_comboBox_resizeComboBox_resize, 37);
				}

				button_controls_comboBox_resizeComboBox_resize.Text = $"Resize {button_controls_comboBox_resizeComboBox_resize.Height} | {comboBox_controls_comboBox_resizeComboBox_resize.Height}";
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Resize ComboBox
		#endregion ComboBox



		#region TextBox
		#region Only Numbers TextBox
		// # ================================================================================================ #
		private void checkBox_onlyNumbers_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (checkBox_controls_textBox_onlyNumbersTextBox_onlyNumbers.Checked == true)
				{
					_TextBox.OnlyNumbers(textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false);
				}
				else
				{
					_TextBox.OnlyNumbers(textBox_controls_textBox_onlyNumbersTextBox_onlyNumbers, false, false);
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Only Numbers TextBox
		#endregion TextBox



		#region Form
		#region Get Open Forms
		// # ================================================================================================ #
		private void button_controls_getOpenForms_Click(object sender, EventArgs e)
		{
			try
			{
				_Form.GetOpenForms();
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Get Open Forms
		#endregion Form



		#region MessageBox
		#region Show Confirmation Dialog
		// # ================================================================================================ #
		private void button_showConfirmationDialog_Click(object sender, EventArgs e)
		{
			try
			{
				bool _Confirm = _MessageBox.ShowConfirmationDialog("Title", "Message", MessageBoxIcon.Information);

				if (_Confirm == true)
				{
					MessageBox.Show("Accepted!");
				}
				else
				{
					MessageBox.Show("Declined.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Show Confirmation Dialog
		#endregion MessageBox
		#endregion Controls



		#region Network
		#region Wifi
		// # ================================================================================================ #
		private void button_connect_Click(object sender, EventArgs e)
		{
			try
			{
				if (!String.IsNullOrEmpty(textBox_network_wifi_connect_wifiPassword.Text) && !String.IsNullOrEmpty(textBox_network_wifi_connect_wifiSsid.Text))
				{
					Network.Wifi _Wifi = new Network.Wifi();
					_Wifi.Connect(textBox_network_wifi_connect_wifiSsid.Text, textBox_network_wifi_connect_wifiPassword.Text);
				}
				else
				{
					MessageBox.Show("Fill all fields.");
				}
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Wifi



		#region Packets
		#region Send TCP Packet
		// # ================================================================================================ #
		private void button_network_packets_sendTcpPacket_Click(object sender, EventArgs e)
		{
			_Packets.SendTcpPacket("127.0.0.1", 69, "Hey mamfsdfs");
		}
		// # ================================================================================================ #
		#endregion Send TCP Packet



		#region Wait TCP Packet
		// # ================================================================================================ #
		private void button_network_packets_waitTcpPacket_Click(object sender, EventArgs e)
		{
			new Task(new Action(() =>
			{
				while (true)
				{
					MessageBox.Show("Received: \n\n\n" + _Packets.WaitTcpPacket(IPAddress.Parse("127.0.0.1"), 69), "Wait TCP Packet");
				}
			})).Start();
		}
		// # ================================================================================================ #
		#endregion Wait TCP Packet



		#region Send UDP Packet
		// # ================================================================================================ #
		private void button_network_packets_sendUdpPacket_Click(object sender, EventArgs e)
		{

		}
		// # ================================================================================================ #
		#endregion Send UDP Packet



		#region Wait UDP Packet
		// # ================================================================================================ #
		private void button_network_packets_waitUdpPacket_Click(object sender, EventArgs e)
		{

		}
		// # ================================================================================================ #
		#endregion Wait UDP Packet
		#endregion Packets
		#endregion Network



		#region Math
		#region Calculate Combinations
		// # ================================================================================================ #
		private void button_calculate_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(_Math.CalculateCombinations((BigInteger)numeric_math_calculateCombinations_elements.Value, (BigInteger)numeric_math_calculateCombinations_group.Value).ToString(), "Result", MessageBoxButtons.OK);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}
		// # ================================================================================================ #
		#endregion Calculate Combinations



		#region Calculate Factorial
		// # ================================================================================================ #
		private void button_calculateFactorial_Click(object sender, EventArgs e)
		{
			try
			{
				MessageBox.Show(_Math.CalculateFactorial((ulong)numeric_math_calculateFactorial_factorial.Value).ToString(), "Result", MessageBoxButtons.OK);
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		// # ================================================================================================ #
		#endregion Calculate Factorial
		#endregion Math
	}
}