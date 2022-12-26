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
using System.IO;
using System.Numerics;

namespace crisis
{
    public class FilesNameDirectory
    {
        private static string[] filePath = new string[10];

        public static string[] FilePath
        {
            get { return FilesNameDirectory.filePath; }
            set { FilesNameDirectory.filePath = value; }
        }        
        

        private static string[] fileName = new string[10];
        public static string[] FileName
        {
            get { return FilesNameDirectory.fileName; }
            set { FilesNameDirectory.fileName = value; }
        }
        
        private static string[] extension = new string [3];
        public static string[] Extension
        {
            get { return FilesNameDirectory.extension; }
            set { FilesNameDirectory.extension = value; }
        }


        StreamWriter workFile;
        public StreamWriter WorkFile
        {
            get { return workFile; }
            set { workFile = value; }
        }

        private static BigInteger numberFile;
        public static BigInteger NumberFile
        {
            get { return FilesNameDirectory.numberFile; }
            set { FilesNameDirectory.numberFile = value; }
        }    
          

        public FilesNameDirectory()
        {
            numberFile = 1;
            extension[0] = ".txt";
            extension[1] = ".zip";
        }

        
        //A function that determines whether it is a Windows(false) or Linux (true) system
        public bool OsDetect() 
        {
            bool system = true;

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            switch (pid)
            {
                case PlatformID.Win32NT:
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                    case PlatformID.WinCE:

                    system = false;                   
                    break;

                    case PlatformID.Unix:

                    system = true;
                    break;
                    default:
                    Console.WriteLine("ERROR: This platform identifier is invalid.");
                    break;
            }
            return system;
        }

        public void FilesPathDirectory()
        {
            if (OsDetect() == true)
            {
                filePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/default";
                fileName[0] = @"/default_";

                if (Property.TypeOfProcess == 2 )
                {
                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/crunch";
                    filePath[2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/combination";
                    filePath[3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/random";
                    filePath[4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/variation";
                    filePath[5] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/permutation";
                    filePath[6] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/wifi";
                    filePath[7] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/birthdate";
                    filePath[8] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/leet_speak";

                    fileName [1] = @"/charset_";
                    fileName [2] = @"/wordlist_";
                    fileName [3] = @"/wordlist_";
                    fileName [4] = @"/wordlist_";
                    fileName [5] = @"/wordlist_";
                    fileName[6] =  @"/wordlist_" + Charset.CharsetName + "_";
                    fileName [7] = @"/birthdate_";
                    fileName [8] = @"/dico1337_";
                }
                else if (Property.TypeOfProcess == 3)
                {
                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/leet_speak";
                    filePath[2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/uppercase";
                    filePath[3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/lowercase";
                    filePath[4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/mixChar";

                    fileName[1] = @"/wordlist1337_";
                    for (int i = 2; i < fileName.Length; i++)
                    {
                        fileName[i] = @"/wordlist_";
                    }                    
                }
                else if (Property.TypeOfProcess == 4)
                {
                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/donwloads/";                    
                }

                
            } 
            else
            {
                filePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\default";
                fileName[0] = @"\default_";

                if (Property.TypeOfProcess == 2)
                {
                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\charset";
                    filePath[2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\combination";
                    filePath[3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\random";
                    filePath[4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\variation";
                    filePath[5] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\permutation";
                    filePath[6] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\wifi";
                    filePath[7] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\birthdate";
                    filePath[8] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\leet_speak";

                    fileName[1] = @"\charset_";
                    fileName[2] = @"\wordlist_";
                    fileName[3] = @"\wordlist_";
                    fileName[4] = @"\wordlist_";
                    fileName[5] = @"\wordlist_";
                    fileName[6] = @"\wordlist_" + Charset.CharsetName + "_";
                    fileName[7] = @"\birthdate_";
                    fileName[8] = @"\dico1337_";  
                }
                else if (Property.TypeOfProcess == 3)
                {

                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\leet_speak";
                    filePath[2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\uppercase";
                    filePath[3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\lowercase";
                    filePath[4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\mixChar";
                    
                    fileName[1] = @"\wordlist1337_";
                    
                    for (int i = 2; i < fileName.Length; i++)
                    {
                        fileName[i] = @"\wordlist_";
                    }
                }
                else if (Property.TypeOfProcess == 4)
                {
                    filePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\donwloads\";                    
                }
                              
            }
        }

        public void Setting_UpFile(int _i)
        {

            bool b = true;            

            while (b)
            {
                try
                {
                    if (!Directory.Exists(filePath[_i]))
                    {
                        System.IO.Directory.CreateDirectory(filePath[_i]);
                    }
                    else if (File.Exists(filePath[_i] + fileName[_i] + numberFile + extension[MenuParameter.IExtension]))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists(filePath[_i] + fileName[_i] + numberFile + ".txt") & Property.TypeOfProcess != 4)
                    {
                        workFile = new StreamWriter(filePath[_i] + fileName[_i] + numberFile + ".txt");
                        b = false;                      
                    }
                    else if (Property.TypeOfProcess == 4)
                    {
                        b = false; 
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }

            } //End while
        }  //End Fonction



    }  //End class
} // End namespace;

