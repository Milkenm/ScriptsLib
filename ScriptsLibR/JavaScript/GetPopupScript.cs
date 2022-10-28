namespace ScriptsLibR.JavaScript
{
    public partial class JavaScript
    {
        public string GetPopupScript(string message)
        {
            return $"<script language=javascript>alert('{message}')</script>";
        }
    }
}
