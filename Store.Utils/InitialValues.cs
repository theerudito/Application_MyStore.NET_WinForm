using Store.Database;
using Store.Models;

namespace Store.Utils
{
    public class InitialValues
    {
        private Application_ContextDB _contextDB = new Application_ContextDB();

        public async void newCompany()
        {
            var addCompany = new MCompany
            {
                IdCompany = 1,
                CompanyName = "HEAVEN INC",
                OwnerCompany = "JORGE LOOR",
                DirectionCompany = "POCHINKI CERCA DE SCHOOL",
                EmailCompany = "erudito.tv@gmail.pung",
                DNICompany = "123456789",
                PhoneCompany = "09999999",
                NumDocumentCompany = "123456789",
                SerieOneCompany = "001",
                SerieTwoCompany = "002",
                DataBaseName = "SQLITE",
                TypeDocument = "FACTURA",
                IvaCompany = 0.12m,
                CoinCompany = "DOLLAR",
            };

            var client = new MClients
            {
                IdClient = 1,
                DNI = "9999999999",
                FisrtName = "CONSUMIDOR",
                LastName = " FINAL",
                Direction = "SN",
                Phone = "9999999999",
                Email = "admin@email.com",
                City = "SIN CIUDAD",
                Status = true
            };

            var newProduct = new MProducts
            {
                IdProduct = 1,
                NameProduct = "PRODUCTO PRUEBA",
                CodeProduct = "123",
                Brand = "SIN MARCA",
                Category = "SIN CATEGORIA",
                Description = "DESCRIPCION DEL PRODUCTO",
                PriceUnitary = 1.00m,
                Quantity = 10,
                Status = true,
                Iva = true
            };

            var newUser = new MAuth
            {
                IdAuth = 1,
                User = "Jorge",
                UserName = "theboss",
                Email = "erudito.tv@gmail.com",
                Password = CodeApplication.EncriptarUser(),
                Direction = "Santo Domingo Ecuador",
                Phone = "0960806054",
                Role = "Administrador",
                Status = true,
            };

            var appCode = new MCode
            {
                IdCode = 1,
                Code = CodeApplication.EncriptarCode(),
            };

            var newCity = new MCity
            {
                IdCity = 1,
                City = "SIN CIUDAD"
            };

            var newBrand = new MBrand
            {
                IdBrand = 1,
                Brand = "SIN MARCA"
            };

            var newCategory = new MCategory
            {
                IdCategory = 1,
                Category = "SIN CATEGORIA"
            };

            _contextDB.Company.Add(addCompany);
            _contextDB.Client.Add(client);
            _contextDB.Product.Add(newProduct);
            _contextDB.Product.Add(newProduct);
            _contextDB.AppCode.Add(appCode);
            _contextDB.Auth.Add(newUser);
            _contextDB.Cities.Add(newCity);
            _contextDB.Brands.Add(newBrand);
            _contextDB.Categories.Add(newCategory);

            await _contextDB.SaveChangesAsync();
        }
    }
}