//  Author:
//       Julien Dubromez<j.dubromez.it@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
  


namespace crisis
{
    public class MainMenu
    {
        private static bool booleanMainMenu;
        public static bool BooleanMainMenu
        {
            get { return MainMenu.booleanMainMenu; }
            set { MainMenu.booleanMainMenu = value; }
        }

        private static bool booleanCategoryMenu;
        public static bool BooleanCategoryMenu
        {
            get { return MainMenu.booleanCategoryMenu; }
            set { MainMenu.booleanCategoryMenu = value; }
        }
        

        public MainMenu()
        {
        }
        

        public static void Version()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Crisis Wordlist Generator  by Julien Dubromez, version : 1.1.3 \n");
            Console.ResetColor();
        }

        public void Menu()
        {
            Version();

            int i = 0;

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.Write(" {0}) ", ++i);
            //Console.ResetColor();
            //Console.WriteLine("\t CRISIS CLIENT/SERVER BRUTE FORCER");            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t CREATE WORDLIST NO JUTSU ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t TRANSFORMING WORDLIST NO JUTSU");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();
            Console.WriteLine("\t USER PASSWORD PROFILER NO JUTSU");
        
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine("\t DOWNLOAD WORDLIST NO JUTSU \t");

            

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            booleanMainMenu = true;
            int dislayMainSubMain = 0;

            while (booleanMainMenu)
            {
                try
                {
                    
                    i = 0;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");


                    //if (dislayMainSubMain == ++i)
                    //{
                    //}
                    if (dislayMainSubMain == ++i)
                    {
                        LocalBruteForcerWordlistMenu();
                        Property.TypeOfProcess = 2;
                    }
                    //TRANSFORMING WORDLIST NO JUTSU
                    if (dislayMainSubMain == ++i)
                    {
                        TransformWordlistMenu();                        
                        Property.TypeOfProcess = 3;
                    }
                    //USER PASSWORD PROFILER
                    if (dislayMainSubMain == ++i)
                    {
                        UserPasswordProfilerWordlistMenu();
                        MenuParameter config = new MenuParameter();
                        config.TypesOfFileAtGenerate();
                        BooleanMainMenu = false;
                        Property.TypeOfProcess = 2;
                    }
                    if (dislayMainSubMain == ++i)
                    {                        
                        Property.TypeOfProcess = 4;
                        BooleanMainMenu = false;
                    }                        
                    // EXIT
                    if (dislayMainSubMain == 99)
                        Environment.Exit(0);

                    
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Enter the number corresponding !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }

            }
        }

        private void UserPasswordProfilerWordlistMenu()
        {
            Version();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" Insert the informations about the victim to make a dictionary ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" If you don't know all the info, just hit enter when asked! ;)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n > ");
            Console.ResetColor();
            Console.Write(" First Name : ");

            string name = Charset.CustomCharsetWord();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" > ");
            Console.ResetColor();
            Console.Write(" Surname : ");

