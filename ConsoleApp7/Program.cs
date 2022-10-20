using ConsoleApp7;
using System;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ps1 = new Person();
            ps1.Age = 60;
            ps1.FirstName = " sdfdsf";
            ps1.LastName = " sdfdsf";


            Person ps2 = new Person();
            ps2.Age = 70;
            ps2.FirstName = "yarin";
            ps2.LastName = " shaer";
            Console.WriteLine($"{ps1.Age}{ps2.Age}");

            Person ps11 = new Person
            {
                 Age= 60,
                 FirstName = "sdf",
                 LastName  = " shaer",

             
            };
            Console.WriteLine(ps11.FirstName);


            //Console.WriteLine(ps1.Age);
            //ps1.Age = 40;
            //Console.WriteLine(ps1.Age);




            //ps.firstName = "yarin";
            //ps.lastName = "sh";
            //ps.age = 50;

            //Console.WriteLine(ps.GetAge());
            //Console.WriteLine(ps.Check());
            //להדפיס האם האורך של המחרוזת   יותר מ5 ע"י שימוש בפונקציה שבודקת

        }
    }
}
