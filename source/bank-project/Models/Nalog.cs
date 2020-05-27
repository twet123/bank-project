using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace bankproject.Models
{
    public class Nalog
    {
        public ObjectId _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string brojRacuna { get; set; }
        public string stanje { get; set; }

        public override string ToString()
        {
            return $"Username: {username}, password: {password}, brojracuna: {brojRacuna}, stanje: {stanje}";
        }
    }
}
