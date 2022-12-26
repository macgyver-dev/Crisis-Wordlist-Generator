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
using System.Collections.Generic;

namespace crisis
{
    

    public class Statistical : Property
    {
        private BigInteger dataSizeOctet;

        private static BigInteger numberOfAllCombination;
        public static BigInteger NumberOfAllCombination
        {
            get { return Statistical.numberOfAllCombination; }
            set { Statistical.numberOfAllCombination = value; }
        }

        private static double defaultSizeFileInOctet;
        public static double DefaultSizeFileInOctet
        {
            get
            {
                return defaultSizeFileInOctet;
            }
            set
            {
                defaultSizeFileInOctet = value;
            }
        }
                
        public Statistical()
        {
            
        }

       
        internal BigInteger CalculOfAllCombinaison(bool _repeat)
        {
           try
            {
                numberOfAllCombination = new BigInteger();

                if (MenuParameter.TypesOfGeneration == 1 | MenuParameter.TypesOfGeneration == 2)
                {
                    numberOfAllCombination = CombinationPattern.CaclulCombination(_repeat).Count; 
                }
                else if (MenuParameter.TypesOfGeneration == 3 | MenuParameter.TypesOfGeneration == 6)
                {
                    numberOfAllCombination = (BigInteger)Math.Pow((double)NumberOfChar, (double)Charset.CharsetSelecting.Count);
                }
                else if (MenuParameter.TypesOfGeneration == 4)
                {
                    numberOfAllCombination = VariationnPattern.CalculVariation(_repeat).Count;
                }
                else if (MenuParameter.TypesOfGeneration == 5)
                {
                    numberOfAllCombination = PermutationPattern.CaclulPermut(_repeat);
                }

            }
            catch (Exception) 
            {
                numberOfAllCombination = 9999999999999999999;
            }

            return numberOfAllCombination;
        }

        /// <summary>
        /// Calculating the number of line to create the file. If the size is too large the function returns a number by default.
        /// </summary>
        /// <returns>BigInteger NumberLine</returns>

        internal BigInteger CalculSizeFile()
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Line == false)
            {
                double nbLine = 0;

                nbLine = (defaultSizeFileInOctet / 1.4) / (MenuParameter.NumberOfChar * 0.9);

                if (MenuParameter.TypesOfGeneration == 1)
                {
                    nbLine = (defaultSizeFileInOctet / 1.4) / (MenuParameter.NumberOfChar + 12);
                    if (numberOfAllCombination - 1 < (BigInteger)nbLine)
                    {
                        MenuParameter.NumberLine = numberOfAllCombination;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n File size too large, the number of line by default.\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        MenuParameter.NumberLine = (BigInteger)nbLine;
                    }
                }
                else if (MenuParameter.TypesOfGeneration == 5)
                {
                    if (PermutationPattern.Permut.Count < nbLine)
                    {
                        MenuParameter.NumberLine = PermutationPattern.Permut.Count;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n File size too large, the number of line by default.\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        MenuParameter.NumberLine = (BigInteger)nbLine;
                    }
                }
                else
                {
                    if (numberOfAllCombination - 1 < (BigInteger)nbLine)
                    {
                        MenuParameter.NumberLine = numberOfAllCombination;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n File size too large, the number of line by default.\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        MenuParameter.NumberLine = (BigInteger)nbLine;
                    }
                }
            }

            return MenuParameter.NumberLine;
        }
        
        /// <summary>
        /// Calcul the size total of data in the terminal
        /// </summary>

        internal void StatiscalInfoSize()
        {
            if (MenuParameter.TypesOfGeneration == 1)
            {
                dataSizeOctet = (BigInteger)(NumberOfChar + 14) * NumberOfAllCombination;
            }            
            else if (MenuParameter.TypesOfGeneration == 2 | MenuParameter.TypesOfGeneration == 3 | MenuParameter.TypesOfGeneration == 4 | MenuParameter.TypesOfGeneration == 5 |MenuParameter.TypesOfGeneration == 6)
            {
                dataSizeOctet = (NumberOfChar + 2) * NumberOfAllCombination;
            }

            BigInteger dataSizeKo = 4096;
            if (dataSizeOctet <= 4096)
            {
                dataSizeKo = 4;
            }
            else
            {
                dataSizeKo = dataSizeOctet / 1024;
            }

            BigInteger dataSizeMo = dataSizeKo / 1024;
            BigInteger dataSizeGo = dataSizeMo / 1024;
            BigInteger dataSizeTo = dataSizeGo / 1024;
            BigInteger dataSizePo = dataSizeTo / 1024;

            Console.WriteLine("\n Crisis will now generate the following amount of data: {0} ", dataSizeOctet);
            Console.WriteLine("\n {0} KB", dataSizeKo);
            Console.WriteLine(" {0} MB", dataSizeMo);
            Console.WriteLine(" {0} GB", dataSizeGo);
            Console.WriteLine(" {0} TB", dataSizeTo);
            Console.WriteLine(" {0} PB", dataSizePo);
            Console.WriteLine("\n Crisis will now generate the following number of lines: {0}\n ", NumberOfAllCombination);

            System.Threading.Thread.Sleep(5000);
        }

    }
}