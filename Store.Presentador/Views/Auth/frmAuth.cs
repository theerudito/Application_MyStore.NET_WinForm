using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;
using Store.Presentador.Home;
using Store.Utils;

namespace Store.Presentador.Auth
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void labelGoRegister_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void labelGoLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegister.Visible = false;
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetFieldLogin()
        {
            textUserLogin.Text = "";
            textPasswordLogin.Text = "";
        }

        private void ResetFieldRegister()
        {
            textUserRegister.Text = "";
            textEmailRegister.Text = "";
            textPasswordRegister.Text = "";
        }

        private void textPasswordRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void textPasswordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        public async void Login()
        {
            if (ValidationFields.ValidationFieldsdAuthLogin(textUserLogin.Text.Trim(), textPasswordLogin.Text.Trim()) == true)
            {
                var _contextDB = new Application_ContextDB();

                var searchUser = await _contextDB.Auth.Where(x => x.UserName == textUserLogin.Text.Trim()).FirstOrDefaultAsync();
                if (searchUser != null)
                {
                    if (CodeApplication.DesencriptarAuth(textPasswordLogin.Text.Trim(), searchUser.Password))
                    {
                        Properties.Settings.Default.userData = searchUser.User;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.Reload();
                        ResetFieldLogin();
                        MessageBox.Show("Bienvenido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fhome = new frmHome(this);
                        this.Hide();
                        fhome.Show();
                    }
                    else
                    {
                        MessageBox.Show("username o Contraseña son Incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async void Register()
        {
            if (ValidationFields.ValidationFieldsdAuthRegister(textUserRegister.Text.Trim(), textEmailRegister.Text.Trim(), textPasswordRegister.Text.Trim()) == true)
            {
                var _contextDB = new Application_ContextDB();

                var searchUser = await _contextDB.Auth.Where(x => x.Email == textEmailRegister.Text.Trim()).FirstOrDefaultAsync();

                if (searchUser == null)
                {
                    var auth = new MAuth()
                    {
                        User = textUserRegister.Text.Trim(),
                        Email = textEmailRegister.Text.Trim(),
                        Password = CodeApplication.EncriptarAuth(textPasswordRegister.Text.Trim())
                    };
                    Properties.Settings.Default.userData = textUserRegister.Text.Trim();
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                    ResetFieldRegister();
                    _contextDB.Auth.Add(auth);
                    await _contextDB.SaveChangesAsync();

                    MessageBox.Show("Usuario registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var fhome = new frmHome(this);
                    this.Hide();
                    fhome.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}