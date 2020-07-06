using System;
using System.Globalization;

namespace TesteDTI
{
    public static class ConsoleManager
    {
        private static bool ConvertResult { get; set; }

        public static void EndOrReturn(string InputOption)
        {
            Exit(InputOption);
        }
        public static int OptionVerify(string InputOption)
        {
            Exit(InputOption);

            int Value;
           
            do
            {                
                ConvertResult = int.TryParse(InputOption, out Value);

                if (ConvertResult == false || Value < 0 || Value > 2)
                {
                    ConvertResult = false;
                    Menu.InvalidEntry();                   
                    InputOption = Console.ReadLine();
                }
                
            } while (ConvertResult == false);

            return Value;
        }
        public static DateTime DateVerify(string EntryDate)
        {
            Exit(EntryDate);

            DateTime Value;
            do
            {        
                 ConvertResult = DateTime.TryParseExact(EntryDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out Value);

                if (ConvertResult == false)
                {
                    Menu.InvalidEntry();                                   
                    EntryDate = Console.ReadLine();
                }           

            } while(ConvertResult == false);

            return Value;
        }

        public static int NumDogsVerify(string NumDogsEntry)
        {
            Exit(NumDogsEntry);

            int Value;

            do
            {                          
                ConvertResult = int.TryParse(NumDogsEntry, out Value);

                if (ConvertResult == false || Value < 0)
                {
                    ConvertResult = false;
                    Menu.InvalidEntry();                  
                    NumDogsEntry = Console.ReadLine();
                }               

            } while (ConvertResult == false);

            return Value;
        }

        private static void Exit(string Entry)
        {
            Entry = Entry.ToUpper().Trim();
            if (Entry.Equals("EXIT"))
            {
                Environment.Exit(0);
            }       
        }

        public static void ClearPrevLine()
        {
            Console.SetCursorPosition(9, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.SetCursorPosition(10, Console.CursorTop - 1);

        }
        public static void ClearLine()
        {

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);

        }
    }
}
