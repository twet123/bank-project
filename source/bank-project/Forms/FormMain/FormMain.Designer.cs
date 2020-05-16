using System;
using System.Windows.Forms;
using System.Drawing;

namespace bankproject.Forms
{
    public partial class FormMain : Form
    {
        Panel PnlSideMenu;
        Panel PnlLogo;
        Button BtnRacunInfo, BtnStanje, BtnPregled, BtnUplata, BtnNovaUplata, BtnNovoPlacanje, BtnDizanjeNovca;
        Button BtnPlacanje, BtnNovoDizanje;
        Panel PnlRacunInfoDrop, PnlUplataDrop, PnlPlacanjeDrop, PnlDizanjeNovcaDrop;

        public FormMain()
        {
            Render();
        }

        private void Render()
        {
            //FormMain
            this.Font = new Font("Microsoft Sans Serif", 10);
            this.Size = new Size(1020, 720);
            this.MinimumSize = new Size(950, 600);


            //PnlSideMenu
            PnlSideMenu = new Panel();
            PnlSideMenu.BackColor = Color.Black;
            PnlSideMenu.Dock = DockStyle.Left;
            PnlSideMenu.Width = 250;
            PnlSideMenu.AutoScroll = true;

            //PnlLogo
            PnlLogo = new Panel();
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.BackColor = Color.Black;
            PnlLogo.Size = new Size(250, 100);



            //BtnRacunInfo
            BtnRacunInfo = new Button();
            BtnRacunInfo.Dock = DockStyle.Top;
            BtnRacunInfo.Size = new Size(250, 45);
            BtnRacunInfo.Text = "Infomacije o racunu";
            BtnRacunInfo.FlatStyle = FlatStyle.Flat;
            BtnRacunInfo.FlatAppearance.BorderSize = 0;
            BtnRacunInfo.BackColor = Color.Black;
            BtnRacunInfo.ForeColor = Color.White;
            BtnRacunInfo.TextAlign = ContentAlignment.MiddleLeft;
            BtnRacunInfo.Padding = new Padding(10, 0, 0, 0);
            BtnRacunInfo.Click += BtnRacunInfo_Click;

            //PnlRacunInfoDrop
            PnlRacunInfoDrop = new Panel();
            PnlRacunInfoDrop.Dock = DockStyle.Top;
            PnlRacunInfoDrop.BackColor = Color.Gray;
            PnlRacunInfoDrop.Size = new Size(250, 90);
            PnlRacunInfoDrop.Location = new Point(0, 45);
            PnlRacunInfoDrop.Visible = false;

            //BtnStanje
            BtnStanje = new Button();
            BtnStanje.Dock = DockStyle.Top;
            BtnStanje.Size = new Size(250, 45);
            BtnStanje.Text = "Stanje";
            BtnStanje.FlatStyle = FlatStyle.Flat;
            BtnStanje.FlatAppearance.BorderSize = 0;
            BtnStanje.BackColor = Color.Black;
            BtnStanje.ForeColor = Color.White;
            BtnStanje.TextAlign = ContentAlignment.MiddleLeft;
            BtnStanje.Padding = new Padding(35, 0, 0, 0);

            //BtnPregled
            BtnPregled = new Button();
            BtnPregled.Dock = DockStyle.Top;
            BtnPregled.Size = new Size(250, 45);
            BtnPregled.Text = "Pregled";
            BtnPregled.FlatStyle = FlatStyle.Flat;
            BtnPregled.FlatAppearance.BorderSize = 0;
            BtnPregled.BackColor = Color.Black;
            BtnPregled.ForeColor = Color.White;
            BtnPregled.TextAlign = ContentAlignment.MiddleLeft;
            BtnPregled.Padding = new Padding(35, 0, 0, 0);



            //BtnUplata
            BtnUplata = new Button();
            BtnUplata.Dock = DockStyle.Top;
            BtnUplata.Size = new Size(250, 45);
            BtnUplata.Text = "Uplata";
            BtnUplata.FlatStyle = FlatStyle.Flat;
            BtnUplata.FlatAppearance.BorderSize = 0;
            BtnUplata.BackColor = Color.Black;
            BtnUplata.ForeColor = Color.White;
            BtnUplata.TextAlign = ContentAlignment.MiddleLeft;
            BtnUplata.Padding = new Padding(10, 0, 0, 0);
            BtnUplata.Click += BtnUplata_Click;

            //PnlUplataDrop
            PnlUplataDrop = new Panel();
            PnlUplataDrop.Dock = DockStyle.Top;
            PnlUplataDrop.BackColor = Color.Gray;
            PnlUplataDrop.Size = new Size(250, 45);
            PnlUplataDrop.Visible = false;

            //BtnNovaUplata
            BtnNovaUplata = new Button();
            BtnNovaUplata.Dock = DockStyle.Top;
            BtnNovaUplata.Size = new Size(250, 45);
            BtnNovaUplata.Text = "Nova uplata";
            BtnNovaUplata.FlatStyle = FlatStyle.Flat;
            BtnNovaUplata.FlatAppearance.BorderSize = 0;
            BtnNovaUplata.BackColor = Color.Black;
            BtnNovaUplata.ForeColor = Color.White;
            BtnNovaUplata.TextAlign = ContentAlignment.MiddleLeft;
            BtnNovaUplata.Padding = new Padding(35, 0, 0, 0);



            //BtnPlacanje
            BtnPlacanje = new Button();
            BtnPlacanje.Dock = DockStyle.Top;
            BtnPlacanje.Size = new Size(250, 45);
            BtnPlacanje.Text = "Placanje";
            BtnPlacanje.FlatStyle = FlatStyle.Flat;
            BtnPlacanje.FlatAppearance.BorderSize = 0;
            BtnPlacanje.BackColor = Color.Black;
            BtnPlacanje.ForeColor = Color.White;
            BtnPlacanje.TextAlign = ContentAlignment.MiddleLeft;
            BtnPlacanje.Padding = new Padding(10, 0, 0, 0);
            BtnPlacanje.Click += BtnPlacanje_Click;

            //PnlPlacanjeDrop
            PnlPlacanjeDrop = new Panel();
            PnlPlacanjeDrop.Dock = DockStyle.Top;
            PnlPlacanjeDrop.BackColor = Color.Gray;
            PnlPlacanjeDrop.Size = new Size(250, 45);
            PnlPlacanjeDrop.Visible = false;

            //BtnNovoPlacanje
            BtnNovoPlacanje = new Button();
            BtnNovoPlacanje.Dock = DockStyle.Top;
            BtnNovoPlacanje.Size = new Size(250, 45);
            BtnNovoPlacanje.Text = "Novo placanje";
            BtnNovoPlacanje.FlatStyle = FlatStyle.Flat;
            BtnNovoPlacanje.FlatAppearance.BorderSize = 0;
            BtnNovoPlacanje.BackColor = Color.Black;
            BtnNovoPlacanje.ForeColor = Color.White;
            BtnNovoPlacanje.TextAlign = ContentAlignment.MiddleLeft;
            BtnNovoPlacanje.Padding = new Padding(35, 0, 0, 0);



            //BtnDizanjeNovca
            BtnDizanjeNovca = new Button();
            BtnDizanjeNovca.Dock = DockStyle.Top;
            BtnDizanjeNovca.Size = new Size(250, 45);
            BtnDizanjeNovca.Text = "Dizanje novca";
            BtnDizanjeNovca.FlatStyle = FlatStyle.Flat;
            BtnDizanjeNovca.FlatAppearance.BorderSize = 0;
            BtnDizanjeNovca.BackColor = Color.Black;
            BtnDizanjeNovca.ForeColor = Color.White;
            BtnDizanjeNovca.TextAlign = ContentAlignment.MiddleLeft;
            BtnDizanjeNovca.Padding = new Padding(10, 0, 0, 0);
            BtnDizanjeNovca.Click += BtnDizanjeNovca_Click;

            //PnlDizanjeNovcaDrop
            PnlDizanjeNovcaDrop = new Panel();
            PnlDizanjeNovcaDrop.Dock = DockStyle.Top;
            PnlDizanjeNovcaDrop.BackColor = Color.Gray;
            PnlDizanjeNovcaDrop.Size = new Size(250, 45);
            PnlDizanjeNovcaDrop.Location = new Point(0, 200);
            PnlDizanjeNovcaDrop.Visible = false;

            //BtnNovoDizanje
            BtnNovoDizanje = new Button();
            BtnNovoDizanje.Dock = DockStyle.Top;
            BtnNovoDizanje.Size = new Size(250, 45);
            BtnNovoDizanje.Text = "Novo dizanje";
            BtnNovoDizanje.FlatStyle = FlatStyle.Flat;
            BtnNovoDizanje.FlatAppearance.BorderSize = 0;
            BtnNovoDizanje.BackColor = Color.Black;
            BtnNovoDizanje.ForeColor = Color.White;
            BtnNovoDizanje.TextAlign = ContentAlignment.MiddleLeft;
            BtnNovoDizanje.Padding = new Padding(35, 0, 0, 0);



            //Adding controls

            PnlRacunInfoDrop.Controls.Add(BtnStanje);
            PnlRacunInfoDrop.Controls.Add(BtnPregled);

            PnlUplataDrop.Controls.Add(BtnNovaUplata);

            PnlPlacanjeDrop.Controls.Add(BtnNovoPlacanje);

            PnlDizanjeNovcaDrop.Controls.Add(BtnNovoDizanje);

            PnlSideMenu.Controls.Add(PnlDizanjeNovcaDrop);
            PnlSideMenu.Controls.Add(BtnDizanjeNovca);
            PnlSideMenu.Controls.Add(PnlPlacanjeDrop);
            PnlSideMenu.Controls.Add(BtnPlacanje);
            PnlSideMenu.Controls.Add(PnlUplataDrop);
            PnlSideMenu.Controls.Add(BtnUplata);
            PnlSideMenu.Controls.Add(PnlRacunInfoDrop);
            PnlSideMenu.Controls.Add(BtnRacunInfo);
            PnlSideMenu.Controls.Add(PnlLogo);

            this.Controls.Add(PnlSideMenu);
        }

    }
}
