#region Usings
using System.Web.UI;
#endregion Usings



namespace ScriptsLib.AspNet
{
	public class AspNet
	{
		#region Show Pop-up
		/// <summary>Shows a pop-up message on an ASP.NET application.</summary>
		/// <param name="_Page">The page used to send the pop-up.</param>
		/// <param name="_Message">The message to be displayed in the pop-up.</param>
		public void ShowPopup(Page _Page, string _Message)
		{
			_Page.Response.Write("<script language=javascript>alert('Message here.')</script>");
		}
		#endregion Show Pop-up
	}
}
