using System;
using System.Windows.Forms;
using System.Drawing;
using MongoDB.Driver;
using bankproject.Models;

namespace bankproject.Forms.FormPodigni
{
    public partial class FormPodigni : Form
    {
        void Handle_Load(object sender, EventArgs e)
        {
            LblHidden.Focus();
        }

        void TbIznos_Enter(object sender, EventArgs e)
        {
            if (TbIznos.Text == "Iznos")
            {
                TbIznos.Text = "";

                TbIznos.ForeColor = Color.Black;
            }
        }

        void TbIznos_Leave(object sender, EventArgs e)
        {
            if (TbIznos.Text == "")
            {
                TbIznos.Text = "Iznos";

                TbIznos.ForeColor = Color.Silver;
            }
        }

        void BtnPodigni_Click(object sender, EventArgs e)
        {
            int oduzmi;
            if (int.TryParse(TbIznos.Text, out oduzmi))
            {
                int trenutnoStanje = int.Parse(trenutniNalog.stanje);

                if(trenutnoStanje - oduzmi < 0)
                {
                    MessageBox.Show("Nemate dovoljno para na racunu!");
                    return;
                }

                trenutnoStanje -= oduzmi;

                trenutniNalog.stanje = trenutnoStanje.ToString();

                var db = Database.Database.Instance.GetDatabase("banka");

                var collection = db.GetCollection<Nalog>("racuni");

                var collectionTransakcije = db.GetCollection<Transakcija>("transakcije");

                oduzmi = -oduzmi;

                Transakcija transakcija = new Transakcija { primalac = trenutniNalog.brojRacuna, posaljilac = "dizanje", iznos = oduzmi.ToString(), valuta = "RSD" };

                collectionTransakcije.InsertOne(transakcija);

                var filter = Builders<Nalog>.Filter.Eq(s => s._id, trenutniNalog._id);

                collection.ReplaceOne(filter, trenutniNalog);
            }
            else
            {
                MessageBox.Show("Nepravilan iznos!");
                return;
            }
        }
    }
}
