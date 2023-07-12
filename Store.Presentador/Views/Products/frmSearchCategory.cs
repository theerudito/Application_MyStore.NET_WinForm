using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Products
{
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
            LoadData();
        }

        private string _idCategory = "";
        private string _nameCategory = "";

        public async void LoadData()
        {
            var _contextDB = new Application_ContextDB();
            var loadData = await _contextDB.Categories.ToListAsync();
            dataGridCategory.DataSource = loadData;
        }

        public void ResetFiels()
        {
            textSearchCategory.Text = "";
            _idCategory = "";
            labelIdCategory.Text = _idCategory.ToString();
        }

        public async void newCategory()
        {
            var _contextDB = new Application_ContextDB();

            var category = textSearchCategory.Text.Trim().ToUpper();

            var searchingBrand = await _contextDB.Categories.Where(b => b.Category == category).FirstOrDefaultAsync();
            if (searchingBrand != null)
            {
                MessageBox.Show("La categoria ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(category))
                {
                    MessageBox.Show("El campo categoria no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var newCategory = new MCategory { Category = category };

                    if (_idCategory == "")
                    {
                        _contextDB.Categories.Add(newCategory);
                        await _contextDB.SaveChangesAsync();
                        ResetFiels();
                        LoadData();
                    }
                    else
                    {
                        var updateCategory = await _contextDB.Categories.Where(b => b.IdCategory == Convert.ToInt64(_idCategory)).FirstOrDefaultAsync();
                        updateCategory.Category = category;
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            newCategory();
        }

        private void textSearchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newCategory();
            }
        }

        private async void textSearchCategory_TextChanged(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var category = textSearchCategory.Text.Trim().ToUpper();

            var searchingBrand = await _contextDB.Categories.Where(b => b.Category.Contains(category)).ToListAsync();

            if (searchingBrand != null)
            {
                dataGridCategory.DataSource = searchingBrand;
            }
            else
            {
                LoadData();
            }
        }

        private void dataGridCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridCategory.Rows[e.RowIndex];
                _idCategory = row.Cells[0].Value.ToString();
                labelIdCategory.Text = _idCategory.ToString() + "e";
                textSearchCategory.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridCategory.Rows[e.RowIndex];
                _idCategory = row.Cells[0].Value.ToString();
                labelIdCategory.Text = _idCategory.ToString();
            }
        }
    }
}