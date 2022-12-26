using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using crisis.CommandLine;

namespace crisis 
{
    class Run : Property
    {
                      
        
        public Run()
        {
            MainMenu.BooleanCategoryMenu = true;

            MainMenu runMenu = new MainMenu();
           
            runMenu.Menu();
            
            FilesNameDirectory os = new FilesNameDirectory();
            os.FilesPathDirectory();

            if (Property.TypeOfProcess == 1)
            {

            }
            else if (Property.TypeOfProcess == 2)
            {
                LocalBruteForcerWordlist(SaveFile, Repeat, Zip);
            }
            else if (Property.TypeOfProcess == 3)
            {
                TransformWordlist();
            }            
            else if (Property.TypeOfProcess == 4)
            {
                DownloadFunctions();
            }           
        }
        
        public Run(string[] args)
        {
            try
            {
                Property.TypeOfProcess = 2;
                Command run = new Command();
                Statistical info = new Statistical();
                FilesNameDirectory os = new FilesNameDirectory();
                os.FilesPathDirectory();
                Property options = new Property();
                CommandLineParser parser = new CommandLineParser(options);
                parser.Parse();
    
                //Help must be first
                if (options.Help || options.WordlistHelp)
                {
                    run.HelpPrint(args);
                }
    
                run.FunctionPattern(args);
    
                if (options.Crunch)
                {
                    MenuParameter.TypesOfGeneration = 1;
                    CombinationPattern obj = new CombinationPattern();
    
                    run.FunctionLenght(args);
    
                    if (options.Invert)
                    {
                        run.FunctionInverts(args);
                    }
    
                    if (options.Startblock)
                    {
                        run.FunctionStartblock(args);
                    }
    
                    if (options.EndBlock)
                    {
                        run.FunctionEndblock(args);
                    } 
                    
                    run.FunctionByte(args);
    
                    info.CalculOfAllCombinaison(options.Repeat);
    
                    run.FunctionLine(args);
                    if (options.Line == false)
                    {
                        run.FunctionByte(args);
                    }
    
                    run.FunctionSaveFiles(args);
    
                    if (options.SaveFile)
                    {
                        run.FunctionZip(args);
                    }
    
                    if (options.Disables == false)
                    {
                        MainMenu runMenu = new MainMenu();
                        
                        info.StatiscalInfoSize();
                    }
    
                    obj.CombinationPrintF(options.SaveFile, options.Zip, options.Repeat);
                }
                else if (options.Combination)
                {
                    MenuParameter.TypesOfGeneration = 2;
                    CombinationPattern obj = new CombinationPattern();
    
                    run.FunctionLenght(args);
                    
                    if (options.Invert)
                    {
                        run.FunctionInverts(args);
                    }
    
                    if (options.Startblock)
                    {
                        run.FunctionStartblock(args);
                    }
    
                    if (options.EndBlock)
                    {
                        run.FunctionEndblock(args);
                    }
                    
    
                    info.CalculOfAllCombinaison(options.Repeat);
    
                    if (options.Line)
                    {
                        run.FunctionLine(args);
                    }
    
                    if (options.Line == false)
                    {
                        run.FunctionByte(args);
                    }
    
                    
    
                    if (options.SaveFile)
                    {
                        run.FunctionSaveFiles(args);
                        run.FunctionZip(args);
                    }
    
                    if (options.Disables == false)
                    {
                        MainMenu runMenu = new MainMenu();
                        
                        info.StatiscalInfoSize();
                    }
    
    
                    obj.CombinationPrintF(options.SaveFile,options.Zip,options.Repeat);
                }
                else if (options.Random || options.Wifi)
                {
                    MenuParameter.TypesOfGeneration = 6;
                    Randomizer obj = new Randomizer();
    
                    if (options.Random)
                    {
                        MenuParameter.TypesOfGeneration = 3;
                        run.FunctionLenght(args);
                    }
    
                    info.CalculOfAllCombinaison(options.Repeat);
                    run.FunctionLine(args);
                    if (options.Line == false)
                    {
                        run.FunctionByte(args);
                    }
    
                    if (options.SaveFile)
                    {
                      run.FunctionSaveFiles(args);  
                    }
                    
    
                    if (options.SaveFile)
                    {
                        run.FunctionZip(args);
                    }
    
                    if (options.Disables == false)
                    {
                        MainMenu runMenu = new MainMenu();
                        
                        info.StatiscalInfoSize();
                    }
    
                    obj.RamdonPrintF(options.SaveFile,options.Zip);
                }
                else if (options.Variation)
                {
                    MenuParameter.TypesOfGeneration = 4;
                    VariationnPattern obj = new VariationnPattern();
    
                    run.FunctionLenght(args);
    
                    if (options.Invert)
                    {
                        run.FunctionInverts(args);
                    }
    
                    if (options.Startblock)
                    {
                        run.FunctionStartblock(args);
                    }
    
                    if (options.EndBlock)
                    {
                        run.FunctionEndblock(args);
                    }                
    
                    info.CalculOfAllCombinaison(options.Repeat);
                    run.FunctionLine(args);
                    if (options.Line == false)
                    {
                        run.FunctionByte(args);
                    }                        
    
                    if (options.SaveFile)
                    {
                        run.FunctionSaveFiles(args);
                        run.FunctionZip(args);
                    }
    
                    if (options.Disables == false)
                    {
                        MainMenu runMenu = new MainMenu();
                        
                        info.StatiscalInfoSize();
                    }
    
                    obj.VariationPrintF(options.SaveFile,options.Zip, options.Repeat);
                }
                else if (options.Permutation)
                {
                    MenuParameter.TypesOfGeneration = 5;
                    PermutationPattern obj = new PermutationPattern();
    
                    run.FunctionLenght(args);
                    
                    if (options.Invert)
                    {
                        run.FunctionInverts(args);
                    }
    
                    if (options.Startblock)
                    {
                        run.FunctionStartblock(args);
                    }
    
                    if (options.EndBlock)
                    {
                        run.FunctionEndblock(args);
                    }
    
                    info.CalculOfAllCombinaison(options.Repeat);
                    run.FunctionLine(args);
                    if (options.Line == false)
                    {
                        run.FunctionByte(args);
                    }
    
                    run.FunctionSaveFiles(args);
    
                    if (options.SaveFile)
                    {
                        run.FunctionZip(args);
                    }
    
                    if (options.Disables == false)
                    {
                        MainMenu runMenu = new MainMenu();
                        
                        info.StatiscalInfoSize();
                    }
    
                    obj.PermutationPrintF(options.SaveFile,options.Zip,options.Repeat);
                }           
                else if (parser.HasErrors)
                {
                    Console.WriteLine(parser.UsageInfo.ToString(78, true));
                }    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }                   
        }

