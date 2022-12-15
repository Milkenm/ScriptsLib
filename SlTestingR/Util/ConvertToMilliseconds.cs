using NUnit.Framework;

using ScriptsLibR.Util;

namespace SlTestingR.TEST_Utils
{
	internal class ConvertToMilliseconds
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
			Assert.AreEqual(milliseconds, ExpectedMilliseconds);
		}
	}
}
