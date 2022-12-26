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
using crisis.Ionic.Zip;
using System.IO;
using System.Collections.Generic;




namespace crisis
{
    public class Utility : Property
    {
        public Utility()
        {

        }
        
        internal void StartblockPattern(string _s)
        {
            try
            {
                for (int i = 0; i < _s.Length; i++)
                {
                    Charset.CharsetSelecting.Insert(i, _s[i].ToString());
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }
                       
        }
        
        internal void EndPattern(string _e)
        {
            try
            {
                for (int i = 0; i < _e.Length; i++)
                {
                    Charset.CharsetSelecting.Insert((NumberOfChar - _e.Length) + i, _e[i].ToString());
                } 

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n {0} \n", e.Message);
                Console.ResetColor();
            }
             
        }

        internal string Hour()
        {
            DateTime obj = DateTime.Now;
            string input = obj.ToString().Substring(10);

            return input;
        }

        internal void Zipper(bool _Zip)
        {

            if (_Zip)
            {
                string[] compress = new string[] { FilesNameDirectory.FilePath[MenuParameter.TypesOfGeneration].ToString() + FilesNameDirectory.FileName[MenuParameter.TypesOfGeneration] + FilesNameDirectory.NumberFile + ".txt" };

                using (ZipFile zipFile = new ZipFile())
                {
                    zipFile.AddFiles(compress, FilesNameDirectory.FileName[MenuParameter.TypesOfGeneration] + FilesNameDirectory.NumberFile);
                    zipFile.Save(FilesNameDirectory.FilePath[MenuParameter.TypesOfGeneration].ToString() + FilesNameDirectory.FileName[MenuParameter.TypesOfGeneration] + FilesNameDirectory.NumberFile + ".zip");
                }

                System.IO.File.Delete(FilesNameDirectory.FilePath[MenuParameter.TypesOfGeneration].ToString() + FilesNameDirectory.FileName[MenuParameter.TypesOfGeneration] + FilesNameDirectory.NumberFile + ".txt");
            }
        }

        internal void GenerateOut(int _i, int extention)
        {
            string[] locate = new string[] { " Generating output at" + Hour() + " : " + FilesNameDirectory.FilePath[_i].ToString() + FilesNameDirectory.FileName[_i] + FilesNameDirectory.NumberFile + FilesNameDirectory.Extension[MenuParameter.IExtension] };
            Console.WriteLine(locate[0].ToString());
        }

       

    } //End class
}// End namespace

