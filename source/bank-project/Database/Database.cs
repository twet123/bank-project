using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace bankproject.Database
{
    public sealed class Database
    {
        private static readonly MongoClient instance = new MongoClient("mongodb://localhost:27017");

        static Database()
        {

        }

        private Database()
        {

        }

        public static MongoClient Instance
        {
            get { return instance; }
        }
    }
}
