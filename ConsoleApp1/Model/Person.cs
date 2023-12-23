using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public  class Person
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int CardId { get; set; }
        public string TelePhone { get; set; }
        public string Address { get; set; }
    
        public Person()
        {
            Id = 0;
            Name = "null";
            Gender = "null";
            CardId = 0;
            TelePhone = "null";
            Address = "null";
        }
        public void Input()
        {
            Console.WriteLine(">>>>>>>>>>>Input your information detail>>>>>>>>>");
            Console.Write("Input Id:");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Input Name:");
            Name = Console.ReadLine();
            Console.Write("Input Gender(Male/Female):");
            Gender = Console.ReadLine();
            Console.Write("Input CardId:");
            CardId = int.Parse(Console.ReadLine());
            Console.Write("Input Phone Number:");
            TelePhone = Console.ReadLine();
            Console.Write("Input Address :");
            Address = Console.ReadLine();

        }
        public void Output()
        {
            Console.WriteLine("This is imformation Detail ");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"CardId: {CardId}");
            Console.WriteLine($"Phone: {TelePhone}");
            Console.WriteLine($"Address: {Address}");
             
        }
        
    }
    
    class Employee: Person
    {
        public double Salary {  get; set; }
        public string Role { get; set; }
        public double Bonus { get; set; }
        public void Input()
        {
            base.Input();
            Console.Write("Input Salary:");
            Salary = double.Parse(Console.ReadLine());
            Console.Write("Input Role:");
            Role = Console.ReadLine();
            Console.Write("Input Bounus:");
            Bonus = double.Parse(Console.ReadLine());
        }
        public void Ouput()
        {
            base.Output();
            Console.WriteLine($"Salary:{Salary}");
            Console.WriteLine($"Role:{Role}");
            Console.WriteLine($"Bounus:{Bonus}");
        }
    }
    class Teacher:Person
    {
        public string Subject { get; set; }
        public double Salary { get; set; }
        public string Role { get; set; }
        public double Bonus { get; set; }

        public void Input()
        {
            base.Input();
            Console.Write("Input Subject:");
            Subject = Console.ReadLine();
            Console.Write("Input Salary:");
            Salary = double.Parse(Console.ReadLine());
            Console.Write("Input Role:");
            Role = Console.ReadLine();
            Console.Write("Input Bounus:");
            Bonus = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Salary:{Salary}");
            Console.WriteLine($"Role:{Role}");
            Console.WriteLine($"Bounus:{Bonus}");
        }
    }


}
