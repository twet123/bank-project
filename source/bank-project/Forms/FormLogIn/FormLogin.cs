using System;
using System.Windows.Forms;
using System.Drawing;

namespace bankproject.Forms.FormLogIn
{
    public partial class FormLogin : Form
    {
        void Handle_Load(object sender, EventArgs e)
        {
            LblHidden.Focus();
        }

        void TbUsername_Enter(object sender, EventArgs e)
        {
            if (TbUsername.Text == "Username")
            {
                TbUsername.Text = "";

                TbUsername.ForeColor = Color.Black;
            }
        }

        void TbUsername_Leave(object sender, EventArgs e)
        {
            if (TbUsername.Text == "")
            {
                TbUsername.Text = "Username";

                TbUsername.ForeColor = Color.Silver;
            }
        }

        void TbPassword_Enter(object sender, EventArgs e)
        {
            if (TbPassword.Text == "Password")
            {
                TbPassword.Text = "";

                TbPassword.ForeColor = Color.Black;
                TbPassword.UseSystemPasswordChar = true;
            }
        }

        void TbPassword_Leave(object sender, EventArgs e)
        {
            if (TbPassword.Text == "")
            {
                TbPassword.Text = "Password";

                TbPassword.ForeColor = Color.Silver;

                TbPassword.UseSystemPasswordChar = false;
            }
        }

        void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TbUsername.Text == "admin" && TbPassword.Text == "admin")
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
            }
        }
    }
}
