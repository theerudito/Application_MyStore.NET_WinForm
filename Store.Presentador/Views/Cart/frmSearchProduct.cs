using Microsoft.EntityFrameworkCore;
using Store.Database;

namespace Store.Presentador.Cart
{
    public partial class frmSearchProducts : Form
    {
        public frmSearchProducts()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private string _codeProduct;
        private string _idProduct;

        public async void LoadDataGrid()
        {
            var dbContext = new Application_ContextDB();
            var products = await dbContext.Product.Where(p => p.Status == true).ToListAsync();
            dataGridViewProducts.DataSource = products;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Debes Seleccionar una producto", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var row = dataGridViewProducts.Rows[e.RowIndex];
                _codeProduct = row.Cells[1].Value.ToString();
                labelCodeProduct.Text = _codeProduct;
                labelD.Text = row.Cells[7].Value.ToString();
            }
        }

        private async void textName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new Application_ContextDB();

                var textName = textSearchName.Text.Trim().ToUpper();

                var queryNameProducts = await dbContext.Product.Where(p =>
                             p.NameProduct.Contains(textName)
                             && p.Status == true).ToListAsync();

                if (queryNameProducts.Count > 0)
                {
                    dataGridViewProducts.DataSource = queryNameProducts;
                }
                else
                {
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al traer los registros", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void textBrand_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new Application_ContextDB();

                var textBrand = textSearchBrand.Text.Trim().ToUpper();

                var queryBrand = await dbContext.Product.Where(p =>
                            p.Brand.Contains(textBrand) && p.Status == true).ToListAsync();

                if (queryBrand.Count > 0)
                {
                    dataGridViewProducts.DataSource = queryBrand;
                }
                else
                {
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al traer los registros", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void textDescription_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var dbContext = new Application_ContextDB();

                var textDescription = textSearchDescription.Text.Trim().ToUpper();

                var queryDescription = await dbContext.Product.Where(p =>
                                p.Description.Contains(textDescription)
                                && p.Status == true).ToListAsync();

                if (queryDescription.Count > 0)
                {
                    dataGridViewProducts.DataSource = queryDescription;
                }
                else
                {
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al traer los registros", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}