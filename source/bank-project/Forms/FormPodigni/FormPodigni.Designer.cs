﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using bankproject.Models;

namespace bankproject.Forms.FormPodigni
{
    public partial class FormPodigni : Form
    {
        Label LblHidden;
        TextBox TbIznos;
        Panel Line;
        ComboBox CbValuta;
        Button BtnPodigni;
        Nalog trenutniNalog;

        public FormPodigni(Nalog nalog)
        {
            Render();
            trenutniNalog = nalog;
        }

        void Render()
        {
            this.Size = new Size(770, 720);
            this.Load += Handle_Load;

            //TbIznos
            TbIznos = new TextBox();
            TbIznos.Size = new Size(250, 200);
            TbIznos.Location = new Point(390, 150);
            TbIznos.BorderStyle = BorderStyle.None;
            TbIznos.Font = new Font("Arial", 30);
            TbIznos.ForeColor = Color.Silver;
            TbIznos.Text = "Iznos";
            TbIznos.Enter += TbIznos_Enter;
            TbIznos.Leave += TbIznos_Leave;

            //Line
            Line = new Panel();
            Line.ForeColor = Color.Black;
            Line.BackColor = Color.Black;
            Line.Location = new Point(340, 210);
            Line.Size = new Size(550, 1);

            //CbValuta
            CbValuta = new ComboBox();
            CbValuta.Size = new Size(200, 200);
            CbValuta.Font = new Font("Arial", 25);
            CbValuta.Location = new Point(650, 150);
            CbValuta.DataSource = new List<String> { "RSD" };

            //BtnPodigni
            BtnPodigni = new Button();
            BtnPodigni.Location = new Point(510, 250);
            BtnPodigni.Size = new Size(250, 50);
            BtnPodigni.BackColor = Color.Black;
            BtnPodigni.ForeColor = Color.White;
            BtnPodigni.Text = "Podigni";
            BtnPodigni.Font = new Font("Microsoft Sans Serif", 15);
            BtnPodigni.Click += BtnPodigni_Click;

            //LblHidden
            LblHidden = new Label();
            LblHidden.Location = new Point(-10, 0);
            LblHidden.Size = new Size(0, 0);

            this.Controls.Add(TbIznos);
            this.Controls.Add(Line);
            this.Controls.Add(CbValuta);
            this.Controls.Add(BtnPodigni);
            this.Controls.Add(LblHidden);
        }

    }
}
