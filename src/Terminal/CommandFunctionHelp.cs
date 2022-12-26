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
        private bool booleanneTmp; 

        public Command()
        { 
        }

        public Command(bool _bool)
        {
            booleanneTmp = _bool;
        }

        public int HelpPrint(string[] args)
        {
            Property options = new Property();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Help )
            {
                Console.Write(parser.UsageInfo.ToString(80, false));               

            }
            else if (options.WordlistHelp)
            {
                DisplayCharset.SfrPrint();
                DisplayCharset.LiveboxPrint();
                DisplayCharset.MenuHexaPrint();
                DisplayCharset.MenuNumericPrint();
                DisplayCharset.MenuSpecialCharacteresPrint();

                DisplayCharset.LatinCharacteUppercasePrint();
                DisplayCharset.LatinCharacterLowercasePrint();
                DisplayCharset.LatinCharacterUppercaseLowercasePrint();

                DisplayCharset.CyrillicCharacterLowercasePrint();
                DisplayCharset.CyrillicCharacterUppercasePrint();
                DisplayCharset.CyrillicCharacterUppercaseLowercasePrint();

                DisplayCharset.SwddishCharacterUppercasePrint();
                DisplayCharset.SwddishCharacterLowercasePrint();
                DisplayCharset.SwddishCharacterLowercaseUppercasePrint();

                DisplayCharset.SyllableCharacteUppercasePrint();
                DisplayCharset.SyllableCharacterLowercasePrint();
                DisplayCharset.SyllableCharacterUppercaseLowercasePrint();
                
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

}// End namespace
