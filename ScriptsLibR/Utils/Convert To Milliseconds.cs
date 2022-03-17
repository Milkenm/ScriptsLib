namespace ScriptsLibR.Utils
{
    public partial class Utils
    {
        public static long ConvertToMilliseconds(long seconds = 0, long minutes = 0, long hours = 0, long days = 0)
        {
            return (seconds * 1000) + (minutes * 60000) + (hours * 3600000) + (days * 86400000);
        }
    }
}
