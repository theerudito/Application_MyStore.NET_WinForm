namespace Store.Utils
{
    public static class SystemTime
    {
        public static string DateNow()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public static string HourNow()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
}