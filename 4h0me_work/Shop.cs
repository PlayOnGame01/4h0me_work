using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы.Net4hOme_work
{
    internal class Shop
    {
        private string name;
        private string adress;
        private string info;
        private string number;
        private string email;
        public Shop() { }
        public Shop(string n, string a, string i, string num, string e)
        {
            name = n;
            adress = a;
            info = i;
            number = num;
            email = e;
        }
        public void Enter()
        {
            Console.Write("Enter shop: ");
            name = Console.ReadLine();
            Console.Write("Enter adress: ");
            adress = Console.ReadLine();
            Console.Write("Enter info: ");
            info = Console.ReadLine();
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($"\nShop name: {name}");
            Console.WriteLine($"Shop adress: {adress}");
            Console.WriteLine($"Info: {info}");
            Console.WriteLine($"Phone number: {number}");
            Console.WriteLine($"Email: {email}");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
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