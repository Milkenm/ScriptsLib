using System.Net;

namespace ScriptsLibR.Extensions
{
	public static partial class WebResponseExtensions
	{
		public static HttpStatusCode GetStatusCode(this WebResponse response, bool throwExceptions)
		{
			HttpStatusCode statusCode;

			try
			{
				HttpWebResponse httpResponse = (HttpWebResponse)response;
				statusCode = httpResponse.StatusCode;
			}
			catch (WebException ex)
			{
				if (throwExceptions)
				{
					throw ex;
				}

				// https://stackoverflow.com/a/4700154
				statusCode = ((HttpWebResponse)ex.Response).StatusCode;
			}

			return statusCode;
		}

		public static HttpStatusCode GetStatusCode(this WebResponse response)
		{
			return GetStatusCode(response, false);
		}
	}
}
