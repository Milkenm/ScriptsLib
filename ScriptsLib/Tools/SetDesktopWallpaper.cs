using Microsoft.Win32;

using ScriptsLib.PInvoke;

using System.Drawing;
using System.IO;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Sets the desktop wallpaper.</summary>
		/// <param name="wallpaper">The image to be set as wallpaper.</param>
		/// <param name="style">How the imagem is going to be resized to fit the screen.</param>
		public static void SetDesktopWallpaper(Image wallpaper, WallpaperStyle style)
		{
			string tempPath = Path.GetTempPath() + "MWallpaper";
			wallpaper.Save(tempPath);

			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

			switch (style)
			{
				case WallpaperStyle.Stretched:
					key.SetValue("WallpaperStyle", 2.ToString());
					key.SetValue("TileWallpaper", 0.ToString());
					break;

				case WallpaperStyle.Centered:
					key.SetValue("WallpaperStyle", 1.ToString());
					key.SetValue("TileWallpaper", 0.ToString());
					break;

				case WallpaperStyle.Tiled:
					key.SetValue("WallpaperStyle", 1.ToString());
					key.SetValue("TileWallpaper", 1.ToString());
					break;
			}

			User32.SystemParametersInfo(20, 0, tempPath, 0x01 | 0x02);

			File.Delete(tempPath);
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
}