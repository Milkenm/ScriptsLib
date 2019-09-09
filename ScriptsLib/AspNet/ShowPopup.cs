#region Usings
using System.Web.UI;
#endregion Usings



namespace ScriptsLib
{
	public static partial class AspNet
	{
		#region Show Pop-up
		///
		// https://stackoverflow.com/questions/16287515/how-to-get-a-server-side-asp-page-to-display-a-pop-up-message-in-the-clients-br
		///

		/// <summary>Shows a pop-up message on an ASP.NET application.</summary>
		/// <param name="_Page">The page used to send the pop-up.</param>
		/// <param name="_Message">The message to be displayed in the pop-up.</param>
		public static void ShowPopup(Page _Page, string _Message)
		{
			_Page.Response.Write($"<script language=javascript>alert('{_Message}')</script>");
		}
		#endregion Show Pop-up
	}
}
