using System.Web.UI;

namespace ScriptsLib
{
	public static class AspNet
	{
		/// <summary>Shows a pop-up message on an ASP.NET application.</summary>
		/// <param name="page">The page to send the pop-up to.</param>
		/// <param name="message">The message to be displayed in the pop-up.</param>
		/// https://stackoverflow.com/a/16302541
		public static void ShowPopup(Page page, string message)
		{
			page.Response.Write($"<script language=javascript>alert('{message}')</script>");
		}
	}
}