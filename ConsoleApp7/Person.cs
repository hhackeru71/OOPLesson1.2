using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Person
    {

        //ליצור מחלקה חדשה של רכב 
        //להגדיר 3 משתנים כסוג private 

        // שם החברה של הרכב
        // מספר הרכב
        //שנת ייצור

        // מגדירים pro של get ו set לכל אחד מהם 

        //בדיקה  על ה prop של שנת ייצור
        //בדיקה והשנת ייצור קטן מ 1991 
        //לא לעשות השמה

        //ליצור פונקציות
        // פונקציה שמדפיסה את שם החברה של הרכב
        //פונקציה שמדפיסה את המספר של הרכב
        //פונקציה שלישית שמדפיסה את המספר של שנת ייצור



        private string _firstName; //ctr + rr / f2/ rename 
        private string _lastName;
        private int _age;


        //הכימוס (encapsulation).


        //prop
        public string FirstName
        {
            get { return _firstName; }//מחזיר את המידע
            set { _firstName = value; }//השמה למשתנה
        }

        public string LastName
        {
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }



        public void Print()
        {
            Console.WriteLine($"{_firstName}{_lastName}{_age}");
        }


        //public int GetAge()
        //{
        //    return age;
        //}

        //public bool Check()
        //{
        //    return firstName.Length > 5;
        //}





        //פונקציה  שמחזירה את הגיל של המשתמש 

        //פונקציה שמקבלת את השם של המשתמש   ובודקת האם המחרוזת האורך שלה יותר מ5 
        //במידה וכן מחזירה true
        //אחרת false


    }
}
