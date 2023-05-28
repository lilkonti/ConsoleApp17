using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Korn_\\source\\repos\\ConsoleApp17\\food.txt";
            File.Create(path).Dispose();
            List<Food> foods = new List<Food>();
            while (true)
            {
                Console.WriteLine("enter number\n1: add recipe\n2: delete recipe\n3: chenge recipe");
                Console.WriteLine("4: save in file\n5: download from file\n6: show info\n7: exit");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    foods.Add(new Food());
                }
                else if (ans == 2)
                {
                    Console.WriteLine("What recipe delete?");
                    ans = int.Parse(Console.ReadLine());
                    foods.Remove(foods[Convert.ToInt32(ans)]);
                }
                else if (ans == 3)
                {
                    Console.WriteLine("What recipe change?");
                    ans = int.Parse(Console.ReadLine());
                    foods[Convert.ToInt32(ans)].changeFood();
                }
                else if (ans == 4) 
                {
                    foreach (Food food in foods) 
                    {
                        string buff = File.ReadAllText(path);
                        File.WriteAllText(path ,buff + food.foodName + '\n' + food.foodKitchen + '\n' + food.foodElement + '\n' + food.foodType + '\n' + food.foodStep + '\n' + food.foodCcal + '\n' + food.foodType + "\n \n \n");
                    }
                }
                else if (ans == 6)
                {
                    Console.WriteLine("What info you won't");
                    Console.WriteLine("1:name\n2:kitchen\n3:element\n4:time\n5:step\n6:ccal\n7:type");
                    ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        foreach (Food food in foods) { food.showName(); }
                    }
                    else if (ans == 2)
                    {
                        foreach (Food food in foods) { food.showKitchen(); }
                    }
                    else if (ans == 3)
                    {
                        foreach (Food food in foods) { food.showElement(); }
                    }
                    else if (ans == 4)
                    {
                        foreach (Food food in foods) { food.showTime(); }
                    }
                    else if (ans == 5)
                    {
                        foreach (Food food in foods) { food.showStep(); }
                    }
                    else if (ans == 6)
                    {
                        foreach (Food food in foods) { food.showCcal(); }
                    }
                    else if (ans == 7)
                    {
                        foreach (Food food in foods) { food.showType(); }
                    }
                }
                else if (ans == 7)
                {
                    break;
                }
                Console.WriteLine("\n\n\n\n\n\n\n");
            }
        }
    }
}