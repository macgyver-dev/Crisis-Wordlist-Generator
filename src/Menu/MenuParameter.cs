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
using System.Numerics;
using crisis.CommandLine;

namespace crisis
{
    public class MenuParameter : Property 
    {
        private bool b;

        public MenuParameter()
        {
            NumberLine = 1;
            IExtension = 0;
            b = true;
            Repeat = false;
            SaveFile = false;
            Zip = false;
        }


        internal void TypesOfFileAtGenerate()
        {
            byte i = 1;
            b = true;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Charset for Crunch");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Combinations");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Random ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Variations ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n {0}) ", i++);
            Console.ResetColor();
            Console.WriteLine(" \t Permutations");
            

            while (b)
            {
                try
                {
                    Console.Write("\n Type the number corresponding to the menu : ");
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    TypesOfGeneration = int.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();

                    if (TypesOfGeneration == 1 | TypesOfGeneration == 2 | TypesOfGeneration == 3 | TypesOfGeneration == 4 | TypesOfGeneration == 5 )
                    {
                        b = false;
                        SubMenu.BooleanSubMenu = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n {0} does not exist", TypesOfGeneration);
                        Console.ResetColor();                        
                        b = true;
                    }

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                    b = true;
                }
            }

        } //End Fonction

        internal void SizeOfWorld()
        {
            b = true;
            while (b)
            {
                try
                {
                    byte i;
                    Console.Write("\n What is the size of your charset : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;                 
                    byte.TryParse(Console.ReadLine(), out i);
                    Property.NumberOfChar = i;
                    Console.ResetColor();

                    
                    if (Property.NumberOfChar > Charset.CharsetSelecting.Count)
                    {
                        Console.WriteLine(" The number of character is too large to generate\n a caratère chain");                       
                    }
                    else if (Property.NumberOfChar == Charset.CharsetSelecting.Count)
                    {
                        Console.WriteLine(" The number of characters must be smaller");                        
                    }
                    else if (Property.NumberOfChar <= Charset.CharsetSelecting.Count & Property.NumberOfChar >= 2)
                    {
                        b = false;
                    } 
                   
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Type the size of your charset");
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();

                    b = true;
                }
            }
        } // End Fonction

        internal void Repetition(ref bool _repeat)
        {
            b = true;           

            while (b)
            {
                Console.Write("\n Would you a repeating of character ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("]\n ");
                
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true); 
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {
                        Repeat = true;
                        _repeat = Repeat;
                        b = false;
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        Repeat = false;
                        b = false;
                    }                    
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        } // End Fonction

        internal void ChangeStartblockPattern()
        {
            Utility obj = new Utility();
            b = true;

            while (b)
            {
                Console.Write("\n Do you want to specify a starting chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("]\n ");
                

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);     
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write("\n Write the starting string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.StartblockPattern(s);

                            b = false;
                        }                       
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        Repeat = false;
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        } // End Fonction

        internal void ChangeEndblockPattern()
        {
            Utility obj = new Utility();
            b = true;

            while (b)
            {
                Console.Write("\n Do you want to specify a ending chain ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" n ");
                Console.ResetColor();
                Console.Write("] ");
                Console.Write("\n");
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    Console.ResetColor();

                    if (info.Key == ConsoleKey.Y)
                    {

                        Console.Write("\n Write the end string : ");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        string s = Console.ReadLine();
                        Console.ResetColor();

                        if (s.Length >= 2 | s != null)
                        {
                            obj.EndPattern(s);
                            b = false;
                        }
                    }
                    if (info.Key == ConsoleKey.N)
                    {
                        Repeat = false;
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        } // End Fonction

        internal void SaveCharsetInFilesTxt( ref bool  _saveFile, ref bool _zip)
        {
            b = true;

            while (b)
            {
                try
                {
                    Console.Write("\n Do you want to save the output to a file [");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" y ");
                    Console.ResetColor();
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" n ");
                    Console.ResetColor();
                    Console.Write("]\n ");
                    

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    
                    ConsoleKeyInfo info = Console.ReadKey(true);                   

                    Console.ResetColor();

                    if (info.Key == ConsoleKey.N)
                    {
                        SaveFile = false;
                        b = false;
                    }                   
                     else if (info.Key == ConsoleKey.Y)	
                    {
                        SaveFile = true;
                        _saveFile = SaveFile;
                         b = false;
                     }
                    else
                    {
                        b = true;
                    }

                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                    b = true;
                }
            }


            if (SaveFile)
            {
                Statistical info = new Statistical();
                b = true;
                string sizeFiles = null;

                while (b)
                {
                    try
                    {
                        Console.Write("\n What size should a save file in MB : ");
                        sizeFiles = Console.ReadLine();
                        int sizFilesInMB = 0;

                        if (Int32.TryParse(sizeFiles, out sizFilesInMB))
                        {
                            sizFilesInMB *= 1048576;
                            Statistical.DefaultSizeFileInOctet = sizFilesInMB;
                            info.CalculSizeFile();
                            b = false;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n {0} \n", e.Message);
                        Console.ResetColor();
                    }
                }

                b = true;

                while (b)
                {
                    try
                    {
                        Console.Write("\n You want to compress them into zip file [ ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" y ");
                        Console.ResetColor();
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" n ");
                        Console.ResetColor();
                        Console.Write("] ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        Console.Write("\n");
                        Console.ResetColor();

                        if (keyInfo.Key == ConsoleKey.Y)
                        {
                            IExtension = 1;
                            Zip = true;
                            _zip = Zip;
                            b = false;
                        }
                        else if (keyInfo.Key == ConsoleKey.N)
                        {
                            IExtension = 0;
                            b = false;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n {0} \n", e.Message);
                        Console.ResetColor();
                    }
                }


            }
            
        }
        // End Fonction

        internal void ReversePaterne()
        {
            b = true;

            while (b)
            {
                
                Console.Write("\n Want to reverse the pattern ? [");
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
                Console.Write(" y ");
                Console.ResetColor();
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.DarkGreen; 
                Console.Write(" n ");
                Console.ResetColor();                
                Console.Write("] ");
                Console.Write("\n");

                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    Console.ResetColor(); 

                    if (keyInfo.Key == ConsoleKey.N)
                    {
                        b = false;
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Charset.CharsetSelecting.Reverse();
                        b = false;
                    }
                }

                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n {0} \n", e.Message);
                    Console.ResetColor();
                }
            }
        } // End Fonction       

        public static void CrisisServer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+]");
            Console.ResetColor();
            Console.Write(" Please enter the LHOST : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Property.Lhost = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[+]");
            Console.ResetColor();
            Console.Write(" Please enter the LPORT : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Property.Lport = int.Parse(Console.ReadLine());
            Console.ResetColor();
        }
        
    }// End class
} // End Namespace
