using System;
using System.Collections.Generic;
using System.Linq;
namespace Adressbok{
    class Program{
        static void writeColor(string str, ConsoleColor theColor){
            Console.ForegroundColor = theColor;
            Console.Write(str);
        }
        static void addName(ref string tmp,ref string[] adress){
            while (true){
                writeColor("Enter full name: ",ConsoleColor.Blue);
                tmp = Console.ReadLine();
                Console.ResetColor();
                if (tmp.Contains(" ") && tmp.Length > 3){
                    List<string> list = new List<string>(adress.ToList());
                    list.Add(tmp);
                    adress = list.ToArray();
                    break;
                }
                else{
                    Console.WriteLine("Please enter a both first and surname.");
                }
            }
        }
        static void showNames(ref string[] adress){
            writeColor("Names:\n", ConsoleColor.Blue);
            Console.ResetColor();
            if(adress != null){
                foreach(string name in adress){
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args){
            char choice;
            string[] adress = {};
            string tmp = "";
            while (true){
                Console.Clear();
                Console.WriteLine("1. Add name");
                Console.WriteLine("2. Show all names");
                Console.WriteLine("3. Clear names");
                Console.WriteLine("Q. Quit");
                writeColor("Enter choice (1-3): ",ConsoleColor.Blue);
                choice = Console.ReadKey().KeyChar;
                Console.ResetColor();
                Console.WriteLine("\n");
                
                switch (choice){
                    case '1':
                        addName(ref tmp,ref adress);
                        break;

                    case '2':
                        showNames(ref adress);
                        break;

                    case '3':
                        adress = null;
 
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