            string surname = Charset.CustomCharsetWord();
            Charset.initialPersonne(name, surname);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" > ");
            Console.ResetColor();
            Console.Write(" Nickname : ");
            Charset.CustomCharsetWord();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" > ");
            Console.ResetColor();
            Console.Write(" Birthdate (DDMMYYYY): ");
            Charset.BirthdatePerson();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n > ");
            Console.ResetColor();
            Console.Write(" Partners name: ");
            Charset.CustomCharsetWord();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" > ");
            Console.ResetColor();
            Console.Write(" Partners nickname: ");
            Charset.CustomCharsetWord();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" > ");
            Console.ResetColor();
            Console.Write(" Pather birthdate (DDMMYYYY): ");
            Charset.BirthdatePerson();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" Child's name  ");
            SubMenu.CustomWordMenu();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" Child's nickname");
            SubMenu.CustomWordMenu();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" Child's birthdate (DDMMYYYY): ");
            SubMenu.BirthdateMenu();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(" Pet's name : ");
            SubMenu.CustomWordMenu();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Company name : ");
            Charset.CustomCharsetWord();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n > ");
            Console.ResetColor();
            Console.Write(" Do you want to add some key words about the victim [i.e. actor,religion,color] ?");
            SubMenu.CustomWordMenu();            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Do you want to add your wordlist ? Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                SubMenu obj = new SubMenu();
                obj.MenuReadFileTxt();
            }
            SubMenu.RemoveDuplicate();

            SubMenu.CustomCharsetLowerMenu();
            SubMenu.RemoveDuplicate();
            SubMenu.CustomCharsetUpperMenu();
            SubMenu.RemoveDuplicate();
            SubMenu.CustomChartsetL33tSpeekMenu();
            SubMenu.RemoveDuplicate();
            SubMenu.CustomCharsetSpecialMenu();
            SubMenu.DisplayCustomCharset();  

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Do you want to add Number [i.e. 0 to 9] Y/[N]: ");
            SubMenu.CustomCharsetNumberMenu();
            SubMenu.RemoveDuplicate();
            
                      
           
        }

        internal static void CrisisMenuNetwork()
        {
            Version();

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine("\t CRISIS SERVER BRUTE FORCER");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();

            Console.WriteLine(" \t CRISIS CLIENT BRUTE FORCER\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", ++i);
            Console.ResetColor();           

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88 ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");


            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == ++i)
                        booleanCategoryMenu = false; // tmp variable
                    Property.TypesOfGeneration = 9;
                    if (dislayMainSubMain == ++i)

                        // EXIT
                        if (dislayMainSubMain == 88)
                        {
                            MainMenu obj = new MainMenu();
                            new Thread(obj.Menu).Start();
                            BooleanMainMenu = true;
                            break;
                        }
                    if (dislayMainSubMain == 99)
                        Environment.Exit(0);

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Enter the number corresponding !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        }

        internal static void LocalBruteForcerWordlistMenu()
        {
            Version();            
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
           
            Console.WriteLine(" \t LATIN\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
           
            
            
            Console.WriteLine(" \t SPECIAL");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();            
            
            Console.WriteLine(" \t SWEDISH");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            
            Console.WriteLine(" \t CYRILLIC");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            
            Console.WriteLine(" \t SYLLABLE FR");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            
            Console.WriteLine(" \t ROUTER\\BOX WIFI");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            Console.ResetColor();

            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");                    
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;
                                        
                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                        SubMenu.LatinMenu();
                        BooleanMainMenu = false;                    
                    //SPECIAL
                    if (dislayMainSubMain == i++)
                        SubMenu.SpecialMenu();
                    // SWEDISH    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SubMenu.SwedishMenu();
                        BooleanMainMenu = false;
                    // CYRILLIC    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SubMenu.CyrillicMenu();
                        BooleanMainMenu = false;
                    // SYLLABLE  CHARACTER
                    if (dislayMainSubMain == i++)
                        SubMenu.SyllableMenu();
                        BooleanMainMenu = false;
                    if (dislayMainSubMain == i++)
                        SubMenu.WifiMenu();
                        BooleanMainMenu = false;
                    // EXIT
                    if (dislayMainSubMain == i++)                    
                        Environment.Exit(0);
                    if (dislayMainSubMain == 88)
                    {
                        new Run();
                        break;
                    }
                    if (dislayMainSubMain == 99)
                        Environment.Exit(0);
                    
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Enter the number corresponding !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();                    
                }
            }
        }

        internal static void TransformWordlistMenu()
        {
            Version();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();

            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine("\t LEET SPEAK");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t LOWERCASE TO UPPERCASE\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t UPPERCASE TO LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
                       
            Console.WriteLine(" \t AUTOMATIC CHARACTER  LOWERCASE <=> UPPERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n 88) ");
            Console.ResetColor();

            Console.WriteLine("\t RETURN");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" 99)");
            Console.ResetColor();

            Console.WriteLine("\t EXIT ");

            Console.ResetColor();

            booleanCategoryMenu = true;
            while (booleanCategoryMenu)
            {
                try
                {
                    //Charset.BooleanType = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    //LEET SPEAK
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuLeetSpeakPrint();
                        Property.TypesOfTransforming = 1;
                        booleanCategoryMenu = false;
                        BooleanMainMenu = false;
                    }
                    // LOWERCASE TO UPPERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuLowercaseToUppercasePrint();
                        Property.TypesOfTransforming = 2;
                        booleanCategoryMenu = false;
                        BooleanMainMenu = false;
                    }
                    // UPPERCASE TO LOWERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuUppercaseToLowercasePrint();
                        Property.TypesOfTransforming = 3;
                        booleanCategoryMenu = false;
                        BooleanMainMenu = false;
                    }                    
                    // AUTOMATIC CHARACTER  LOWERCASE <=> UPPERCASE
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuAutoUppercaseLowercasePrint();
                        Property.TypesOfTransforming = 4;
                        booleanCategoryMenu = false;
                        BooleanMainMenu = false;
                    }                                   
                    if (dislayMainSubMain == 88)
                    {
                        new Run();                        
                    }
                    if (dislayMainSubMain == 99)
                        Environment.Exit(0);

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Enter the number corresponding !");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        }



    } // End class
}// End class namespace
