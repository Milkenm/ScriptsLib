using NUnit.Framework;

using ScriptsLibV2.Util;

namespace Util
{
	internal class Util_ConvertToMilliseconds
	{
		private readonly long Days = 2L;
		private readonly long Hours = 3L;
		private readonly long Minutes = 4L;
		private readonly long Seconds = 5L;
		private readonly long ExpectedMilliseconds = 183845000L;

		[Test]
		public void TEST_ConvertToMilliseconds()
		{
			long milliseconds = Utils.ConvertToMilliseconds(Seconds, Minutes, Hours, Days);
			Assert.AreEqual(ExpectedMilliseconds, milliseconds);
		}
	}
}
