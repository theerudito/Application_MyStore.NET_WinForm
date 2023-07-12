using Store.Database;
using Store.Presentador.Auth;
using Store.Utils;

namespace Store.Presentador
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmAuth());

            InitialValuesData();
        }

        public static void InitialValuesData()
        {
            int IdCompany = 1;
            var data = new InitialValues();

            using (var context = new Application_ContextDB())
            {
                var query = context.Company.Find(IdCompany);

                if (query == null)
                {
                    data.newCompany();
                }
            }
        }
    }
}