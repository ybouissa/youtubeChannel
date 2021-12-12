using System;
using System.Security.Cryptography.X509Certificates;
using MongoDB.Driver;


namespace MongoDb
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var dblist = dbClient.ListDatabases().ToList();
            dblist.ForEach(x=>Console.WriteLine(x));
            var mongodb = dbClient.GetDatabase("dbtest");
            var students = mongodb.GetCollection<Student>("Students");
            var majors = mongodb.GetCollection < Major > ("Majors");
            Major engineeringMajor = majors.Find(m => m.Description.Equals("Engineering")).FirstOrDefault();
            Student bill = students.Find(x => x.firstname.Equals("Bill")).FirstOrDefault();
            bill.lastname = "Clinton";
            students.ReplaceOne(x => x.firstname.Equals("Bill"), bill);
            majors.DeleteOne(d => d.Description.Equals("Business"));
        }
    }
}
