using System;
using System.Globalization;

namespace TesteDTI
{
    public static class ConsoleManager
    {
        #region [Properties]
        private static bool ConvertResult { get; set; }
        #endregion

        /// <summary>
        /// Encerra o console caso o usuário digite "Exit."
        /// </summary>
        /// <param name="EntryConsole">Entrada do console.</param>
        #region [ Exit ]
        public static void Exit(string EntryConsole)
        {
            EntryConsole = EntryConsole.ToUpper().Trim();
            if (EntryConsole.Equals("EXIT")) Environment.Exit(0);
        }
        #endregion

        /// <summary>
        /// Verifica se a opção digitada pelo usuário é válida.
        /// </summary>
        /// <param name="EntryConsole">Entrada do console.</param>
        /// <returns></returns>
        #region [ OptionVerify ]
        public static int OptionVerify(string EntryConsole)
        {
            Exit(EntryConsole);
            
            int Value;
           
            do
            {                
                ConvertResult = int.TryParse(EntryConsole, out Value);

                if (ConvertResult == false || Value < 0 || Value > 2)
                {
                    ConvertResult = false;
                    View.InvalidEntry();                   
                    EntryConsole = Console.ReadLine();
                }
                
            } while (ConvertResult == false);

            return Value;
        }
        #endregion

        /// <summary>
        /// Verifica se a data digitada pelo usuário é válida.
        /// </summary>
        /// <param name="EntryConsole">Entrada do console.</param>
        /// <returns></returns>
        #region [ DateVerify ]
        public static DateTime DateVerify(string EntryConsole)
        {
            Exit(EntryConsole);

            EntryConsole = EntryConsole.Trim();

            DateTime Value;
             
            do
            {        
                 ConvertResult = DateTime.TryParseExact(EntryConsole, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out Value);

                if (ConvertResult == false || DateTime.Compare(Value, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))) < 0)
                {
                    ConvertResult = false;
                    View.InvalidEntry();                                   
                    EntryConsole = Console.ReadLine();
                }           

            } while(ConvertResult == false);

            return Value;
        }
        #endregion
        /// <summary>
        /// Verifica se o número de cachorros para tommar banho é maior ou igual 0.
        /// </summary>
        /// <param name="EntryConsole">Entrada do console.</param>
        /// <returns></returns>
        #region[ NumDogsVerify ]
        public static int NumDogsVerify(string EntryConsole)
        {
            Exit(EntryConsole);

            int Value;

            do
            {                          
                ConvertResult = int.TryParse(EntryConsole, out Value);

                if (ConvertResult == false || Value < 0)
                {
                    ConvertResult = false;
                    View.InvalidEntry();                  
                    EntryConsole = Console.ReadLine();
                }               

            } while (ConvertResult == false);

            return Value;
        }
        #endregion
    }
}
