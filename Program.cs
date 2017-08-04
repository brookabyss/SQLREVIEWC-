using System;
using DbConnection;
using System.Collections.Generic;
namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read();
            // Insert();
            // Update();
            Delete();
            Console.WriteLine("Hello World!");
        }
        static void Read(){
            var q= DbConnector.Query("SELECT * FROM users;");
             foreach(var user in q ){
                System.Console.WriteLine(user["FirstName"]);
            }

        }
        static void Insert(){
            System.Console.WriteLine("Please input your First Name");
            string FirstName=Console.ReadLine();
            System.Console.WriteLine("Please input your Last Name");
            string LastName=Console.ReadLine();
            System.Console.WriteLine("Please input your Favorite Number");
            string FavoriteNumber=Console.ReadLine();
            string query=($"INSERT INTO users (FirstName,LastName,FavoriteNumber) VALUES ('{FirstName}','{LastName}','{FavoriteNumber}')");
            DbConnector.Execute(query);
            Read();
           

        }
        static void Update(){
            System.Console.WriteLine("Please enter the changed First Name");
            string FirstName=Console.ReadLine();
            System.Console.WriteLine("Please input the id for the user");
            string id=Console.ReadLine();
            string query=($"UPDATE users SET FirstName='{FirstName}' WHERE id={id};");
            DbConnector.Execute(query);
            Read();
        }
        static void Delete(){
            System.Console.WriteLine("Please input the id for the user to Delete");
            string id=Console.ReadLine();
            string query=($"DELETE FROM users WHERE id={id};");
            DbConnector.Execute(query);
            Read();
        }

    }
}
