using System;
using System.Collections.Generic;
using System.Linq;
namespace Adressbok{
    class Program{
        static void writeColor(string str, ConsoleColor theColor){
            Console.ForegroundColor = theColor;
            Console.Write(str);
        }
        static void addName(ref string tmp,ref List<string> adress){
            while (true){
                writeColor("Enter first name: ",ConsoleColor.Blue);
                tmp = Console.ReadLine();
                Console.ResetColor();
                if (!String.IsNullOrEmpty(tmp))
                {
                    adress.Add(tmp);
                    break;
                }            
                else{
                    Console.WriteLine("Please enter a name");
                }
            }
        }
        static void showNames(ref List<string> adress){
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
        
        static void clearNames(ref List<string> adress){

        }
        static void Main(string[] args){
            char choice;
            List<string> adress = new List<string>();
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
                        adress.Clear();
 
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