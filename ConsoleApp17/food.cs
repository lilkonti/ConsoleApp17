using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Food
    {
        public string foodName { get; set; }
        public string foodKitchen { get; set; }
        public string foodElement { get; set; }
        public string foodTime { get; set; }
        public string foodStep { get; set; }
        public string foodCcal { get; set; }
        public string foodType { get; set; }

        public Food()
        {
            Console.WriteLine("Enter name");
            foodName = Console.ReadLine();
            Console.WriteLine("Enter kitchen");
            foodKitchen = Console.ReadLine();
            Console.WriteLine("Enter element");
            foodElement = Console.ReadLine();
            Console.WriteLine("Enter time");
            foodTime = Console.ReadLine();
            Console.WriteLine("Enter step");
            foodStep = Console.ReadLine();
            Console.WriteLine("Enter ccal");
            foodCcal = Console.ReadLine();
            Console.WriteLine("Enter type");
            foodType = Console.ReadLine();
        }
        public void changeFood()
        {
            Console.WriteLine("Now " + foodName + " Enter new name");
            foodName = Console.ReadLine();
            Console.WriteLine("Now + " + foodKitchen + "Enter new kitchen");
            foodKitchen = Console.ReadLine();
            Console.WriteLine("Now + " + foodElement + "Enter new element");
            foodElement = Console.ReadLine();
            Console.WriteLine("Now + " + foodTime + "Enter new time");
            foodTime = Console.ReadLine();
            Console.WriteLine("Now + " + foodStep + "Enter new step");
            foodStep = Console.ReadLine();
            Console.WriteLine("Now + " + foodCcal + "Enter new ccal");
            foodCcal = Console.ReadLine();
            Console.WriteLine("Now + " + foodType + "Enter new type");
            foodType = Console.ReadLine();
        }
        public void showName() { Console.WriteLine("Name: " + foodName); }
        public void showKitchen() { Console.WriteLine("Kithen: " + foodKitchen); }
        public void showElement() { Console.WriteLine("Element: " + foodElement); }
        public void showTime() { Console.WriteLine("Time: " + foodTime); }
        public void showStep() { Console.WriteLine("Step: " + foodStep); }
        public void showCcal() { Console.WriteLine("Ccal: " + foodCcal); }
        public void showType() { Console.WriteLine("Type: " + foodType); }
    }
}
