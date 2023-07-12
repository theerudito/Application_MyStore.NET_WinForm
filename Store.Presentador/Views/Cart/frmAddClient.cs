using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;

namespace Store.Presentador.Cart
{
    public partial class fmAddClientCart : Form
    {
        public fmAddClientCart()
        {
            InitializeComponent();
        }

        private string _dniClient;

        private async void btnSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                var querySearchClient = await _contextDB.Client.Where(c => c.DNI == textDNIClient.Text.Trim()).FirstOrDefaultAsync();

                if (querySearchClient != null)
                {
                    MessageBox.Show("El cliente ya esta registrado", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<string> fields = new List<string>();
                    fields.Add(textDNIClient.Text.Trim());
                    fields.Add(textFirstNameClient.Text.Trim().ToUpper());
                    fields.Add(textLastNameClient.Text.Trim().ToUpper());
                    fields.Add(textEmailClient.Text.Trim());
                    fields.Add(textPhoneClient.Text.Trim());
                    fields.Add(textDirectionClient.Text.Trim().ToUpper());
                    fields.Add("SN");

                    var newClient = new MClients
                    {
                        DNI = fields[0],
                        FisrtName = fields[1],
                        LastName = fields[2],
                        Email = fields[3],
                        Phone = fields[4],
                        Direction = fields[5],
                        City = fields[6],
                    };

                    if (ValidationFields.ValidationFieldsClient(fields) == true)
                    {
                        _contextDB.Client.Add(newClient);
                        await _contextDB.SaveChangesAsync();

                        _dniClient = fields[0];
                        labelDNI.Text = _dniClient;
                        ResetFields();
                        MessageBox.Show("El cliente fue guardado correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar el cliente", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFields()
        {
            textDNIClient.Text = "";
            textFirstNameClient.Text = "";
            textLastNameClient.Text = "";
            textEmailClient.Text = "";
            textPhoneClient.Text = "";
            textDirectionClient.Text = "";
        }

        private void textDNIClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void textPhoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}