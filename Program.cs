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
                    adress.Add(tmp.ToLower());
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
            adress.Clear();
            Console.ResetColor();
        }

        static void search(ref List<string> adress){
            string searchStr = "";
            while (true){
                writeColor($"Search: {searchStr}",ConsoleColor.Blue);
                var key = System.Console.ReadKey(true);
                Console.ResetColor();
                if (key.Key == ConsoleKey.Enter){
                    break;
                }
                Console.Clear();
                searchStr += key.KeyChar;
                
                foreach(string name in adress){
                    if (name.Contains(searchStr.ToLower())){
                        Console.WriteLine(name);
                    }
                }
            }

        }
        static void remove(ref List<string> adress){
            string searchStr = "";
            while (true){
                writeColor($"Press enter to remove: {searchStr}",ConsoleColor.Blue);
                var key = System.Console.ReadKey(true);
                Console.ResetColor();
                if (key.Key == ConsoleKey.Enter){
                    Console.Clear();
                    foreach(string name in adress.ToList()){
                        if (name.Contains(searchStr.ToLower())){
                            adress.RemoveAt(adress.IndexOf(name));
                        }
                    }
                    break;
                }
                Console.Clear();
                searchStr += key.KeyChar;
                foreach(string name in adress){
                    if (name.Contains(searchStr.ToLower())){
                        Console.WriteLine(name);
                    }
                }
            }

        }
        static void isActive(string str,int thisChoice,ref int currentChoice){
            if (thisChoice == currentChoice)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(str);
                Console.ResetColor();
            }else{
                Console.WriteLine(str);
            }
        }
        static void changeUp(ref int currentChoice){
            if (currentChoice > 1)
            {
                currentChoice--;
            }
        }
        static void changeDown(ref int currentChoice){
            if (currentChoice < 6)
            {
                currentChoice++;
            }
        }
        static void Main(string[] args){
            int choice;
            List<string> adress = new List<string>();
            string tmp = "";
            int currentChoice = 1;
            while (true){
                while (true)
                {
                    Console.Clear();
                    writeColor("Choose using arrow keys (Press enter to continue)\n",ConsoleColor.Blue);
                    Console.ResetColor();
                    isActive("Add name",1,ref currentChoice);
                    isActive("Show all names",2,ref currentChoice);
                    isActive("Clear names",3,ref currentChoice);
                    isActive("Search",4,ref currentChoice);
                    isActive("Remove name(s)",5,ref currentChoice);
                    isActive("Quit",6,ref currentChoice);
                    
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        choice = currentChoice;
                        break;
                    }else if( key.Key == ConsoleKey.DownArrow){
                        changeDown(ref currentChoice);
                    }else if(key.Key == ConsoleKey.UpArrow){
                        changeUp(ref currentChoice);
                    }
                    
                }
                
                Console.WriteLine("\n");
                switch (choice){
                    case 1:
                        addName(ref tmp,ref adress);
                        break;

                    case 2:
                        showNames(ref adress);
                        break;

                    case 3:
                        clearNames(ref adress);
 
                        break;
                    case 4:
                        search(ref adress);
 
                        break;
                    case 5:
                        remove(ref adress);
 
                        break;
                    case 6:
                        Console.ResetColor();
                        return; 
                    default: 
                        break;
                }
            }
        }
    }
}