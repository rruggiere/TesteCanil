using System;

namespace TesteDTI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Instancia um novo Controller e inicia o Menu de navegação.
                Controller MyController = new Controller();
                MyController.MenuInit();              

                Console.ReadKey();
            }
            catch (Exception e)
            {
                //Informa ao usuário sobre uma eventual falha de execução.
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
