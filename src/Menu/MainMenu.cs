﻿//  Author:
//       Teeknofil <teeknofil@gmail.com>
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
  


namespace crisis
{
    public class MainMenu
    {

        private static bool booleanCategoryMenu;
        public static bool BooleanCategoryMenu
        {
            get { return MainMenu.booleanCategoryMenu; }
            set { MainMenu.booleanCategoryMenu = value; }
        }
        

        public MainMenu()
        {
        }
        

        internal  void Start()
        {           
            Console.WriteLine("\n Hacking US   : hackforums.net ");
            Console.WriteLine(" Trouble US   : forums.kali.org"); 
            Console.WriteLine(" Hacking FR   : hackademics.fr");
            Console.WriteLine(" Trouble FR   : kali-linux.fr/forum");
            Console.WriteLine(" Hacking Wifi : crack-wifi.com/forum\n");        
        }

        public void Menu()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Crisis Wordlist Generator  by Teeknofil, version : 1.1.2 \n");
            Console.ResetColor();
            
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n N°");
            Console.ResetColor();
            
            Console.WriteLine(" \tDESCRIPTION \n");
            int i = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();

            Console.WriteLine("\t 1337");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
           
            Console.WriteLine(" \t LATIN\t");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
           
            Console.WriteLine(" \t CUSTOM");

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
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" {0}) ", i++);
            Console.ResetColor();
            
            Console.WriteLine("\t EXIT ", i++);

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

                    if (dislayMainSubMain == i++)
                    {
                        SubMenu objSubMenu = new SubMenu();
                        objSubMenu.MenuLeetSpeak();                        
                    }
                    //LATIN    CHARACTER
                    if (dislayMainSubMain == i++)
                        LatinMenu();
                    //CUSTOM    CHARACTER
                    if (dislayMainSubMain == i++)
                    {
                        SubMenu objSubMenu = new SubMenu();
                        objSubMenu.MenuCustom();
                        MenuParameter config = new MenuParameter();
                        config.TypesOfFileAtGenerate();
                    }
                    //SPECIAL
                    if (dislayMainSubMain == i++)
                        SpecialMenu();
                    // SWEDISH    CHARACTER    
                    if (dislayMainSubMain == i++)
                        SwedishMenu();
                    // CYRILLIC    CHARACTER    
                    if (dislayMainSubMain == i++)
                        CyrillicMenu();
                    // SYLLABLE  CHARACTER
                    if (dislayMainSubMain == i++)
                        SyllableMenu();
                    if (dislayMainSubMain == i++)
                        WifiMenu();   
                    // EXIT
                    if (dislayMainSubMain == i++)                    
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

        

        internal static void LatinMenu()
        {
            SubMenu objSubMenu = new SubMenu();            

            booleanCategoryMenu = false;
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

        internal static void SpecialMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            booleanCategoryMenu = false;
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

            booleanCategoryMenu = false;
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

        private void CyrillicMenu()
        {
            SubMenu objSubMenu = new SubMenu();

            booleanCategoryMenu = false;
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
                        new MainMenu();
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
            SubMenu objSubMenu = new  SubMenu();           

            booleanCategoryMenu = false;
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
                        new MainMenu();
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
            
            booleanCategoryMenu = false;          

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
                        new MainMenu();
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



    } // End class
}// End class namespace
