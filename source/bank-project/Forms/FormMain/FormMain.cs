using System;
using System.Windows.Forms;
using System.Drawing;
using bankproject.Models;

namespace bankproject.Forms
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        private Nalog currentNalog;

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

        void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlMainForm.Controls.Add(childForm);
            PnlMainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void BtnPregled_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPregled.FormPregled(currentNalog));
        }

        void BtnNovaUplata_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUplata.FormUplata(currentNalog));
        }

        void BtnNovoDizanje_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPodigni.FormPodigni(currentNalog));
        }

        void BtnNovoPlacanje_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPlacanje.FormPlacanje(currentNalog));
        }
    }
}
