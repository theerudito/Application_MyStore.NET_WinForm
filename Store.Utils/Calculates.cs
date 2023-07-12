namespace Store.Utils
{
    public static class Calculates
    {
        public static int Cant_Text(int quantity)
        {
            return quantity;
        }

        public static decimal PUnitary_Text(decimal pUnitary)
        {
            var twoDecimal = pUnitary.ToString("F2");
            return Convert.ToDecimal(twoDecimal);
        }

        public static int Descuent_Text(int descuent)
        {
            return descuent;
        }

        public static string PVP_Text(int quantity, decimal pUnitary, int descuent)
        {
            var calulate = quantity * pUnitary;
            return calulate.ToString("F2");
        }

        #region Calculate Total

        public static string Subtotal_Text(decimal ptotal, decimal iva)
        {
            var subtotal = ptotal / iva;
            return subtotal.ToString("F2");
        }

        public static string SubtotalZero_Text(decimal val)
        {
            return val.ToString("F2");
        }

        public static string SubtotalTwelve_Text(decimal val)
        {
            return val.ToString("F2");
        }

        public static string Iva_Text(string val)
        {
            return val.ToString();
        }

        public static string DescuentText(string val)
        {
            return val.ToString();
        }

        public static string Total(decimal subtotal, decimal iva)
        {
            var total = subtotal + iva;
            return total.ToString("F2");
        }

        #endregion Calculate Total
    }
}