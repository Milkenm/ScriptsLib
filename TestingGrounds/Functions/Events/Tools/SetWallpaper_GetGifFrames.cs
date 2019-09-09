﻿#region Usings
using System;
using System.Drawing;
using System.Threading.Tasks;

using ScriptsLib;

using static TestingGrounds.Functions;
using static TestingGrounds.Values;
#endregion Usings



namespace TestingGrounds
{
	internal static partial class Events
	{
		internal static Image[] _Frames;

		internal static void Event_SearchGif()
		{
			try
			{
				_MainForm.fileDialog_tg_searchGif.ShowDialog();
			}
			catch (Exception _Exception)
			{
				Ex(_Exception);
			}
		}

		internal static void Event_FileDialogSearchGifOk()
		{
			if (!String.IsNullOrEmpty(_MainForm.fileDialog_tg_searchGif.FileName))
			{
				_Frames = Tools.GetGifFrames(Image.FromFile(_MainForm.fileDialog_tg_searchGif.FileName));

				foreach (Image _Frame in _Frames)
				{
					_MainForm.pictureBox_tools_setWallpaper6getGifFrames_gif.BackgroundImage = _Frame;
				}
			}
		}

		internal static void Event_ToolsSetWallpaper()
		{
			Task.Factory.StartNew(() =>
			{
				while (true)
				{
					foreach (Image _Frame in _Frames)
					{
						Tools.SetDesktopWallpaper(_Frame, Tools.WallpaperStyle.Centered).GetAwaiter();
					}
				}
			});
		}
	}
}