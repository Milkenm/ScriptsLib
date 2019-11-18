#region Usings
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using Microsoft.Win32;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		/// <summary>Sets the desktop wallpaper.</summary>
		/// <param name="_Image">The image to be set as wallpaper.</param>
		/// <param name="_WallpaperStyle">How the imagem is going to be resized to fit the screen.</param>
		public static async Task SetDesktopWallpaper(Image _Image, WallpaperStyle _WallpaperStyle)
		{
			await Task.Factory.StartNew(() =>
			{
				string _TempPath = Path.GetTempPath() + @"MWallpaper";
				_Image.Save(_TempPath);

				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
				if (_WallpaperStyle == WallpaperStyle.Stretched)
				{
					key.SetValue(@"WallpaperStyle", 2.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_WallpaperStyle == WallpaperStyle.Centered)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 0.ToString());
				}
				if (_WallpaperStyle == WallpaperStyle.Tiled)
				{
					key.SetValue(@"WallpaperStyle", 1.ToString());
					key.SetValue(@"TileWallpaper", 1.ToString());
				}

				SystemParametersInfo(20, 0, _TempPath, 0x01 | 0x02);

				File.Delete(_TempPath);
			});
		}


		#region Enums
		/// <summary>Types of wallpaper.</summary>
		public enum WallpaperStyle
		{
			/// <summary>The image is tiled across the screen.</summary>
			Tiled,
			/// <summary>The image is centered on the screen.</summary>
			Centered,
			/// <summary>The image is steched to fit the screen.</summary>
			Stretched,
		}
		#endregion Enums
	}
}
