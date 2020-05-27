using System;
using System.Windows.Forms;
using System.Drawing;
using bankproject.Models;
using MongoDB.Driver;

namespace bankproject.Forms.FormUplata
{
    public partial class FormUplata : Form
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

        void BtnUplati_Click(object sender, EventArgs e)
        {
            int dodaj;
            if(int.TryParse(TbIznos.Text, out dodaj))
            {
                int trenutnoStanje = int.Parse(trenutniNalog.stanje);

                trenutnoStanje += dodaj;

                trenutniNalog.stanje = trenutnoStanje.ToString();

                var db = Database.Database.Instance.GetDatabase("banka");

                var collection = db.GetCollection<Nalog>("racuni");

                var collectionTransakcije = db.GetCollection<Transakcija>("transakcije");

                Transakcija transakcija = new Transakcija { primalac = trenutniNalog.brojRacuna, posaljilac = "uplata", iznos = dodaj.ToString(), valuta = "RSD" };

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
