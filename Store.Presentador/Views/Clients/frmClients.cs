using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Clients
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            labelStatus.Text = string.Empty;
            labelIdCity.Text = "0";
            LoadDataGrid();
            LoadCity();
        }

        private string _idClientOnGrid;
        public string _idCity;

        private List<MCity> Cities(string city)
        {
            var _contextDB = new Application_ContextDB();
            return _contextDB.Cities.Where(c => c.City.Contains(city)).ToList();
        }

        private void LoadCity()
        {
            AutoCompleteStringCollection cityList = new AutoCompleteStringCollection();
            List<MCity> mCities = Cities(comboBoxCity.Text.Trim().ToUpper());
            foreach (MCity city in mCities)
            {
                cityList.Add(city.City);
            }

            comboBoxCity.AutoCompleteCustomSource = cityList;
            comboBoxCity.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void LoadDataGrid()
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                if (checkBoxActive.Checked == true)
                {
                    var loadData = await _contextDB.Client.Where(c => c.Status == true).ToListAsync();

                    dataGridClients.DataSource = loadData;
                }
                else
                {
                    var loadData = await _contextDB.Client.Where(c => c.Status == false).ToListAsync();

                    dataGridClients.DataSource = loadData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFeald()
        {
            textDNIClient.Text = "";
            textFirstNameClient.Text = "";
            textLastNameClient.Text = "";
            textDirectionClient.Text = "";
            textPhoneClient.Text = "";
            textEmailClient.Text = "";
            comboBoxCity.Text = "";
            _idClientOnGrid = 0.ToString();
            _idCity = 0.ToString();
            labelStatus.Text = "";
            labelIdCity.Text = 0.ToString();
            btnDeleteClient.Text = "Activo";
        }

        private async void btnSaveClient_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<string> fields = new List<string>();
                fields.Add(textDNIClient.Text);
                fields.Add(textFirstNameClient.Text);
                fields.Add(textLastNameClient.Text);
                fields.Add(textDirectionClient.Text);
                fields.Add(textPhoneClient.Text);
                fields.Add(textEmailClient.Text);
                fields.Add(comboBoxCity.Text.Trim().ToUpper());

                if (string.IsNullOrEmpty(textDNIClient.Text.Trim()))

                {
                    MessageBox.Show("Todos los campos son requerido para guardar", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (ValidationFields.ValidationFieldsClient(fields) == true)
                    {
                        var _contextDB = new Application_ContextDB();

                        var searhDNI = await _contextDB.Client.Where(cli => cli.DNI == textDNIClient.Text.Trim()).FirstOrDefaultAsync();
                        if (searhDNI != null)
                        {
                            MessageBox.Show("El cliente ya esta registrado", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ResetFeald();
                            return;
                        }
                        else
                        {
                            var client = new MClients
                            {
                                DNI = textDNIClient.Text.Trim(),
                                FisrtName = textFirstNameClient.Text.Trim().ToUpper(),
                                LastName = textLastNameClient.Text.Trim().ToUpper(),
                                Direction = textDirectionClient.Text.Trim().ToUpper(),
                                Phone = textPhoneClient.Text.Trim(),
                                Email = textEmailClient.Text,
                                City = comboBoxCity.Text.Trim().ToUpper(),
                                Status = true,
                            };

                            _contextDB.Client.Add(client);
                            await _contextDB.SaveChangesAsync();
                            MessageBox.Show("El nuevo cliente fue agregado correctamentes", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetFeald();
                            LoadDataGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente en la base de datos", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("" + ex);
            }
        }

        private void textDNIClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textPhoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private async void textGetClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                string textClient = textGetClient.Text.Trim().ToUpper();

                var queryClients = await _contextDB.Client.Where(c =>
                                                    c.FisrtName.Contains(textClient)
                                                     || c.LastName.Contains(textClient)
                                                     || c.Direction.Contains(textClient)
                                                     || c.City.Contains(textClient)
                                                     && c.Status == true)
                                                     .ToListAsync();
                if (queryClients.Count > 0)
                {
                    dataGridClients.DataSource = queryClients;
                }
                else
                {
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los clientes" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void textGetClient_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var _contextDB = new Application_ContextDB();

                    var query = await _contextDB.Client.Where(cli =>
                                    cli.DNI == textGetClient.Text.Trim()
                                    && cli.Status == true).ToListAsync();

                    if (query.Count > 0)
                    {
                        dataGridClients.DataSource = query;
                    }
                    else
                    {
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridClients.Rows[e.RowIndex];

                _idClientOnGrid = row.Cells[0].Value.ToString();

                labelIdClient.Text = row.Cells[0].Value.ToString();

                textDNIClient.Text = row.Cells[1].Value.ToString();
                textFirstNameClient.Text = row.Cells[2].Value.ToString();
                textLastNameClient.Text = row.Cells[3].Value.ToString();
                textDirectionClient.Text = row.Cells[4].Value.ToString();
                textPhoneClient.Text = row.Cells[5].Value.ToString();
                textEmailClient.Text = row.Cells[6].Value.ToString();
                comboBoxCity.Text = row.Cells[7].Value.ToString();

                btnDeleteClient.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                    ? btnDeleteClient.Text = "Desactivar"
                    : btnDeleteClient.Text = "Activar";

                labelStatus.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                    ? labelStatus.Text = "Activo"
                    : labelStatus.Text = "Desactivo";
            }
        }

        private async void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (_idClientOnGrid == null)
            {
                MessageBox.Show("Debe selecionar un cliente para activarlo o desactivarlo", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_idClientOnGrid == 1.ToString())
                {
                    MessageBox.Show("No es posible desactivar este registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var _contextDB = new Application_ContextDB();

                    var active = await _contextDB.Client.Where(c =>
                                c.IdClient == Convert.ToInt32(_idClientOnGrid))
                                .FirstOrDefaultAsync();

                    if (active.Status == false)
                    {
                        active.Status = !active.Status;
                    }
                    else
                    {
                        active.Status = !active.Status;
                    }

                    await _contextDB.SaveChangesAsync();
                    ResetFeald();
                    LoadDataGrid();
                }
            }
        }

        private async void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idClientOnGrid == null)
                {
                    MessageBox.Show("Debe selecionar un cliente para actualizarlo", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_idClientOnGrid == 1.ToString())
                    {
                        MessageBox.Show("No es posible actualizar este registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var _contextDB = new Application_ContextDB();

                        var query = await _contextDB.Client.Where(c =>
                                    c.IdClient == Convert.ToInt32(_idClientOnGrid))
                                    .FirstOrDefaultAsync();

                        query.DNI = textDNIClient.Text;
                        query.FisrtName = textFirstNameClient.Text.Trim().ToUpper();
                        query.LastName = textLastNameClient.Text.Trim().ToUpper();
                        query.Direction = textDirectionClient.Text.Trim().ToUpper();
                        query.Phone = textPhoneClient.Text.Trim();
                        query.Email = textEmailClient.Text.Trim();
                        query.City = comboBoxCity.Text.Trim().ToUpper();
                        query.Status = true;

                        await _contextDB.SaveChangesAsync();
                        MessageBox.Show("El cliente fue actualizado correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ;
                        ResetFeald();
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            frmAddCity frmAddCity = new frmAddCity();
            frmAddCity.ShowDialog();
            textEmailClient.Focus();
        }

        private void comboBoxCity_MouseDown(object sender, MouseEventArgs e)
        {
            LoadCity();
        }
    }
}