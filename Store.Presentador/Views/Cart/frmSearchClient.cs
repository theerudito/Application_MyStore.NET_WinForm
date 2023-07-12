using Microsoft.EntityFrameworkCore;
using Store.Database;

namespace Store.Presentador.Cart
{
    public partial class frmSearchClient : Form
    {
        public frmSearchClient()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        public async void LoadDataGrid()
        {
            var _contextDB = new Application_ContextDB();

            var queryClients = await _contextDB.Client.Where(c => c.Status == true).ToListAsync();

            dataGridSearchClient.DataSource = queryClients;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void textSearchClient_TextChanged(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var queryClient = await _contextDB.Client.Where(c =>
                         c.FisrtName == textSearchClient.Text.Trim().ToUpper()
                         && c.Status == true)
                         .ToListAsync();

            if (queryClient.Count > 0)
            {
                dataGridSearchClient.DataSource = queryClient;
            }
            else
            {
                LoadDataGrid();
            }
        }

        private async void textSearchClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var _contextDB = new Application_ContextDB();

                var queryClient = await _contextDB.Client.Where(c =>
                                        c.FisrtName.Contains(textSearchClient.Text.Trim().ToUpper())
                                        || c.LastName.Contains(textSearchClient.Text.Trim().ToUpper())
                                        && c.Status == true)
                                        .ToListAsync();

                if (queryClient.Count > 0)
                {
                    dataGridSearchClient.DataSource = queryClient;
                }
                else
                {
                    LoadDataGrid();
                }
            }
        }

        private void dataGridSearchClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridSearchClient.Rows[e.RowIndex];

                labelIdClient.Text = row.Cells[0].Value.ToString();

                var _dniClientOnDataGrid = row.Cells[1].Value.ToString();
                labelDNI.Text = _dniClientOnDataGrid;

                var fact = new frmFactura();
                fact.LoadClient(_dniClientOnDataGrid);
                this.Close();
            }
        }
    }
}