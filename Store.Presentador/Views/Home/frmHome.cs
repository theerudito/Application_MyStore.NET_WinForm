using Store.Presentador.Auth;
using Store.Presentador.Cart;
using Store.Presentador.Clients;
using Store.Presentador.Company;
using Store.Presentador.Products;

namespace Store.Presentador.Home

{
    public partial class frmHome : Form
    {
        private frmAuth frmAuth = null;

        public frmHome(frmAuth auth)
        {
            InitializeComponent();
            frmAuth = auth;
            labelUserData.Text = $"Usuario: {Properties.Settings.Default.userData}";
        }

        private Panel panel = new Panel();

        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            panelMenu.Controls.Add(panel);
            panel.BackColor = Color.FromArgb(90, 210, 2);
            panel.Size = new Size(140, 5);
            panel.Location = new Point(btn.Location.X, btn.Location.Y + 30);
        }

        private void btnMouseLeave(Object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(panel);
        }

        private void btnMenuClient_Click(object sender, EventArgs e)
        {
            if (!panelClients.Visible)
            {
                panelClients.Visible = true;
            }
            else
            {
                panelClients.Visible = false;
            }
        }

        private void btnMenuProduct_Click(object sender, EventArgs e)
        {
            if (!panelProducts.Visible)
            {
                panelProducts.Visible = true;
            }
            else
            {
                panelProducts.Visible = false;
            }
        }

        private void btnMenuCart_Click(object sender, EventArgs e)
        {
            if (!panelCart.Visible)
            {
                panelCart.Visible = true;
            }
            else
            {
                panelCart.Visible = false;
            }
        }

        private void btnMenuConfiguration_Click(object sender, EventArgs e)
        {
            if (!panelConfiguration.Visible)
            {
                panelConfiguration.Visible = true;
            }
            else
            {
                panelConfiguration.Visible = false;
            }
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmClients") == false)
            {
                frmClients form_GoClients = new frmClients();
                form_GoClients.MdiParent = this;
                form_GoClients.Show();
                panelClients.Visible = false;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmProducts") == false)
            {
                frmProducts formGoProducts = new frmProducts();
                formGoProducts.MdiParent = this;
                formGoProducts.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmCart") == false)
            {
                frmFactura formGoCart = new frmFactura();
                formGoCart.MdiParent = this;
                formGoCart.Show();
                panelCart.Visible = false;
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmCompany") == false)
            {
                frmCompany formGoCompany = new frmCompany();
                formGoCompany.MdiParent = this;
                formGoCompany.Show();
                panelConfiguration.Visible = false;
            }
        }

        private void btnCloseWindowHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAuth.Close();
        }

        private void btnGoReportsClients_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmReportClients") == false)
            {
                frmReportClients frmReportClients = new frmReportClients();
                frmReportClients.MdiParent = this;
                frmReportClients.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnGoReportsProducts_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmReportProduct") == false)
            {
                frmReportProduct frmReportProduct = new frmReportProduct();
                frmReportProduct.MdiParent = this;
                frmReportProduct.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnGoReportsDetails_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmReportsDetails") == false)
            {
                frmReportsDetails frmReportsDetail = new frmReportsDetails();
                frmReportsDetail.MdiParent = this;
                frmReportsDetail.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnGoUsers_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmUsers") == false)
            {
                frmUsers frmUsers = new frmUsers();
                frmUsers.MdiParent = this;
                frmUsers.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnGoReportsUsers_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmReportUsers") == false)
            {
                frmReportUsers frmReportUsers = new frmReportUsers();
                frmReportUsers.MdiParent = this;
                frmReportUsers.Show();
                panelProducts.Visible = false;
            }
        }

        private void btnGoConfiguration_Click(object sender, EventArgs e)
        {
            if (OpenForms.isOpenForm("frmConfiguration") == false)
            {
                frmConfiguration frmConfiguration = new frmConfiguration();
                frmConfiguration.MdiParent = this;
                frmConfiguration.Show();
                panelProducts.Visible = false;
            }
        }
    }
}