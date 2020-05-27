using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using bankproject.Models;

namespace bankproject.Forms.FormPlacanje
{
    public partial class FormPlacanje : Form
    {
        Label LblHidden;
        TextBox TbIznos, TbRacunPrimaoca, TbPoruka;
        Panel Line;
        ComboBox CbValuta;
        Button BtnUplati;
        Nalog trenutniNalog;

        public FormPlacanje(Nalog nalog)
        {
            Render();
            trenutniNalog = nalog;
        }

        void Render()
        {
            this.Size = new Size(770, 720);
            this.Load += Handle_Load;

            //TbRacunPrimaoca
            TbRacunPrimaoca = new TextBox();
            TbRacunPrimaoca.Size = new Size(460, 150);
            TbRacunPrimaoca.Location = new Point(390, 150);
            TbRacunPrimaoca.BorderStyle = BorderStyle.None;
            TbRacunPrimaoca.Font = new Font("Arial", 30);
            TbRacunPrimaoca.ForeColor = Color.Silver;
            TbRacunPrimaoca.Text = "Racun primaoca";
            TbRacunPrimaoca.Enter += TbRacunPrimaoca_Enter;
            TbRacunPrimaoca.Leave += TbRacunPrimaoca_Leave;

            //TbPoruka
            TbPoruka = new TextBox();
            TbPoruka.Location = new Point(390, 223);
            TbPoruka.BorderStyle = BorderStyle.None;
            TbPoruka.Multiline = true;
            TbPoruka.Size = new Size(460, 50);
            TbPoruka.Font = new Font("Arial", 10);
            TbPoruka.ForeColor = Color.Silver;
            TbPoruka.Text = "Poruka";
            TbPoruka.Enter += TbPoruka_Enter;
            TbPoruka.Leave += TbPoruka_Leave;

            //TbIznos
            TbIznos = new TextBox();
            TbIznos.Size = new Size(250, 200);
            TbIznos.Location = new Point(390, 300);
            TbIznos.BorderStyle = BorderStyle.None;
            TbIznos.Font = new Font("Arial", 30);
            TbIznos.ForeColor = Color.Silver;
            TbIznos.Text = "Iznos";
            TbIznos.Enter += TbIznos_Enter;
            TbIznos.Leave += TbIznos_Leave;

            //CbValuta
            CbValuta = new ComboBox();
            CbValuta.Size = new Size(200, 200);
            CbValuta.Font = new Font("Arial", 25);
            CbValuta.Location = new Point(650, 300);
            CbValuta.DataSource = new List<String> { "RSD" };

            //Line
            Line = new Panel();
            Line.ForeColor = Color.Black;
            Line.BackColor = Color.Black;
            Line.Location = new Point(340, 360);
            Line.Size = new Size(550, 1);

            //BtnUplati
            BtnUplati = new Button();
            BtnUplati.Location = new Point(510, 400);
            BtnUplati.Size = new Size(250, 50);
            BtnUplati.BackColor = Color.Black;
            BtnUplati.ForeColor = Color.White;
            BtnUplati.Text = "Plati";
            BtnUplati.Font = new Font("Microsoft Sans Serif", 15);
            BtnUplati.Click += BtnUplati_Click;

            //LblHidden
            LblHidden = new Label();
            LblHidden.Location = new Point(-10, 0);
            LblHidden.Size = new Size(0, 0);

            this.Controls.Add(TbIznos);
            this.Controls.Add(Line);
            this.Controls.Add(CbValuta);
            this.Controls.Add(BtnUplati);
            this.Controls.Add(TbRacunPrimaoca);
            this.Controls.Add(TbPoruka);
            this.Controls.Add(LblHidden);
        }
    }
}
