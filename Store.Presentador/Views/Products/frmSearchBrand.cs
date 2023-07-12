using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Products
{
    public partial class frmAddBrand : Form
    {
        public frmAddBrand()
        {
            InitializeComponent();
            LoadData();
        }

        private string _idBrand = "";
        private string _nameBrand = "";

        public async void LoadData()
        {
            var _contextDB = new Application_ContextDB();
            var loadData = await _contextDB.Brands.ToListAsync();
            dataGridBrand.DataSource = loadData;
        }

        public void ResetFiels()
        {
            textSearchBrand.Text = "";
            _idBrand = "";
            labelIdBrand.Text = _idBrand.ToString();
        }

        public async void newBrand()
        {
            var _contextDB = new Application_ContextDB();

            var brand = textSearchBrand.Text.Trim().ToUpper();

            var searchingBrand = await _contextDB.Brands.Where(b => b.Brand == brand).FirstOrDefaultAsync();
            if (searchingBrand != null)
            {
                MessageBox.Show("La marca ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(brand))
                {
                    MessageBox.Show("El campo marca no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var newBrand = new MBrand { Brand = brand };

                    if (_idBrand == "")
                    {
                        _contextDB.Brands.Add(newBrand);
                        await _contextDB.SaveChangesAsync();
                        ResetFiels();
                        LoadData();
                    }
                    else
                    {
                        var brandUpdate = await _contextDB.Brands.Where(b => b.IdBrand == Convert.ToInt64(_idBrand)).FirstOrDefaultAsync();
                        brandUpdate.Brand = brand;
                        await _contextDB.SaveChangesAsync();
                        ResetFiels();
                        LoadData();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            newBrand();
        }

        private async void textSearchBrand_TextChanged(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var brand = textSearchBrand.Text.Trim().ToUpper();

            var searchingBrand = await _contextDB.Brands.Where(b => b.Brand.Contains(brand)).ToListAsync();

            if (searchingBrand != null)
            {
                dataGridBrand.DataSource = searchingBrand;
            }
            else
            {
                LoadData();
            }
        }

        private void textSearchBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newBrand();
            }
        }

        private void dataGridBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridBrand.Rows[e.RowIndex];
                _idBrand = row.Cells[0].Value.ToString();
                labelIdBrand.Text = _idBrand.ToString() + "e";
                textSearchBrand.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridBrand.Rows[e.RowIndex];
                _idBrand = row.Cells[0].Value.ToString();
                labelIdBrand.Text = _idBrand.ToString();
            }
        }
    }
}