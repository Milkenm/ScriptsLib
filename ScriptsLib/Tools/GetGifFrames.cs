#region Usings
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

using static ScriptsLib.Dev;
#endregion Usings



namespace ScriptsLib
{
	public static partial class Tools
	{
		/// <summary>Get frames from a GIF image.</summary>
		/// <param name="_Gif">The GIF image to get the frames from.</param>
		public static Image[] GetGifFrames(Image _Gif)
		{
			try
			{
				int _FramesNumber = _Gif.GetFrameCount(FrameDimension.Time);
				Image[] _Frames = new Image[_FramesNumber];

				Task.Factory.StartNew(() =>
				{
					for (int i = 0; i < _FramesNumber; i++)
					{
						_Gif.SelectActiveFrame(FrameDimension.Time, i);
						_Frames[i] = (Image)_Gif.Clone();
					}
				}).GetAwaiter().GetResult();

				return _Frames;
			}
			catch (Exception _Exception)
			{
				Msg(_Exception.Message, MsgType.Error, _Exception.Source);
				return null;
			}
		}
	}
}
