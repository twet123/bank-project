using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using bankproject.Models;
using MongoDB.Driver;

namespace bankproject.Forms.FormPlacanje
{
    public partial class FormPlacanje
    {
        void Handle_Load(object sender, EventArgs e)
        {
            LblHidden.Focus();
        }

        void TbRacunPrimaoca_Enter(object sender, EventArgs e)
        {
            if (TbRacunPrimaoca.Text == "Racun primaoca")
            {
                TbRacunPrimaoca.Text = "";
                TbRacunPrimaoca.ForeColor = Color.Black;
            }
        }

        void TbRacunPrimaoca_Leave(object sender, EventArgs e)
        {
            if (TbRacunPrimaoca.Text == "")
            {
                TbRacunPrimaoca.Text = "Racun primaoca";
                TbRacunPrimaoca.ForeColor = Color.Silver;
            }
        }

        void TbPoruka_Enter(object sender, EventArgs e)
        {
            if (TbPoruka.Text == "Poruka")
            {
                TbPoruka.Text = "";
                TbPoruka.ForeColor = Color.Black;
            }
        }

        void TbPoruka_Leave(object sender, EventArgs e)
        {
            if (TbPoruka.Text == "")
            {
                TbPoruka.Text = "Poruka";
                TbPoruka.ForeColor = Color.Silver;
            }
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
            int oduzmi;
            if (int.TryParse(TbIznos.Text, out oduzmi))
            {
                int trenutnoStanje = int.Parse(trenutniNalog.stanje);

                if (trenutnoStanje - oduzmi < 0)
                {
                    MessageBox.Show("Nemate dovoljno para na racunu!");
                    return;
                }

                var db = Database.Database.Instance.GetDatabase("banka");

                var collection = db.GetCollection<Nalog>("racuni");

                var collectionTransakcije = db.GetCollection<Transakcija>("transakcije");

                Nalog nalog = collection.Find(item => item.brojRacuna == TbRacunPrimaoca.Text).FirstOrDefault();

                if(nalog == null)
                {
                    MessageBox.Show("Nepostojeci broj racuna!");
                    return;
                }

                int stanjeNovoNalog = int.Parse(nalog.stanje);

                stanjeNovoNalog += oduzmi;

                int pom = oduzmi;

                nalog.stanje = stanjeNovoNalog.ToString();

                trenutnoStanje -= oduzmi;

                trenutniNalog.stanje = trenutnoStanje.ToString();

                oduzmi = -oduzmi;

                Transakcija transakcija = new Transakcija { primalac = nalog.brojRacuna, posaljilac = trenutniNalog.brojRacuna, iznos = pom.ToString(), valuta = "RSD" };

                collectionTransakcije.InsertOne(transakcija);

                var filter = Builders<Nalog>.Filter.Eq(s => s._id, trenutniNalog._id);
                var filter2 = Builders<Nalog>.Filter.Eq(s => s.brojRacuna, nalog.brojRacuna);

                collection.ReplaceOne(filter, trenutniNalog);
                collection.ReplaceOne(filter2, nalog);
            }
            else
            {
                MessageBox.Show("Nepravilan iznos!");
                return;
            }
        }
    }
}
