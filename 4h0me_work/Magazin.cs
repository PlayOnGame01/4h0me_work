using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы .Net4hOme_work 
{
    internal class Magazine
    {
        private string name;
        private string year;
        private string info;
        private string number;
        private string email;

        public Magazine() { }
        public Magazine(string n, string y, string i, string num, string e)
        {
            name = n;
            year = y;
            info = i;
            number = num;
            email = e;
        }

        public void Enter()
        {
            Console.Write("Enter name of magazine: ");
            name = Console.ReadLine();
            Console.Write("Enter year of foundation of the magazine: ");
            year = Console.ReadLine();
            Console.Write("Enter some info about the magazine: ");
            info = Console.ReadLine();
            Console.Write("Enter phone number: ");
            number = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"\nName of magazine: {name}");
            Console.WriteLine($"Year of foundation: {year}");
            Console.WriteLine($"Info: {info}");
            Console.WriteLine($"Phone number: {number}");
            Console.WriteLine($"Email: {email}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}