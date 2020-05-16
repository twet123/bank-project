using System;
using System.Windows.Forms;
using System.Drawing;

namespace bankproject.Forms
{
    public partial class FormMain : Form
    {
        private void HideDropMenu()
        {
            if(PnlUplataDrop.Visible == true)
            {
                PnlUplataDrop.Visible = false;
            }

            if(PnlPlacanjeDrop.Visible == true)
            {
                PnlPlacanjeDrop.Visible = false;
            }

            if(PnlRacunInfoDrop.Visible == true)
            {
                PnlRacunInfoDrop.Visible = false;
            }

            if(PnlDizanjeNovcaDrop.Visible == true)
            {
                PnlDizanjeNovcaDrop.Visible = false;
            }
        }

        private void ShowDropMenu(Panel PnlDropMenu)
        {
            if (PnlDropMenu.Visible == false)
            {
                HideDropMenu();
                PnlDropMenu.Visible = true;
            }
            else
                PnlDropMenu.Visible = false;
        }

        void BtnRacunInfo_Click(object sender, EventArgs e)
        {
            ShowDropMenu(PnlRacunInfoDrop);
        }

        void BtnUplata_Click(object sender, EventArgs e)
        {
            ShowDropMenu(PnlUplataDrop);
        }

        void BtnPlacanje_Click(object sender, EventArgs e)
        {
            ShowDropMenu(PnlPlacanjeDrop);
        }

        void BtnDizanjeNovca_Click(object sender, EventArgs e)
        {
            ShowDropMenu(PnlDizanjeNovcaDrop);
        }
    }
}
