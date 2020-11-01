using System.Drawing;
using System.Drawing.Imaging;

namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Get frames from a GIF image.</summary>
		/// <param name="gif">The GIF image to get the frames from.</param>
		public static Image[] GetGifFrames(Image gif)
		{
			int frameCount = gif.GetFrameCount(FrameDimension.Time);
			Image[] frames = new Image[frameCount];

			for (int i = 0; i < frameCount; i++)
			{
				gif.SelectActiveFrame(FrameDimension.Time, i);
				frames[i] = (Image)gif.Clone();
			}

			return frames;
		}
	}
}