        internal static void LocalBruteForcerWordlist(bool _saveFile, bool _repeat, bool _zip)
        {
            Statistical info = new Statistical();
            MenuParameter config = new MenuParameter();

            if (Property.TypesOfGeneration == 1)
            {
                CombinationPattern obj = new CombinationPattern();

                config.SizeOfWorld();
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();

                info.CalculOfAllCombinaison(_repeat);
                config.SaveCharsetInFilesTxt(ref _saveFile, ref _zip);

                info.StatiscalInfoSize();

                obj.CombinationPrintF(_saveFile, _zip, _repeat);
                MenuParameter.TypesOfGeneration = 0;
            }
            if (Property.TypesOfGeneration == 2)
            {
                CombinationPattern obj = new CombinationPattern();

                config.SizeOfWorld();
                config.Repetition(ref _repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();


                info.CalculOfAllCombinaison(_repeat);
                config.SaveCharsetInFilesTxt(ref _saveFile, ref _zip);

                info.StatiscalInfoSize();

                obj.CombinationPrintF(_saveFile, _zip, _repeat);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 3 | Property.TypesOfGeneration == 6)
            {
                Randomizer obj = new Randomizer();

                if (Property.TypesOfGeneration == 3)
                {
                    config.SizeOfWorld();
                }

                info.CalculOfAllCombinaison(_repeat);
                config.SaveCharsetInFilesTxt(ref _saveFile, ref _zip);

                info.StatiscalInfoSize();

                obj.RamdonPrintF(_saveFile, _zip);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 4)
            {
                VariationnPattern obj = new VariationnPattern();

                config.SizeOfWorld();
                config.Repetition(ref _repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();

                info.CalculOfAllCombinaison(_repeat);
                config.SaveCharsetInFilesTxt(ref _saveFile, ref _zip);

                info.StatiscalInfoSize();

                obj.VariationPrintF(_saveFile, _zip, _repeat);

                MenuParameter.TypesOfGeneration = 0;
            }
            else if (Property.TypesOfGeneration == 5)
            {
                PermutationPattern obj = new PermutationPattern();

                config.SizeOfWorld();
                config.Repetition(ref _repeat);
                config.ChangeStartblockPattern();
                config.ChangeEndblockPattern();
                config.ReversePaterne();


                info.CalculOfAllCombinaison(_repeat);
                config.SaveCharsetInFilesTxt(ref _saveFile, ref _zip);
                info.StatiscalInfoSize();

                obj.PermutationPrintF(_saveFile, _zip, _repeat);

                MenuParameter.TypesOfGeneration = 0;
            }            
            else if (Property.TypesOfGeneration == 9)
            {
                crisis.MenuParameter.CrisisServer();
                new NetworkServer();
            }
        }

        internal static void TransformWordlist()
        {
            SubMenu objSubMenu = new SubMenu();
            objSubMenu.MenuReadFileTxt();

            Utility objHour = new Utility();

            Console.Write("\n{0} : ", objHour.Hour());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This work, please wait !\n");
            Console.ResetColor();

            TransformTextFiles objTransforming = new TransformTextFiles();

            if (Property.TypesOfTransforming == 1)
            {                
                objTransforming.L33tSpeekPrintF();               
            }
            if (Property.TypesOfTransforming == 2)
            {
                objTransforming.LowercaseToUppercasePrintF();                
            }
            else if (Property.TypesOfTransforming == 3)
            {
                objTransforming.UppercaseToLowercasePrintF();                
            }
            else if (Property.TypesOfTransforming == 4)
            {
                objTransforming.AutoUppercaseLowercasekPrintF();                
            }

            Utility objUtility2 = new Utility();
            objUtility2.GenerateOut(Property.TypesOfTransforming,Property.IExtension);           
            Property.TypesOfTransforming = 0;
        }

        private void DownloadFunctions()
        {
            Download obj = new Download();
            List<string> files = obj.GetFileList();
            files.RemoveAt(0);
            files.RemoveAt(0);

            FilesNameDirectory dir = new FilesNameDirectory();
            dir.Setting_UpFile(1);
            Utility time = new Utility();

            foreach (string file in files)
            {
                obj.StartDownload(file);
                string[] locate = new string[] { " Download output at" + time.Hour() + " : " + FilesNameDirectory.FilePath[1].ToString() + file };
                Console.WriteLine(locate[0].ToString());
            }

            Console.WriteLine("\n Download finished\n");
        }

        internal static void UserPassewordProfilerWordlist()
        {

        }

    }
}
