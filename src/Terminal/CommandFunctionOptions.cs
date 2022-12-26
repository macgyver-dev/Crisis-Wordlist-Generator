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
using crisis.CommandLine;

namespace crisis
{
    public partial class Command
    {
        public int FunctionInverts(string[] args)
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Invert)
            {
                Charset.CharsetSelecting.Reverse();
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionLenght(string[] args)
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Lenght)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-l" | args[i].ToLower() == "--lenght")
                    {
                        byte l;

                        bool b = byte.TryParse(args[i + 1], out l);

                        if (b == false)
                        {
                            Console.WriteLine("\nThe value entered with the -l option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Property.NumberOfChar = l;
                        }
                    } // End For               
                }
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }


        public int FunctionByte(string[] args)
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();            

            if (options.Byte)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-b" | args[i].ToLower() == "--byte")
                    {
                        int iByte = 0;

                        bool booleanByte = int.TryParse(args[i + 1], out iByte);

                        if (booleanByte == false)
                        {
                            Console.WriteLine("\nThe value entered with the -b option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (args[i + 2].ToLower() == "kib")
                            {
                                iByte *= 1024;
                            }
                            else if (args[i + 2].ToLower() == "mib")
                            {
                                iByte *= 1048576;

                            }
                            else if (args[i + 2].ToLower() == "gib")
                            {
                                iByte *= 1073741824;
                            }

                            Statistical.DefaultSizeFileInOctet = iByte ;
                            Statistical obj = new Statistical();
                            obj.CalculSizeFile();
                        }
                    }

                }
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }
            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionSaveFiles(string[] args)
        {            
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.SaveFile)
            {
                options.SaveFile = true;                
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionZip(string[] args)
        {            
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Zip)
            {
                MenuParameter.IExtension = 1;                
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionLine(string[] args)
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Line)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToLower() == "-c" | args[i].ToLower() == "--line")
                    {
                        int c;

                        bool booleanLine = int.TryParse(args[i + 1], out c);

                        if (booleanLine == false)
                        {
                            Console.WriteLine("\nThe value entered with the -c option is incorrect\n");
                            Environment.Exit(0);
                        }
                        else
                        {
                            MenuParameter.NumberLine = c;
                        }
                    }
                }
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }


        public int FunctionStartblock(string[] args)
        {
            Utility obj2 = new Utility();
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Startblock)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToString().ToLower() == "-s" | args[i].ToString().ToLower() == "--startblock")
                    {
                        string s = args[i + 1].ToString();

                        if (s.Length > Charset.CharsetSelecting.Count)
                        {
                            Console.WriteLine("\nThe string entered with the -s option is too big\n");
                            Console.WriteLine("example : crisis -2 -l 10 -f lalpha -s qwerty");
                            Environment.Exit(0);
                        }
                        else
                        {
                            obj2.StartblockPattern(s);
                        }
                    }
                }
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }

        public int FunctionEndblock(string[] args)
        {
            Utility obj2 = new Utility();
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.EndBlock)
            {
                string e = null;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].ToString().ToLower() == "-e" | args[i].ToString().ToLower() == "--end")
                    {
                        e = args[i + 1];
                    }
                }

                if (e.Length > Charset.CharsetSelecting.Count)
                {
                    Console.WriteLine("\nThe string entered with the -s option is too big\n");
                    Console.WriteLine("example : crisis -2 -l 10 -f lalpha -e qwerty");
                    Environment.Exit(0);
                }
                else
                {
                    obj2.EndPattern(e);
                }
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.ToString(78, true));
                return -1;
            }

            // No errors present and all arguments correct
            // Do work according to arguments
            return 0;
        }
    } // End class
}// End namaspace
