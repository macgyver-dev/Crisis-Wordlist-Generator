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
    public class SubMenu : Property
    {

        private static bool booleanSubMenu;

        public static bool BooleanSubMenu
        {
            get { return SubMenu.booleanSubMenu; }
            set { SubMenu.booleanSubMenu = value; }
        }
        
        public SubMenu()
        {
            booleanSubMenu = true;
        }

        internal void GenericMenuSelectCharset()
        {
            Command run = new Command(true);
            while (Charset.BooleanType)
            {
                Console.Write(" Write the name corresponding to your choice : ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Charset.CharsetName = Console.ReadLine().ToLower();
                Console.ResetColor();

                string[] args = new string[] { Charset.CharsetName };
                run.FunctionPattern(args);
            }
        }

        internal void MenuReadFileTxt()
        {
            while (Charset.BooleanType)
            {
                Console.Write(" Enter the name and path of your file : ");
                Charset.CharsetName = Console.ReadLine().ToLower();
                Charset.ReadFileTxt();
            }
        }        

        internal static void LatinMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MainMenu.BooleanCategoryMenu = false;
            MenuParameter config = new MenuParameter();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER UPPERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t LATIN\t    CHARACTER UPPERCASE & LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t RETURN\t    MAIN MENU");


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    byte dislayMainSubMain = byte.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.LatinCharacterLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.LatinCharacteUppercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.LatinCharacterUppercaseLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }
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

        internal void MenuCustomLetter()
        {
            while (Charset.BooleanType)
            {
                Console.Write(" Write your custom pattern : ");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string s = Console.ReadLine();
                Console.ResetColor();

                if (s.Length > 1 & s != null)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        Charset.CharsetSelecting.Add(s[i].ToString());
                    }

                    Charset.BooleanType = false;
                    MainMenu.BooleanCategoryMenu = false;

                }
                else
                {
                    Charset.BooleanType = true;
                }
            }
        }

        

        internal static void SpecialMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MainMenu.BooleanCategoryMenu = false;
            MenuParameter config = new MenuParameter();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t HEXA");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t NUMBER");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CUSTOM");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t SPECIAL CHARACTER");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine("\t RETURN  MAIN MENU");


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuHexaPrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuNumericPrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    //CUSTOM    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        objSubMenu.MenuCustomLetter();                        
                        config.TypesOfFileAtGenerate();                        
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.MenuSpecialCharacteresPrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }

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

        public static void SwedishMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MainMenu.BooleanCategoryMenu = false;
            MenuParameter config = new MenuParameter();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER UPPERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SWEDISH    CHARACTER UPPERCASE & LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t RETURN\t    MAIN MENU");


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;


                    // SWEDISH    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SwddishCharacterLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SwddishCharacterUppercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SwddishCharacterLowercaseUppercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }

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

        internal static void CyrillicMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MainMenu.BooleanCategoryMenu = false;
            MenuParameter config = new MenuParameter();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");

            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER UPPERCASE");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t CYRILLIC    CHARACTER UPPERCASE & LOWERCASE");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine(" \t RETURN\t    MAIN MENU");


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;


                    // CYRILLIC    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.CyrillicCharacterLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.CyrillicCharacterUppercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.CyrillicCharacterUppercaseLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }

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

        internal static void SyllableMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MainMenu.BooleanCategoryMenu = false;
            MenuParameter config = new MenuParameter();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER UPPERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t SYLLABLE   CHARACTER UPPERCASE & LOWERCASE");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t RETURN     MAIN MENU");
            Console.ResetColor();


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.Write("\n");
                    i = 0;

                    //        SYLLABLE   CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SyllableCharacterLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SyllableCharacteUppercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SyllableCharacterUppercaseLowercasePrint();
                        objSubMenu.GenericMenuSelectCharset();
                        config.TypesOfFileAtGenerate();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }
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

        public static void WifiMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            MenuParameter.TypesOfGeneration = 6;

            MainMenu.BooleanCategoryMenu = false;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \tBOX ADSL SFR ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \tBOX ADSL LIVEBOX ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \tRETURN     MAIN MENU");
            Console.ResetColor();


            while (SubMenu.BooleanSubMenu)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[+] ");
                    Console.ResetColor();
                    Console.Write(" With what category you want to work : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int dislayMainSubMain = int.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                    Console.Write("\n");
                    i = 0;

                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.SfrPrint();
                        objSubMenu.GenericMenuSelectCharset();
                    }
                    if (dislayMainSubMain == i++)
                    {
                        DisplayCharset.LiveboxPrint();
                        objSubMenu.GenericMenuSelectCharset();
                    }
                    else if (dislayMainSubMain == i++)
                    {
                        Console.Clear();
                        new Run();
                    }
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

        public static void CustomWordMenu()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.WriteLine(" Press the Escape (Esc) key to quit or press Enter for continue:");
                     
            ConsoleKeyInfo quit;
            quit = Console.ReadKey();

           

            while (quit.Key != ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n[+] ");
                Console.ResetColor();
                Console.WriteLine(" Please enter the words  ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" > ");
                Console.ResetColor();

                Charset.CustomCharsetWord();

                Console.WriteLine("\n Press Enter or Escape");
                quit = Console.ReadKey();
            }            
        }


        public static void BirthdateMenu()
        {          
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.WriteLine(" Press the Escape (Esc) key to quit or press Enter for continue:");
            
            ConsoleKeyInfo quit;                       
            quit = Console.ReadKey();
            
            while (quit.Key != ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n[+] ");
                Console.ResetColor();
                Console.WriteLine(" Please enter the Birthdate ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" > ");
                Console.ResetColor();

                Charset.BirthdatePerson();

                Console.WriteLine("\n Press Enter or Escape");
                quit = Console.ReadKey();
            }     
            
        }

        internal static void CustomCharsetSpecialMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Do you want to add special chars ? Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                Charset.CustomCharsetSpecial();
            }           
        }

        internal static void CustomCharsetNumberMenu()
        {
            ConsoleKeyInfo yes = Console.ReadKey();
            try
            {
                if (yes.Key == ConsoleKey.Y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n > ");
                    Console.ResetColor();
                    Console.Write("Start : ");
                    int startYear = int.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n > ");
                    Console.ResetColor();
                    Console.Write("End : ");
                    int endYear = int.Parse(Console.ReadLine());

                    Charset.CustomCharsetNumber(startYear, endYear);

                }
            }
            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }           
        }

        internal static void CustomChartsetL33tSpeekMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Leet mode ? (i.e. leet = 1337) Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                TransformTextFiles obj = new TransformTextFiles();
                obj.CustomChartsetL33tSpeek();
            }
        }


        internal static void CustomCharsetUpperMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" LOWERCASE TO UPPERCASE Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                Charset.CustumCHarsetUpperCase();
            }
        }

        internal static void CustomCharsetLowerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" UPPERCASE TO LOWERCASE Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                Charset.CustumCHarsetLowerCase();
            }
        }

        internal static void DisplayCustomCharset()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ResetColor();
            Console.Write(" Do you want display custom charset ? Y/[N]: ");

            ConsoleKeyInfo yes = Console.ReadKey();

            if (yes.Key == ConsoleKey.Y)
            {
                foreach (var item in Charset.CharsetSelecting)
                {
                    Console.WriteLine(item);
                }
            }
        }

        internal static void RemoveDuplicate()
        {
            // Get distinct elements and convert into a list again.
            List<string> distinct = Charset.CharsetSelecting.Distinct().ToList();
            Charset.CharsetSelecting.Clear();
            Charset.CharsetSelecting = distinct.Distinct().ToList();
        }

    }
}
