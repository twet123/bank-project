using System;
using System.Windows.Forms;
using System.Drawing;

namespace bankproject.Forms
{
    public partial class FormMain : Form
    {
        Panel PnlSideControls;
        Panel PnlLogo;

        public FormMain()
        {
            Render();
        }

        private void Render()
        {
            //FormMain
            this.Font = new Font("Microsoft Sans Serif", 10);
            this.Size = new Size(1020, 720);
            this.Controls.Add(PnlSideControls);

            //PnlControls
            PnlSideControls = new Panel();
            PnlSideControls.BackColor = Color.FromArgb(18, 71, 0);
            PnlSideControls.Dock = DockStyle.Left;
            PnlSideControls.Width = 250;
            PnlSideControls.Controls.Add(PnlLogo);

            //PnlLogo
            PnlLogo = new Panel();
            PnlLogo.Dock = DockStyle.Top;
        }
    }
}
