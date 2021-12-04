using System;
using Demo.ConsoleApp.Models;
namespace Demo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
UAStudentsPPAContext mydb=new UAStudentsPPAContext();

Category category=new Category(){
Description="Music"
};

mydb.Categories.Add(category);
mydb.SaveChanges();


        }

    }
}
