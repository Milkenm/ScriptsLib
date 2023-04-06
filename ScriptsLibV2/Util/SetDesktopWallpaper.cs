using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using Microsoft.Win32;

using ScriptsLibV2.PInvoke;

namespace ScriptsLibV2.Util
{
	public static partial class Utils
	{
		/// <summary>Sets the desktop wallpaper.</summary>
		/// <param name="wallpaper">The image to be set as wallpaper.</param>
		/// <param name="style">How the imagem is going to be resized to fit the screen.</param>
		public static void SetDesktopWallpaper(Image wallpaper, WallpaperStyle style)
		{
			string tempPath = Path.GetTempPath() + "SlWallpaper.png";
			wallpaper.Save(tempPath, ImageFormat.Png);

			SetDesktopWallpaper(tempPath, style);

			File.Delete(tempPath);
		}

		public static void SetDesktopWallpaper(string wallpaperPath, WallpaperStyle style)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

			switch (style)
			{
				case WallpaperStyle.Stretched:
					{
						key.SetValue("WallpaperStyle", "2");
						key.SetValue("TileWallpaper", "0");
						break;
					}
				case WallpaperStyle.Centered:
					{
						key.SetValue("WallpaperStyle", "1");
						key.SetValue("TileWallpaper", "0");
						break;
					}
				case WallpaperStyle.Tiled:
					{
						key.SetValue("WallpaperStyle", "1");
						key.SetValue("TileWallpaper", "1");
						break;
					}
			}

			User32.SystemParametersInfo(20, 0, wallpaperPath, 0x01 | 0x02);
		}
	}

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
}
