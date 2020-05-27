using System;
using MongoDB.Bson;
using MongoDB.Driver;
namespace bankproject.Models
{
    public class Transakcija
    {
        public ObjectId _id { get; set; }
        public string primalac { get; set; }
        public string posaljilac { get; set; }
        public string iznos { get; set; }
        public string valuta { get; set; }

        public override string ToString()
        {
            return $"Primalac: {primalac}, Posaljilac: {posaljilac}, Iznos: {iznos}, Valuta: {valuta}";
        }
    }
}
