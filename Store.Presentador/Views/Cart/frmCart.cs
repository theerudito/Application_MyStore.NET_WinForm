using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;
using Store.Utils;

namespace Store.Presentador.Cart
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();

            LoadDataCompany();
            LoadCliFinal();

            dateTimePicker.Text = SystemTime.DateNow();

            labelHour.Text = SystemTime.HourNow();
        }

        #region Clients

        private int _idClient;

        #endregion Clients

        #region Products

        private int idProduct;

        #endregion Products

        public void LoadClient(string dni)
        {
            textDNICart.Text = dni;
        }

        private int rowIndex = 0;

        private string _idProductDataGrid;
        private int _productquantityDataGrid;
        private string _productNameDataGrid;
        private string _productCodeDataGrid;
        private string _productDescriptionDataGrid;
        private string _productBrandDataGrid;

        private decimal _productPUnitaryDataGrid;
        private int _productPDescuentDataGrid;
        private decimal _productPTotalDataGrid;

        private decimal _ivaCompany;
        private decimal _labelSubFac;
        private decimal _labelSub0Fac;
        private decimal _labelSub12Fac;
        private decimal _labelDescFac;
        private decimal _labelIvaFac;
        private decimal _labelTotalFac;

        public async void LoadDataCompany()
        {
            var _contextDB = new Application_ContextDB();

            var queryCompany = await _contextDB.Company.FindAsync(1);

            textNumDocumentCart.Text = queryCompany.NumDocumentCompany.ToString();

            textSerieOneCart.Text = queryCompany.SerieOneCompany.ToString();

            textSerieTwoCart.Text = queryCompany.SerieTwoCompany.ToString();

            labelIva.Text = "IVA " + queryCompany.IvaCompany.ToString() + "%";

            _ivaCompany = queryCompany.IvaCompany;
        }

        public async void LoadCliFinal()
        {
            var _contextDB = new Application_ContextDB();

            var queryClientFinal = await _contextDB.Client.FindAsync(1);

            textDNICart.Text = queryClientFinal.DNI.ToString();

            textPhoneCart.Text = queryClientFinal.Phone.ToString();

            textFirstNameCart.Text = queryClientFinal.FisrtName;

            textLastNameCart.Text = queryClientFinal.LastName;

            textAddressCart.Text = queryClientFinal.Direction;

            textEmailCart.Text = queryClientFinal.Email;

            _idClient = queryClientFinal.IdClient;

            idClient.Text = _idClient.ToString();
        }

        private async void textDNICart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var _contextDB = new Application_ContextDB();

                var dniClient = textDNICart.Text.ToString().Trim();

                var queryClient = await _contextDB.Client.Where(c =>
                                        c.DNI == dniClient
                                        && c.Status == true).FirstOrDefaultAsync();

                if (queryClient != null)
                {
                    textFirstNameCart.Text = queryClient.FisrtName;
                    textLastNameCart.Text = queryClient.LastName;
                    textDNICart.Text = queryClient.DNI.ToString();
                    textPhoneCart.Text = queryClient.Phone.ToString();
                    textAddressCart.Text = queryClient.Direction;
                    textEmailCart.Text = queryClient.Email;
                    _idClient = queryClient.IdClient;
                    idClient.Text = _idClient.ToString();
                }
                else
                {
                    var clientFinal = await new Application_ContextDB().Client.FindAsync(1);

                    textDNICart.Text = clientFinal.DNI.ToString();
                    textPhoneCart.Text = clientFinal.Phone.ToString();
                    textFirstNameCart.Text = clientFinal.FisrtName;
                    textLastNameCart.Text = clientFinal.LastName;
                    textAddressCart.Text = clientFinal.Direction;
                    textEmailCart.Text = clientFinal.Email;
                    _idClient = clientFinal.IdClient;
                    idClient.Text = _idClient.ToString();
                }
            }
        }

        private async void textCodeCart_KeyDown(object sender, KeyEventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var queryCodeProduct = await _contextDB.Product.Where(p =>
                        p.CodeProduct == textCodeCart.Text.Trim()
                        && p.Status == true).FirstOrDefaultAsync();

            if (e.KeyCode == Keys.Enter)
            {
                if (queryCodeProduct != null)
                {
                    var quantity = Calculates.Cant_Text(textQuantityCart.Text.Trim() == "" ? 1 : Convert.ToInt32(textQuantityCart.Text.Trim()));

                    var pUnitary = CalcularSubTotal(Calculates.PUnitary_Text(queryCodeProduct.PriceUnitary));

                    var descuent = Calculates.Descuent_Text(textDescuentProduct.Text.Trim() == "" ? 0 : Convert.ToInt32(textDescuentProduct.Text.Trim())); ;

                    var priceTotal = Calculates.PVP_Text(quantity, Convert.ToDecimal(pUnitary), descuent);

                    textQuantityCart.Focus();

                    // TEXTOS

                    textQuantityCart.Text = quantity.ToString();

                    textDescriptionCart.Text = $"{queryCodeProduct.NameProduct} - {queryCodeProduct.Brand} - {queryCodeProduct.Description}";

                    textPriceUnitaryCart.Text = pUnitary.ToString();

                    textDescuentProduct.Text = descuent.ToString();

                    textPriceTotalCart.Text = priceTotal.ToString();

                    // TEXTOS

                    // TEXTOS GRID

                    _idProductDataGrid = queryCodeProduct.IdProduct.ToString();

                    _productquantityDataGrid = quantity;

                    _productCodeDataGrid = queryCodeProduct.CodeProduct.ToString();

                    _productNameDataGrid = queryCodeProduct.NameProduct;

                    _productBrandDataGrid = queryCodeProduct.Brand;

                    _productDescriptionDataGrid = queryCodeProduct.Description;

                    _productPUnitaryDataGrid = pUnitary;

                    _productPDescuentDataGrid = Convert.ToInt32(descuent);

                    _productPTotalDataGrid = Convert.ToDecimal(priceTotal);

                    textQuantityCart.Focus();

                    // TEXTOS GRID
                }
                else
                {
                    MessageBox.Show("El Producto no existe", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CalculosToGrid()
        {
            if (string.IsNullOrEmpty(textCodeCart.Text))
            {
                MessageBox.Show("El campo Codigo no puede estar vacio", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var quantity = Calculates.Cant_Text(textQuantityCart.Text.Trim() == "" ? 1 : Convert.ToInt32(textQuantityCart.Text.Trim()));

                var pUnitary = Calculates.PUnitary_Text(_productPUnitaryDataGrid == Convert.ToDecimal(textPriceUnitaryCart.Text.Trim()) ? _productPUnitaryDataGrid : CalcularSubTotal(Convert.ToDecimal(textPriceUnitaryCart.Text.Trim())));

                var descuent = Calculates.Descuent_Text(textDescuentProduct.Text.Trim() == "" ? 0 : Convert.ToInt32(textDescuentProduct.Text.Trim())); ;

                var priceTotal = Calculates.PVP_Text(quantity, pUnitary, descuent);

                textPriceTotalCart.Text = priceTotal;
                textPriceUnitaryCart.Text = pUnitary.ToString();
                textQuantityCart.Text = quantity.ToString();
                textDescuentProduct.Text = descuent.ToString();

                _productquantityDataGrid = quantity;
                _productPUnitaryDataGrid = pUnitary;
                _productPDescuentDataGrid = descuent;
                _productPTotalDataGrid = Convert.ToDecimal(priceTotal);
            }
        }

        private void textQuantityCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculosToGrid();
                textPriceUnitaryCart.Focus();
            }
        }

        private void textPriceUnitaryCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculosToGrid();
                textDescuentProduct.Focus();
            }
        }

        private void textDescProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculosToGrid();
                textPriceTotalCart.Focus();
            }
        }

        private void textPriceTotalCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculosToGrid();
                AddToGrid();
            }
        }

        private void AddToGrid()
        {
            List<string> fields = new List<string>();
            fields.Add(textCodeCart.Text.Trim());
            fields.Add(textQuantityCart.Text.Trim());
            fields.Add(textPriceUnitaryCart.Text.Trim());
            fields.Add(textDescuentProduct.Text.Trim());
            fields.Add(textPriceTotalCart.Text.Trim());

            var validation = ValidationFields.ValidacionFieldsToCart(fields);

            if (validation == true)
            {
                if (dataGridCart.RowCount > 0)
                {
                    bool productExists = false;

                    for (int i = 0; i < dataGridCart.RowCount; i++)
                    {
                        if (Convert.ToInt32(dataGridCart.Rows[i].Cells[0].Value) == Convert.ToInt32(_idProductDataGrid))
                        {
                            var quantity = Convert.ToInt32(dataGridCart.Rows[i].Cells[1].Value) + Convert.ToInt32(_productquantityDataGrid);

                            var priceUnitary = Convert.ToDecimal(dataGridCart.Rows[i].Cells[6].Value) + _productPUnitaryDataGrid;

                            var descuent = Convert.ToInt32(dataGridCart.Rows[i].Cells[7].Value) + _productPDescuentDataGrid;

                            var priceTotal = Convert.ToDecimal(dataGridCart.Rows[i].Cells[8].Value) + _productPTotalDataGrid;

                            dataGridCart.Rows[i].Cells[1].Value = quantity;

                            //dataGridCart.Rows[i].Cells[5].Value = priceUnitary;

                            //dataGridCart.Rows[i].Cells[6].Value = descuent;

                            dataGridCart.Rows[i].Cells[8].Value = priceTotal;

                            productExists = true;
                            textCodeCart.Focus();
                            ResetFieldAdd();

                            break;
                        }
                    }

                    if (productExists == false)
                    {
                        rowIndex = dataGridCart.Rows.Add();
                        dataGridCart.Rows[rowIndex].Cells[0].Value = _idProductDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[1].Value = _productquantityDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[2].Value = _productCodeDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[3].Value = _productNameDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[4].Value = _productBrandDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[5].Value = _productDescriptionDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[6].Value = _productPUnitaryDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[7].Value = _productPDescuentDataGrid;
                        dataGridCart.Rows[rowIndex].Cells[8].Value = _productPTotalDataGrid;

                        textCodeCart.Focus();
                        ResetFieldAdd();
                    }

                    CalcularTotalFactura();
                }
            }
        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            AddToGrid();
        }

        public void ResetFieldAdd()
        {
            textCodeCart.Text = string.Empty;
            textDescriptionCart.Text = string.Empty;
            textQuantityCart.Text = string.Empty;
            textPriceUnitaryCart.Text = string.Empty;
            textDescuentProduct.Text = string.Empty;
            textPriceTotalCart.Text = string.Empty;
        }

        public void ResetFieldAddClients()
        {
            textDNICart.Text = string.Empty;
            textFirstNameCart.Text = string.Empty;
            textLastNameCart.Text = string.Empty;
            textPhoneCart.Text = string.Empty;
            textEmailCart.Text = string.Empty;
            textAddressCart.Text = string.Empty;
            idClient.Text = string.Empty;
        }

        private void dataGridCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row == 0)
            {
                bool isRowEmpty = true;

                // Verificar si todas las celdas de la fila están en blanco
                for (int i = 0; i < dataGridCart.Rows[row].Cells.Count; i++)
                {
                    if (dataGridCart.Rows[row].Cells[i].Value != null)
                    {
                        if (dataGridCart.Rows[row].Cells[i].Value.ToString() != "")
                        {
                            isRowEmpty = false;
                            break;
                        }
                    }
                }

                if (!isRowEmpty)
                {
                    textCodeCart.Text = (string)dataGridCart.Rows[row].Cells[2].Value;
                    dataGridCart.Rows.RemoveAt(row);
                    textCodeCart.Focus();
                    CalcularTotalFactura();
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar una fila", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //DataGridViewRow row = dataGridCity.Rows[e.RowIndex];
            //_idCity = row.Cells[0].Value.ToString();
        }

        private void textQuantityCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textDescuentProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textPriceUnitaryCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsFloat(e);
        }

        private void textPriceTotalCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsFloat(e);
        }

        private void textCodeCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textDNICart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textPhoneCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void btnSearchClientOnCart_Click(object sender, EventArgs e)
        {
            frmSearchClient frmSearchClientOnCart = new frmSearchClient();
            frmSearchClientOnCart.ShowDialog();
        }

        private void btnAddClientOnCart_Click(object sender, EventArgs e)
        {
            fmAddClientCart fmAddClientCartOnCart = new fmAddClientCart();
            fmAddClientCartOnCart.ShowDialog();
        }

        private void btnResetFieldClient_Click(object sender, EventArgs e)
        {
            ResetFieldAddClients();
        }

        private void frmCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmSearchProducts frmSearchProductsOnCart = new frmSearchProducts();
                //frmSearchProductsOnCart.ShowDialog();

                MessageBox.Show("hola");
            }
        }

        public decimal CalcularSubTotal(decimal ptotal)
        {
            return ptotal / _ivaCompany;
        }

        public void CalcularTotalFactura()
        {
            _labelSubFac = 0m;
            _labelSub0Fac = 0m;
            _labelSub12Fac = 0m;
            _labelDescFac = 0m;
            _labelIvaFac = 0m;
            _labelTotalFac = 0m; ;

            var col = dataGridCart.Rows.Count;

            for (int i = 0; i < col; i++)
            {
                _labelDescFac += Convert.ToDecimal(dataGridCart.Rows[i].Cells[7].Value);
                _labelSubFac += Convert.ToDecimal(dataGridCart.Rows[i].Cells[8].Value);
            }

            var iva = _ivaCompany - 1;

            _labelIvaFac = _labelSubFac * iva;
            _labelTotalFac = _labelSubFac + _labelIvaFac;

            labelSubTotalCart.Text = _labelSubFac.ToString("F2");
            labelSubTotalZeroCart.Text = "";
            labelDescuentCart.Text = _labelDescFac.ToString();
            labelSubTotalTwelveCart.Text = "";
            labelIvaCart.Text = _labelIvaFac.ToString("F2");
            labelTotalOneCart.Text = _labelTotalFac.ToString("F2");
            labelTotalTwoCart.Text = _labelTotalFac.ToString("F2");
        }

        private async void btnSaveCart_Click(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var newFac = new MCart()
            {
                IdClient = 1,
                IdProduct = 1
            };

            _contextDB.Add(newFac);

            await _contextDB.SaveChangesAsync();

            MessageBox.Show("Guardado Correctamente");
        }

        private int getIdProduct()
        {
            var col = dataGridCart.Rows.Count;

            for (int i = 0; i < col; i++)
            {
                idProduct = Convert.ToInt32(dataGridCart.Rows[i].Cells[0].Value);
            }

            return idProduct;
        }
    }
}