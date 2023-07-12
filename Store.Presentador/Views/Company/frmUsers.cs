using Microsoft.EntityFrameworkCore;
using Store.Database;
using Store.Models;
using Store.Utils;
using System.Data;

namespace Store.Presentador.Company
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            comboRoleUser.Text = "Adminstrador";
            labelStatus.Text = string.Empty;
            LoadDataGrid();
        }

        private int idUserOnGrid;

        public async void LoadDataGrid()
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                if (checkBoxActive.Checked == true)
                {
                    var active = await _contextDB.Auth.Where(a => a.Status == true).ToListAsync();
                    dataGridUser.DataSource = active;
                }
                else
                {
                    var desactive = await _contextDB.Auth.Where(a => a.Status == false).ToListAsync();
                    dataGridUser.DataSource = desactive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al obtener los registros");
            }
        }

        private async void textSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var _contextDB = new Application_ContextDB();

                var searchingUser = textSearchUser.Text.Trim();

                var searchUser = await _contextDB.Auth.Where(user =>
                             user.UserName == searchingUser
                             && user.Status == true).ToListAsync();

                if (searchUser.Count > 0)
                {
                    dataGridUser.DataSource = searchUser;
                }
                else
                {
                    LoadDataGrid();
                }
            }
        }

        private async void textSearchUser_TextChanged(object sender, EventArgs e)
        {
            var _contextDB = new Application_ContextDB();

            var searchingUser = textSearchUser.Text.Trim();

            var queryUser = await _contextDB.Auth.Where(u => u.User.Contains(searchingUser) && u.Status == true).ToListAsync();

            if (queryUser.Count > 0)
            {
                dataGridUser.DataSource = queryUser;
            }
            else
            {
                LoadDataGrid();
            }
        }

        private void dataGridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dataGridUser.Rows[e.RowIndex];
                idUserOnGrid = Convert.ToInt32(row.Cells[0].Value);

                labelIdUser.Text = idUserOnGrid.ToString();

                textNameUser.Text = row.Cells[1].Value.ToString();
                textUserName.Text = row.Cells[2].Value.ToString();
                textEmailUser.Text = row.Cells[3].Value.ToString();
                textPasswordUser.Text = row.Cells[4].Value.ToString();
                textPhoneUser.Text = row.Cells[5].Value.ToString();
                textDirectionUser.Text = row.Cells[6].Value.ToString();
                comboRoleUser.Text = row.Cells[7].Value.ToString();

                btnEnable.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                ? btnEnable.Text = "Desactivar"
                : btnEnable.Text = "Activar";

                labelStatus.Text = Convert.ToBoolean(row.Cells[8].Value.ToString()) == true
                   ? labelStatus.Text = "Activo"
                   : labelStatus.Text = "Desactivo";
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var _contextDB = new Application_ContextDB();

                var query = await _contextDB.Auth.Where(a => a.UserName == textUserName.Text.Trim()).FirstOrDefaultAsync();

                if (query != null)
                {
                    MessageBox.Show("El usuario ya existe");
                    ResetFields();
                }
                else
                {
                    List<string> listUsers = new List<string>();
                    listUsers.Add(textNameUser.Text.Trim());
                    listUsers.Add(textUserName.Text.Trim());
                    listUsers.Add(textEmailUser.Text.Trim());
                    listUsers.Add(CodeApplication.EncriptarAuth(textPasswordUser.Text.Trim()));
                    listUsers.Add(textPhoneUser.Text.Trim());
                    listUsers.Add(textDirectionUser.Text.Trim());
                    listUsers.Add(comboRoleUser.Text.Trim());

                    var newUser = new MAuth
                    {
                        User = listUsers[0],
                        UserName = listUsers[1],
                        Email = listUsers[2],
                        Password = listUsers[3],
                        Phone = listUsers[4],
                        Direction = listUsers[5],
                        Role = listUsers[6],
                        Status = true,
                    };

                    if (ValidationFields.ValidationFieldUsers(listUsers) == true)
                    {
                        _contextDB.Auth.Add(newUser);
                        await _contextDB.SaveChangesAsync();
                        LoadDataGrid();
                        ResetFields();

                        MessageBox.Show("El el nuevo registro fue guardado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al añadir el registro");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUserOnGrid == 0)
                {
                    MessageBox.Show("Debes selecionar un registro para actualizar", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (idUserOnGrid == 1)
                    {
                        MessageBox.Show("No es posible actalizar este registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        var _contextDB = new Application_ContextDB();

                        var queryUpdateUser = await _contextDB.Auth.Where(a => a.IdAuth == idUserOnGrid).FirstOrDefaultAsync();

                        if (queryUpdateUser != null)
                        {
                            queryUpdateUser.User = textNameUser.Text.Trim();
                            queryUpdateUser.UserName = textUserName.Text.Trim();
                            queryUpdateUser.Email = textEmailUser.Text.Trim();
                            queryUpdateUser.Password = CodeApplication.EncriptarAuth(textPasswordUser.Text.Trim());
                            queryUpdateUser.Phone = textPhoneUser.Text.Trim();
                            queryUpdateUser.Direction = textDirectionUser.Text.Trim();
                            queryUpdateUser.Role = comboRoleUser.Text.Trim();
                            queryUpdateUser.Status = true;
                        }
                        await _contextDB.SaveChangesAsync();
                        MessageBox.Show("El usuario fue actualizado Correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFields();
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al actualizar el registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUserOnGrid == 0)
                {
                    MessageBox.Show("Debes selecionar un registro para Eliminar");
                }
                else
                {
                    if (idUserOnGrid == 1)
                    {
                        MessageBox.Show("No es posible desactivar este registro");
                        return;
                    }
                    else
                    {
                        var _contextDB = new Application_ContextDB();
                        var active = await _contextDB.Auth.Where(a => a.IdAuth == idUserOnGrid).FirstOrDefaultAsync();

                        if (active.Status == false)
                        {
                            active.Status = true;
                        }
                        else
                        {
                            active.Status = false;
                        }

                        await _contextDB.SaveChangesAsync();

                        ResetFields();
                        LoadDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar el registro");
            }
        }

        private void ResetFields()
        {
            textNameUser.Text = "";
            textUserName.Text = "";
            textEmailUser.Text = "";
            textPasswordUser.Text = "";
            textPhoneUser.Text = "";
            textDirectionUser.Text = "";
            comboRoleUser.Text = "Administrador";
            textSearchUser.Text = "";
            labelIdUser.Text = 0.ToString();
            idUserOnGrid = 0;
            btnEnable.Text = "Activo";
        }

        private void textPhoneUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDataType.IsString(e);
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
    }
}