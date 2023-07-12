using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Clients
{
    public partial class frmAddCity : Form
    {
        public frmAddCity()
        {
            InitializeComponent();
            LoadData();
        }

        private string _idCity = "";
        private string _nameCity = "";

        public async void LoadData()
        {
            var _contextDB = new Application_ContextDB();
            var loadData = await _contextDB.Cities.ToListAsync();
            dataGridCity.DataSource = loadData;
        }

        public void ResetFiels()
        {
            textSearchCity.Text = "";
            _idCity = "";
            labelIdCity.Text = _idCity.ToString();
        }

        public async void AddCity()
        {
            var _contextDB = new Application_ContextDB();

            var city = textSearchCity.Text.Trim().ToUpper();

            var searchingCity = await _contextDB.Cities.Where(b => b.City == city).FirstOrDefaultAsync();
            if (searchingCity != null)
            {
                MessageBox.Show("La ciudad ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(city))
                {
                    MessageBox.Show("El campo ciudad no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var newCity = new MCity { City = city };

                    if (_idCity == "")
                    {
                        _contextDB.Cities.Add(newCity);
                        await _contextDB.SaveChangesAsync();
                        ResetFiels();
                        LoadData();
                    }
                    else
                    {
                        var updateCity = await _contextDB.Cities.Where(b => b.IdCity == Convert.ToInt64(_idCity)).FirstOrDefaultAsync();
                        updateCity.City = city;
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

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            AddCity();
        }

        private async void textSearchCity_TextChanged(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var city = textSearchCity.Text.Trim().ToUpper();

            var searchingCity = await _contextDB.Cities.Where(b => b.City.Contains(city)).ToListAsync();

            if (searchingCity != null)
            {
                dataGridCity.DataSource = searchingCity;
            }
            else
            {
                LoadData();
            }
        }

        private void textSearchCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCity();
            }
        }

        private void dataGridCity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridCity.Rows[e.RowIndex];
                _idCity = row.Cells[0].Value.ToString();
                labelIdCity.Text = _idCity.ToString();
            }
        }

        private void dataGridCity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridCity.Rows[e.RowIndex];
                _idCity = row.Cells[0].Value.ToString();
                labelIdCity.Text = _idCity.ToString() + "e";
                textSearchCity.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}