using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Utils;

namespace Store.Presentador.Company
{
    public partial class frmCompany : Form
    {
        private int IdCompany = 1;

        public frmCompany()
        {
            InitializeComponent();
            LoadData();

            btnSaveCompany.Enabled = false;
        }

        private async void LoadData()
        {
            var _contextDB = new Application_ContextDB();

            var loadData = await _contextDB.Company.Where(c => c.IdCompany == IdCompany).FirstOrDefaultAsync();

            if (loadData != null)
            {
                textNameCompany.Text = loadData.CompanyName;
                textOwnerCompany.Text = loadData.OwnerCompany;
                textDirectionCompany.Text = loadData.DirectionCompany;
                textEmailCompany.Text = loadData.EmailCompany;
                textRUCCompany.Text = loadData.DNICompany;
                textPhoneCompany.Text = loadData.PhoneCompany;
                textNumberDocumentCompany.Text = loadData.NumDocumentCompany.ToString();
                textSerieOneCompany.Text = loadData.SerieOneCompany;
                textSerieTwoCompany.Text = loadData.SerieTwoCompany;
                comboBoxDataBase.Text = loadData.DataBaseName;
                comboBoxDocuments.Text = loadData.TypeDocument;
                comboBoxIva.Text = loadData.IvaCompany.ToString();
                comboBoxCoin.Text = loadData.CoinCompany;
            }
        }

        private async void btnSaveCompany_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            list.Add(textNameCompany.Text);
            list.Add(textOwnerCompany.Text);
            list.Add(textDirectionCompany.Text);
            list.Add(textEmailCompany.Text);
            list.Add(textRUCCompany.Text);
            list.Add(textPhoneCompany.Text);
            list.Add(textNumberDocumentCompany.Text);
            list.Add(textSerieOneCompany.Text);
            list.Add(textSerieTwoCompany.Text);
            list.Add(comboBoxDataBase.Text);
            list.Add(comboBoxDocuments.Text);
            list.Add(comboBoxIva.Text);
            list.Add(comboBoxCoin.Text);

            var _contextDB = new Application_ContextDB();

            var query = await _contextDB.Company.Where(c => c.IdCompany == IdCompany).FirstOrDefaultAsync();

            query.CompanyName = textNameCompany.Text.Trim().ToUpper();
            query.OwnerCompany = textOwnerCompany.Text.Trim().ToUpper();
            query.DirectionCompany = textDirectionCompany.Text.Trim().ToUpper();
            query.EmailCompany = textEmailCompany.Text;
            query.DNICompany = textRUCCompany.Text;
            query.PhoneCompany = textPhoneCompany.Text;
            query.NumDocumentCompany = textNumberDocumentCompany.Text;
            query.SerieOneCompany = textSerieOneCompany.Text;
            query.SerieTwoCompany = textSerieTwoCompany.Text;
            query.DataBaseName = comboBoxDataBase.Text.Trim().ToUpper();
            query.TypeDocument = comboBoxDocuments.Text.Trim().ToUpper();
            query.IvaCompany = Convert.ToDecimal(comboBoxIva.Text);
            query.CoinCompany = comboBoxCoin.Text.Trim().ToUpper();

            if (ValidationFields.ValidationFieldsCompany(list) == true)
            {
                await _contextDB.SaveChangesAsync();
                MessageBox.Show("Datos actualizados correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSaveCompany.Enabled = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            CkeckCode();
        }

        private void textCodeCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CkeckCode();
            }
        }

        public async void CkeckCode()
        {
            if (ValidationFields.ValidationCodeApp(textCodeCompany.Text.Trim()) == true)
            {
                var _contextDB = new Application_ContextDB();

                var query = await _contextDB.AppCode.Where(c => c.IdCode == IdCompany).FirstOrDefaultAsync();

                if (query != null)
                {
                    if (CodeApplication.DesencriptarCode(textCodeCompany.Text.Trim(), query.Code) == true)
                    {
                        btnSaveCompany.Enabled = true;
                        textCodeCompany.Text = string.Empty;
                        MessageBox.Show("Código correcto", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Código incorrecto", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No Existe ningun registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}