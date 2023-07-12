namespace Store.Presentador
{
    public static class ValidationFields
    {
        public static bool ValidacionFieldsToCart(List<string> fields)
        {
            if (string.IsNullOrEmpty(fields[0]))
            {
                MessageBox.Show("El codigo es requerido");
                if (fields[0].Length > 5)
                {
                    MessageBox.Show("El codigo debe tener un máximo de 10 caracteres");
                }
                return false;
            }
            else if (string.IsNullOrEmpty(fields[1]))
            {
                MessageBox.Show("La cantidad es requerida");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[2]))
            {
                MessageBox.Show("El precio unitario es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[3]))
            {
                MessageBox.Show("El descuento es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[4]))
            {
                MessageBox.Show("El precio total es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldsClient(List<string> fields)
        {
            if (string.IsNullOrEmpty(fields[0]))
            {
                MessageBox.Show("El campo numero de RUC o CI es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[1]))
            {
                MessageBox.Show("El campo nombre es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[2]))
            {
                MessageBox.Show("El campo apellido es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[3]))
            {
                MessageBox.Show("El campo dirección es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[4]))
            {
                MessageBox.Show("El campo teléfono es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[5]))
            {
                MessageBox.Show("El campo email es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[6]))
            {
                MessageBox.Show("El campo ciudad es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldsProduct(List<string> fields)
        {
            if (string.IsNullOrEmpty(fields[0]))
            {
                MessageBox.Show("El campo nombre del producto es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[1]))
            {
                MessageBox.Show("El campo codigo del producto es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[2]))
            {
                MessageBox.Show("El campo marca del producto es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[3]))
            {
                MessageBox.Show("El campo categoria del producto es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[4]))
            {
                MessageBox.Show("El campo descripción del producto es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[5]))
            {
                MessageBox.Show("El campo precio del producto es requerido y debe ser un número válido.");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[6]))
            {
                MessageBox.Show("El campo cantidad del producto es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldsCompany(List<string> fields)
        {
            if (string.IsNullOrEmpty(fields[0]))
            {
                MessageBox.Show("El campo nombre de empresa es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[1]))
            {
                MessageBox.Show("El campo nombre de propietario es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationCodeApp(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("El Campo codigo es Requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldSearch(string seaching)
        {
            if (string.IsNullOrEmpty(seaching))
            {
                MessageBox.Show("El campo de busqueda es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldsdAuthRegister(string user, string email, string password)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("El campo usuario es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo email es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo contraseña es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldUsers(List<string> fields)
        {
            if (string.IsNullOrEmpty(fields[0]))
            {
                MessageBox.Show("El campo nombre es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[1]))
            {
                MessageBox.Show("El campo username es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[2]))
            {
                MessageBox.Show("El campo email es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[3]))
            {
                MessageBox.Show("El campo contraseña es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[4]))
            {
                MessageBox.Show("El campo telefono es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[5]))
            {
                MessageBox.Show("El campo dirección es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(fields[6]))
            {
                MessageBox.Show("El campo rol es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationFieldsdAuthLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("El campo usuario es requerido");
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo contraseña es requerido");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}