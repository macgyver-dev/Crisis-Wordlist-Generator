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

namespace crisis
{
    public class TransformTextFiles : Property 
    {

        public TransformTextFiles()
        {

        }

        public string ConverterInLeetSpeak(string _word)
        {
            string wordLeet = null;
            for (int i = 0; i < _word.Length; i++)
            {
                wordLeet += FoundLetterLeet(_word[i]);
            }

            return wordLeet;
        }

        public char FoundLetterLeet(char _letter)
        {
            char letterLeet = _letter;

            switch (Char.ToLower(letterLeet))
            {
                case 'a':
                    letterLeet = '4';
                    break;
                case 'b':
                    letterLeet = '8';
                    break;
                case 'e':
                    letterLeet = '3';
                    break;
                case 'l':
                    letterLeet = '1';
                    break;
                case 'o':
                    letterLeet = '0';
                    break;
                case 's':
                    letterLeet = '5';
                    break;
                case 't':
                    letterLeet = '7';             
                    break;
                case 'g':
                    letterLeet = '6';
                    break;
                case 'z':
                    letterLeet = '2';
                    break;
            }

            return letterLeet;
        }

        

        public void L33tSpeekPrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();

            //if ( SaveFile == true)
            //{
            make.Setting_UpFile(Property.TypesOfTransforming);

            foreach (var item in Charset.CharsetSelecting)
            {
                make.WorkFile.WriteLine(ConverterInLeetSpeak(item.ToString()));
            }

            make.WorkFile.Close();

            //}
            //else
            //{
            //    Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            //} 

        } // End Function 

        public void CustomChartsetL33tSpeek()
        {
            try
            {

                for (int i = 0; i < Charset.CharsetSelecting.Count; i++)
                {                    
                    Charset.CharsetSelecting.Add(ConverterInLeetSpeak(Charset.CharsetSelecting[i].ToString()));
                    SubMenu.RemoveDuplicate();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" {0} \n", e.Message);
                Console.ResetColor();
            }            

        } // End Function 

        public string ConverterInUppercaseLowercase(string _word)
        {
            string wordLeet = null;
            for (int i = 0; i < _word.Length; i++)
            {
                wordLeet += FoundLetterUppercaseLowercase(_word[i]);
            }

            return wordLeet;
        }

        public char FoundLetterUppercaseLowercase(char _letter)
        {
            char letter = _letter;

            for (int i = 0; i < Charset.LalphaList.Count; i++)
            {
                if (Charset.LalphaList[i] == _letter.ToString())
                {
                    letter = Convert.ToChar(Charset.UalphaList[i]);
                }
                else if (Charset.UalphaList[i] == _letter.ToString())
                {
                    letter = Convert.ToChar(Charset.LalphaList[i]);
                }
            }

            return letter;
        }

       

        public void AutoUppercaseLowercasekPrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();
            
            //if ( SaveFile == true)
            //{
                make.Setting_UpFile(Property.TypesOfTransforming);

                foreach (var item in Charset.CharsetSelecting)
                {
                    make.WorkFile.WriteLine(ConverterInUppercaseLowercase(item.ToString()));
                }

                make.WorkFile.Close();            

            //}
            //else
            //{
            //    Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            //}

        } // End Function 

        public void LowercaseToUppercasePrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();            

            //if ( SaveFile == true)
            //{
            make.Setting_UpFile(Property.TypesOfTransforming);

            foreach (var item in Charset.CharsetSelecting)
            {
                make.WorkFile.WriteLine(item.ToString().ToUpper());
            }

            make.WorkFile.Close();

            //}
            //else
            //{
            //    Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            //}           

            
        } // End Function 

        public void UppercaseToLowercasePrintF()
        {
            FilesNameDirectory make = new FilesNameDirectory();           

            //if ( SaveFile == true)
            //{
            make.Setting_UpFile(Property.TypesOfTransforming);

            foreach (var item in Charset.CharsetSelecting)
            {
                make.WorkFile.WriteLine(item.ToString().ToLower());
            }

            make.WorkFile.Close();

            //}
            //else
            //{
            //    Charset.CharsetSelecting.ForEach(x => Console.WriteLine(ConverterInLeetSpeak(x.ToString())));
            //}
     
        } // End Function


    }   
}
