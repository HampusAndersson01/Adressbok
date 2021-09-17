using System;
namespace Adressbok{
    class Program{
        static void Main(string[] args){
            char choice;
            string adress = "";
            string tmp = "";
            int names = 0;
            while (true){
                Console.Clear();
                Console.WriteLine("1. Add name");
                Console.WriteLine("2. Show all names");
                Console.WriteLine("3. Clear names"); 
                Console.WriteLine("4. Statistics");
                Console.WriteLine("Q. Quit");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter choice (1-4): ");
                choice = Console.ReadKey().KeyChar;
                Console.ResetColor();
                Console.WriteLine("\n");
                
                switch (choice){
                    case '1':
                        while (true){
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Enter full name: ");
                            tmp = Console.ReadLine();
                            Console.ResetColor();
                            if (tmp.Contains(" ") && tmp.Length > 3){
                                adress += tmp + "\n";
                                names++;
                                break;
                            }
                            else{
                                Console.WriteLine("Please enter a both first and surname.");
                            }
                        }
                        break;

                    case '2':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Names:");
                        Console.ResetColor();
                        Console.Write(adress);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case '3':
                        Console.WriteLine("");
                        adress = "";
                        names = 0;
                        break;

                    case '4':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Statistics:");
                        Console.ResetColor();
                        Console.WriteLine("Amount of names: " + Convert.ToString(names));
                        Console.WriteLine("Amount of Characters: " + Convert.ToString(adress.Length - names));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case 'q' or 'Q':
                        Console.ResetColor();
                        return; 
                    default: 
                        break;
                        
                }
            }
        }
    }
}