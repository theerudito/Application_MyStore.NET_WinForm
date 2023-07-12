namespace Store.Presentador
{
    public static class ValidateDataType
    {
        public static void IsString(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("el tipo de dato debe ser numero");
                e.Handled = true;
            }
        }

        // un metodo para que aceptes tipo de dato float
        public static void IsFloat(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("El tipo de dato debe ser un número entero o decimal");
                e.Handled = true;
            }
        }
    }
}