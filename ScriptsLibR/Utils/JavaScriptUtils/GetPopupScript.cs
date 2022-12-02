namespace ScriptsLibR.Utils
{
    public partial class JavaScriptUtils
    {
        public string GetPopupScript(string message)
        {
            return $"<script language=javascript>alert('{message}')</script>";
        }
    }
}
