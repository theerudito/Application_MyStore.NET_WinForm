using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Products
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            LoadDataGrid();
            LoadBrand();
            LoadCategory();
            labelStatus.Text = string.Empty;
        }

        private string _idProductOnGrid;
        private string _idCategory;
        private string _idBrand;
        private bool checkIva = true;

        private List<MBrand> Brands(string brand)
        {
            var _contextDB = new Application_ContextDB();
            return _contextDB.Brands.Where(c => c.Brand.Contains(brand)).ToList();
        }

        private List<MCategory> Categories(string category)
        {
            var _contextDB = new Application_ContextDB();
            return _contextDB.Categories.Where(c => c.Category.Contains(category)).ToList();
        }

        private void LoadBrand()
        {
            AutoCompleteStringCollection brandList = new AutoCompleteStringCollection();
            List<MBrand> mBrands = Brands(comboBoxBrand.Text.Trim().ToUpper());

            foreach (MBrand brand in mBrands)
            {
                brandList.Add(brand.Brand);
            }

            comboBoxBrand.AutoCompleteCustomSource = brandList;
            comboBoxBrand.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxBrand.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadCategory()
        {
            AutoCompleteStringCollection categoryList = new AutoCompleteStringCollection();
            List<MCategory> mCategory = Categories(comboBoxCategory.Text.Trim().ToUpper());

            foreach (MCategory category in mCategory)
            {
                categoryList.Add(category.Category);
            }

            comboBoxCategory.AutoCompleteCustomSource = categoryList;
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> fields = new List<string>();
                fields.Add(textNameProduct.Text.Trim());
                fields.Add(textCodeProduct.Text.Trim());
                fields.Add(comboBoxBrand.Text.Trim().ToUpper());
                fields.Add(comboBoxCategory.Text.Trim().ToUpper());
                fields.Add(textDescriptionProduct.Text.Trim());
                fields.Add(textPriceProduct.Text.Trim());
                fields.Add(textQuantityProduct.Text.Trim());

                if (string.IsNullOrEmpty(textCodeProduct.Text.Trim()))
                {
                    MessageBox.Show("Todos los campos son requerido para guardar", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (ValidationFields.ValidationFieldsProduct(fields) == true)
                    {
                        var _contextDB = new Application_ContextDB();

                        var searchCode = await _contextDB.Product.Where(p => p.CodeProduct == textCodeProduct.Text.Trim()).FirstOrDefaultAsync();

                        if (searchCode != null)
                        {
                            MessageBox.Show("El codigo del producto ya esta registrado intenta con otro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }
                        else
                        {
                            var newProduct = new MProducts
                            {
                                NameProduct = textNameProduct.Text.Trim().ToUpper(),
                                CodeProduct = textCodeProduct.Text.Trim(),
                                Brand = comboBoxBrand.Text.Trim().ToUpper(),
                                Category = comboBoxCategory.Text.Trim(),
                                Description = textDescriptionProduct.Text.Trim().ToUpper(),
                                PriceUnitary = Convert.ToDecimal(textPriceProduct.Text.Trim()),
                                Quantity = Convert.ToInt32(textQuantityProduct.Text.Trim()),
                                Status = true,
                                Iva = checkIva
                            };

                            _contextDB.Product.Add(newProduct);
                            await _contextDB.SaveChangesAsync();
                            MessageBox.Show("El nuevo producto fue registrado correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetFeeld();
                            LoadDataGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto en la base de datos" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadDataGrid()
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                if (checkBoxActive.Checked == true)
                {
                    var active = await _contextDB.Product.Where(p => p.Status == true).ToListAsync();
                    dataGridProduct.DataSource = active;
                }
                else
                {
                    var desactive = await _contextDB.Product.Where(p => p.Status == false).ToListAsync();
                    dataGridProduct.DataSource = desactive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en la tabla" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFeeld()
        {
            textNameProduct.Text = "";
            textCodeProduct.Text = "";
            comboBoxBrand.Text = "";
            textDescriptionProduct.Text = "";
            textPriceProduct.Text = "";
            textQuantityProduct.Text = "";
            _idProductOnGrid = null;
            labelStatus.Text = "";
            btnDeleteProduct.Text = "Activo";
        }

        private void textCodeProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsFloat(e);
        }

        private void textQuantityProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private async void textGetProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                var textProducto = textGetProduct.Text.Trim().ToUpper();

                var queryProducts = await _contextDB.Product.Where(p =>
                                            p.NameProduct.Contains(textProducto)
                                            || p.Brand.Contains(textProducto)
                                            || p.Description.Contains(textProducto)
                                            || p.CodeProduct.Contains(textProducto)
                                            && p.Status == true).ToListAsync();
                if (queryProducts.Count > 0)
                {
                    dataGridProduct.DataSource = queryProducts;
                }
                else
                {
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al obtener los productos" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void textGetProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var _contextDB = new Application_ContextDB();

                    var searchProduct = await _contextDB.Product.Where(p =>
                    p.CodeProduct == textGetProduct.Text.Trim()
                    && p.Status == true).ToListAsync();

                    if (searchProduct.Count > 0)
                    {
                        dataGridProduct.DataSource = searchProduct;
                    }
                    else
                    {
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al obtener los datos" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridProduct.Rows[e.RowIndex];

                _idProductOnGrid = row.Cells[0].Value.ToString();
                labelIdProduct.Text = _idProductOnGrid;

                textQuantityProduct.Text = row.Cells[1].Value.ToString();
                textCodeProduct.Text = row.Cells[2].Value.ToString();
                textNameProduct.Text = row.Cells[3].Value.ToString();
                comboBoxBrand.Text = row.Cells[4].Value.ToString();
                comboBoxCategory.Text = row.Cells[5].Value.ToString();
                textDescriptionProduct.Text = row.Cells[6].Value.ToString();
                textPriceProduct.Text = row.Cells[7].Value.ToString();

                btnDeleteProduct.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                 ? btnDeleteProduct.Text = "Desactivar"
                 : btnDeleteProduct.Text = "Activar";

                labelStatus.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                   ? labelStatus.Text = "Activo"
                   : labelStatus.Text = "Desactivo";

                checkBoxIva.Checked = Convert.ToBoolean(row.Cells[9].Value.ToString());
            }
        }

        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idProductOnGrid == null)
                {
                    MessageBox.Show("Debes selecionar un producto para actualizarlo", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_idProductOnGrid == 1.ToString())
                    {
                        MessageBox.Show("No es posible actualizar este registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var _contextDB = new Application_ContextDB();

                        var query = await _contextDB.Product.Where(p =>
                                            p.IdProduct == Convert.ToInt32(_idProductOnGrid))
                                            .FirstOrDefaultAsync();

                        query.NameProduct = textNameProduct.Text.Trim().ToUpper();
                        query.CodeProduct = textCodeProduct.Text.Trim();
                        query.Brand = comboBoxBrand.Text.Trim().ToUpper();
                        query.Category = comboBoxCategory.Text.Trim();
                        query.Description = textDescriptionProduct.Text.Trim().ToUpper();
                        query.PriceUnitary = Convert.ToDecimal(textPriceProduct.Text.Trim());
                        query.Quantity = Convert.ToInt32(textQuantityProduct.Text.Trim());
                        query.Status = true;
                        query.Iva = checkIva;

                        await _contextDB.SaveChangesAsync();
                        MessageBox.Show("El producto fue actualizado correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFeeld();
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al actualizar el producto" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idProductOnGrid == null)
                {
                    MessageBox.Show("Debe selecionar un producto para activarlo o desactivarlo", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_idProductOnGrid == 1.ToString())
                    {
                        MessageBox.Show("No es posible desactivar este registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var _contextDB = new Application_ContextDB();

                        var active = await _contextDB.Product.Where(p => p.IdProduct == Convert.ToInt32(_idProductOnGrid)).FirstOrDefaultAsync();

                        if (active.Status == false)
                        {
                            active.Status = true;
                        }
                        else
                        {
                            active.Status = false;
                        }

                        await _contextDB.SaveChangesAsync();

                        ResetFeeld();
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al Eliminar el producto" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmAddBrand frmAddBrand = new frmAddBrand();
            frmAddBrand.ShowDialog();
            textCodeProduct.Focus();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddCategory frmAddCategory = new frmAddCategory();
            frmAddCategory.ShowDialog();
            comboBoxBrand.Focus();
        }

        private void comboBoxBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Realizar la búsqueda de la marca
            string searchString = keyPressed.ToString();
            int index = comboBoxBrand.FindString(searchString);

            // Seleccionar el índice encontrado
            if (index != -1)
            {
                comboBoxBrand.SelectedIndex = index;
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked == true)
            {
                LoadDataGrid();
            }
            else
            {
                LoadDataGrid();
            }
        }

        private void comboBoxBrand_MouseDown(object sender, MouseEventArgs e)
        {
            LoadBrand();
            LoadCategory();
        }

        private void comboBoxCategory_MouseDown(object sender, MouseEventArgs e)
        {
            LoadBrand();
            LoadCategory();
        }

        private void checkBoxIva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIva.Checked == true)
            {
                checkIva = true;
            }
            else
            {
                checkIva = false;
            }
        }
    }
}