using System;
using System.Windows.Forms;
using System.Drawing;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using bankproject.Models;
using bankproject.Database;

namespace bankproject.Forms.FormPregled
{
    public partial class FormPregled : Form
    {
        void Handle_Load(object sender, EventArgs e)
        {
            LblHidden.Focus();

            LblStanje.Text = trenutniNalog.stanje + " RSD";

            var db = Database.Database.Instance.GetDatabase("banka");

            var collection = db.GetCollection<Transakcija>("transakcije");

            //var document = new Transakcija {primalac = "300", posaljilac = "300", iznos = "300", valuta = "RSD"};

            //collection.InsertOne(document);

            var transakcije = collection.Find(item => (item.posaljilac == trenutniNalog.brojRacuna) || (item.primalac == trenutniNalog.brojRacuna)).ToList();

            LwTransakcije.Items.Clear();

            foreach (Transakcija item in transakcije)
            {
                ListViewItem novi = new ListViewItem(new[] { item.posaljilac, item.primalac, item.iznos, item.valuta });
                LwTransakcije.Items.Add(novi);
            }

            //Console.WriteLine("usao");

        }
    }
}
