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

namespace crisis
{
    public static partial  class DisplayCharset
    {
        
        public static void MenuLeetSpeakPrint()
        {
            Console.WriteLine(" leet speak\t\t\t 1337 5p34k\n");            
        }

        public static void MenuLowercaseToUppercasePrint()
        {
            Console.WriteLine(" hello world\t\t\t HELLO WORLD\n");
        }

        public static void MenuUppercaseToLowercasePrint()
        {
            Console.WriteLine(" HELLO WORLD\t\t\t hello world\n");
        }

        public static void MenuCharLowercaseToUppercasePrint()
        {
            Console.WriteLine(" Hello World\t\t\t hELLO wORLD\n");
        }

        public static void MenuCharUppercaseToLowercasePrint()
        {
            Console.WriteLine(" Hello World\t\t\t hello world\n");
        }

        public static void MenuAutoUppercaseLowercasePrint()
        {
            Console.WriteLine(" HellO WorlD\t\t\t hELLo wORLd \n");
        }

        public static void SfrPrint()
        {
            Console.WriteLine("\n #### SFR BOX ADSL FR");
            Console.WriteLine("\n Rétroingénierie du 31/12/2015 qui permet de générer des clés WPA authentiques\n à partir du véritable algorithme implanter dans une box SFR\n");
            Console.WriteLine(" Version du Firmware\t\t\t: NB6V-MAIN-R3.4.5");
            Console.WriteLine(" Octet de l'adresse MAC\t\t\t: 24:95:04:??:??:??\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" sfr");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\t-_0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\n\t\t\t\t\tabcdefghijklmnopqrstuvwxyz\n");
        }

        public static void LiveboxPrint()
        {
            Console.WriteLine("\n #### Livebox BOX ADSL FR");
            Console.WriteLine("\n Algorithme à partir de crack-wifi.com/forum/topic-5559-retravailler-des-cle-livebox.html\n qui permet de générer des clés WPA pour une Livebox Sagem\n");
            Console.WriteLine(" Construteur\t\t\t\t: SAGEM COMMUNICATION");
            Console.WriteLine(" Octet de l'adresse MAC\t\t\t: 00:19:70:??:??:??\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" livebox-sagem");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t1234679ACDEF\n");
        }

        public static void MenuHexaPrint()
        {
            Console.WriteLine("\n #### Hexa \n");
            //hexa-lower
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n hex-lower");
            Console.ResetColor();
            Console.WriteLine("\n  \t\t\t\t\t0123456789abcdef");
            //hexa-upper
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" hex-upper");
            Console.ResetColor();
            Console.WriteLine(" \t\t\t\t\t0123456789ABCDEF\n");
        }
        
        public static void MenuNumericPrint()
        {
            
            Console.WriteLine("\n #### Numeric\n");
            
            //numeric
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" numeric");
            Console.ResetColor();
            Console.WriteLine(" \t\t\t\t0123456789");
            
            //numeric-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" numeric-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t0123456789 [space] \n");
        }
        
        
       

        public static void MenuSpecialCharacteresPrint()
        {
            Console.WriteLine("\n #### Symbols \n");
            //symbols14
            Console.ForegroundColor = ConsoleColor.DarkGreen;  
            Console.Write(" symbols14");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t!@#$%^&*()-_+=");
            //symbols14-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" symbols14-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t!@#$%^&*()-_+= [space]\n");
            //symbols-all
            Console.ForegroundColor = ConsoleColor.DarkGreen;    
            Console.Write(" symbols-all");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/");
            //symbols-all-space
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" symbols-all-space");
            Console.ResetColor();
            Console.WriteLine("\t\t\t!@#$%^&*()-_+=~`[]{}|\\:;\"'<>,.?/ [space]\n");
        }  
         	

    }
}

