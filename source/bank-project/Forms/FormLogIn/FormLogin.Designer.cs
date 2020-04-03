using System;
using System.Windows.Forms;
using System.Drawing;


namespace bankproject.Forms.FormLogIn
{
    public partial class FormLogin : Form
    {
        TextBox TbUsername;
        PictureBox PbLogo;
        PictureBox PbUsername;

        public FormLogin()
        {
            Render();
        }

        private void Render()
        {
            //FormLogin
            this.Size = new Size(350, 400);
            this.Font = new Font("Microsoft Sans Serif", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(10, 41, 0);
            this.Controls.Add(PbUsername);

            //PbUsername
            PbUsername = new PictureBox();
            PbUsername.ImageLocation = @"../../Assets/account_box-24px.svg";
            PbUsername.Location = new Point(56, 94);
        }

    }
}
