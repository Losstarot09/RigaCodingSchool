using System;
using System.Text;

namespace Day2Tasks
{
    class Program
    {
        public static void Task1()
        {
            int number1 = new int();
            int number2 = new int();
            do
            {
                bool check = false;
                while (!check)
                {
                    bool valueCheck1 = false;
                    bool valueCheck2 = false;

                    while (!valueCheck1)
                    {
                        Console.Write("Lūdzu, ievadiet mainīgo skaitli, kas ir robežā no 0 līdz 20: ");
                        string firstVar = Console.ReadLine();
                        if (!int.TryParse(firstVar, out number1))
                        {
                            Console.WriteLine("Ievadītais mainīgs nav skaitlis \n");
                        }
                        else if (number1 >= 0 && number1 <= 20)
                        {
                            valueCheck1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Ievadītais skaitlis nav robežā no 0 līdz 20 \n");
                        }
                    }

                    while (!valueCheck2)
                    {
                        Console.Write("Lūdzu, ievadiet mainīgo skaitli, kas ir robežā no 30 līdz 50: ");
                        string secondVar = Console.ReadLine();
                        if (!int.TryParse(secondVar, out number2))
                        {
                            Console.WriteLine("Ievadītais mainīgs nav skaitlis \n");
                        }
                        else if (number2 >= 30 && number2 <= 50)
                        {
                            valueCheck2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Ievadītais skaitlis nav robežā no 30 līdz 50 \n");
                        }
                    }
                    check = true;
                }
                Console.WriteLine($"{number1} + {number2} = {number1 + number2} \n");
                Console.WriteLine("Jā gribat iziet no programmas, nospiediet \"Escape\"," +
                    "\n vai jekuru citu tastatūras klavieri, lai atkartot");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void Task2()
        {
            Console.WriteLine("Mums ir māja ar 5 stāviem un pagrabu, kas satur dažadus priekšmetus.");
            Console.WriteLine("Priekšmeti atrodas konkrētājā stāvā vai pagrabā atkarīgi no 1 burtas prikšmeta nosaukumā.");
            Console.Write("Lūdzu, ivadiet priekšmetu: ");
            do
            {
                string thing = Console.ReadLine();
                string firstFloor = "aābcčd";
                string secondFloor = "eēfgģh";
                string thirdFloor = "iījklļ";
                string fourthFloor = "mnņop";
                string fifthFloor = "rsštuū";
                if (firstFloor.Contains(char.ToLower(thing[0])))
                {
                    Console.WriteLine($"{thing} atrodisies 1. stāvā");
                } 
                else if (secondFloor.Contains(char.ToLower(thing[0])))
                {
                    Console.WriteLine($"{thing} atrodisies 2. stāvā");
                }
                else if (thirdFloor.Contains(char.ToLower(thing[0])))
                {
                    Console.WriteLine($"{thing} atrodisies 3. stāvā");
                }
                else if (fourthFloor.Contains(char.ToLower(thing[0])))
                {
                    Console.WriteLine($"{thing} atrodisies 4. stāvā");
                }
                else if (fifthFloor.Contains(char.ToLower(thing[0])))
                {
                    Console.WriteLine($"{thing} atrodisies 5. stāvā");
                }
                else
                {
                    Console.WriteLine($"{thing} atrodisies pagrabā");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }

        public static void Task3()
        {
            
        }

        public static void TaskExtraDay2()
        {
            
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool check = false;
            while (!check)
            {
                Console.Write("Lūdzu. ievadiet veselo skaitļi no 1 līdz 3, vai extra, lai izpildīt attiecīgo uzdevumu: ");
                switch (Console.ReadLine().Trim())
                {
                    case "1":
                        {
                            Task1();
                            check = true;
                            break;
                        }
                    case "2":
                        {
                            Task2();
                            check = true;
                            break;
                        }
                    case "3":
                        {
                            Task3();
                            check = true;
                            break;
                        }
                    case "extra":
                        {
                            TaskExtraDay2();
                            check = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lūdzu evadiet pareizo ciparu vai vardu!!!");
                            break;
                        }
                }
            }
        }
    }
}
