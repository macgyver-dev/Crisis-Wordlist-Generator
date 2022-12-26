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
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO.Compression;
using System.Collections.Generic;
using crisis.Ionic.Zip;

namespace crisis
{
    public class Randomizer : Property
    {
        private Random random = null;
        
        public Randomizer()
        {
            random = new Random();
        }

        /// <summary>
        /// Return At string Ramdom
        /// </summary>
        /// <returns>string</returns>
         
        public string Aleatory()
        {
            string randonString = null;

            try
            {
                for (int i = 0; i < NumberOfChar; i++)
                {
                    randonString += Charset.CharsetSelecting[random.Next(Charset.CharsetSelecting.Count)].ToString();
                }
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("{0}", e.Message);
            }

            return randonString;
        }


        public void RamdonPrintF(bool _saveFile, bool _zip)
        {
            SaveFile = _saveFile;


            FilesNameDirectory make = new FilesNameDirectory();
            Utility tool = new Utility();
            BigInteger cpt = 0;

            
            if (SaveFile)
            {
                BigInteger iMakeFile = 0;

                while ( Statistical.NumberOfAllCombination >= cpt )
                {
                    if (iMakeFile == 0)
                    {
                        make.Setting_UpFile(Property.TypesOfGeneration);
                    }

                    make.WorkFile.WriteLine(this.Aleatory());
                    ++iMakeFile;
                    ++cpt;
                    
                    if (iMakeFile >= MenuParameter.NumberLine - 1 || cpt >= Statistical.NumberOfAllCombination)
                    {                        
                        make.WorkFile.Flush();
                        make.WorkFile.Close();
                        tool.Zipper(_zip);
                        tool.GenerateOut(Property.TypesOfGeneration, Property.IExtension);
                        iMakeFile = 0;
                    }           
                }
            }
            else
            {
                while (cpt <= Statistical.NumberOfAllCombination)
                {
                    Console.WriteLine(this.Aleatory());
                    cpt++;
                }
            }
        } // End Function
        

    }
}
