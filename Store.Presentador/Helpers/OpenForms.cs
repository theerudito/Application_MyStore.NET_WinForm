namespace Store.Presentador
{
    public static class OpenForms
    {
        public static bool isOpenForm(string nameForm)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == nameForm)
                {
                    form.BringToFront();
                    isOpen = true;
                    break;
                }
            }
            return isOpen;
        }
    }
}