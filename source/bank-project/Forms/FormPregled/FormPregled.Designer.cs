using System;
using System.Windows.Forms;
using System.Drawing;
using MongoDB.Driver;
using bankproject.Models;

namespace bankproject.Forms.FormPregled
{
    public partial class FormPregled : Form
    {
        ListView LwTransakcije;
        Label LblStanje;
        Label LblHidden;
        Nalog trenutniNalog;

        public FormPregled(Nalog nalog)
        {
            Render();
            trenutniNalog = nalog;
        }

        void Render()
        {
            this.Size = new Size(770, 720);
            this.Load += Handle_Load;

            //LwTransakcije
            LwTransakcije = new ListView();
            LwTransakcije.View = View.Details;
            LwTransakcije.Columns.Add("Posaljilac", 200);
            LwTransakcije.Columns.Add("Primalac", 200);
            LwTransakcije.Columns.Add("Promena stanja", 200);
            LwTransakcije.Columns.Add("Valuta", 95);
            LwTransakcije.Size = new Size(700, 450);
            LwTransakcije.Location = new Point(285, 200);

            //LblStanje
            LblStanje = new Label();
            LblStanje.Location = new Point(385, 50);
            LblStanje.Size = new Size(500, 100);
            LblStanje.Font = new Font("Arial", 50);
            LblStanje.TextAlign = ContentAlignment.MiddleCenter;
            LblStanje.Text = "25.000 RSD";

            //LblHidden
            LblHidden = new Label();
            LblHidden.Location = new Point(-10, 0);
            LblHidden.Size = new Size(0, 0);

            this.Controls.Add(LwTransakcije);
            this.Controls.Add(LblStanje);
            this.Controls.Add(LblHidden);
        }
    }
}
