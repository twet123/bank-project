using System;
using System.Windows.Forms;
using System.Drawing;


namespace bankproject.Forms.FormLogIn
{
    public partial class FormLogin : Form
    {
        TextBox TbUsername, TbPassword;
        //PictureBox PbLogo;
        PictureBox PbUsername, PbPassword;
        Label LblHidden;
        Panel Line1, Line2;
        Button BtnLogin;

        public FormLogin()
        {
            Render();
        }

        private void Render()
        {
            //ctors
            PbUsername = new PictureBox();
            PbPassword = new PictureBox();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            LblHidden = new Label();
            Line1 = new Panel();
            Line2 = new Panel();
            BtnLogin = new Button();

            //FormLogin
            this.Size = new Size(372, 400);
            this.Font = new Font("Microsoft Sans Serif", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.BackColor = Color.FromArgb(10, 41, 0);
            this.BackColor = Color.White;
            this.Load += Handle_Load;

            //PbUsername
            PbUsername.ImageLocation = @"../../Assets/account_box-24px.png";
            PbUsername.Location = new Point(61, 94);
            PbUsername.Size = new Size(24, 24);

            //PbPassword
            PbPassword.ImageLocation = @"../../Assets/vpn_key-24px.png";
            PbPassword.Location = new Point(61, 150);
            PbPassword.Size = new Size(24, 24);

            //TbUsername
            TbUsername.Location = new Point(100, 96);
            TbUsername.BorderStyle = BorderStyle.None;
            TbUsername.Size = new Size(200, 40);
            TbUsername.Text = "Username";
            TbUsername.ForeColor = Color.Silver;
            TbUsername.Enter += TbUsername_Enter;
            TbUsername.Leave += TbUsername_Leave;

            //TbPassword
            TbPassword.Location = new Point(100, 152);
            TbPassword.BorderStyle = BorderStyle.None;
            TbPassword.Size = new Size(200, 40);
            TbPassword.Text = "Password";
            TbPassword.ForeColor = Color.Silver;
            TbPassword.Enter += TbPassword_Enter;
            TbPassword.Leave += TbPassword_Leave;

            //LblHidden
            LblHidden.Location = new Point(-10, 0);
            LblHidden.Size = new Size(0, 0);

            //Line1
            Line1.ForeColor = Color.Black;
            Line1.BackColor = Color.Black;
            Line1.Location = new Point(61, 124);
            Line1.Size = new Size(250, 1);

            //Line2
            Line2.ForeColor = Color.Black;
            Line2.BackColor = Color.Black;
            Line2.Location = new Point(61, 180);
            Line2.Size = new Size(250, 1);

            //BtnLogin
            BtnLogin.Location = new Point(61, 250);
            BtnLogin.Size = new Size(250, 50);
            BtnLogin.BackColor = Color.Black;
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Text = "Log In";
            BtnLogin.Font = new Font("Microsoft Sans Serif", 15);
            BtnLogin.Click += BtnLogin_Click;

            //Adding controls
            this.Controls.Add(PbUsername);
            this.Controls.Add(PbPassword);
            this.Controls.Add(TbUsername);
            this.Controls.Add(TbPassword);
            this.Controls.Add(LblHidden);
            this.Controls.Add(Line1);
            this.Controls.Add(Line2);
            this.Controls.Add(BtnLogin);
        }

    }
}
