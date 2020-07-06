using System;

namespace TesteDTI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Instancia um novo Controller e inicia o View de navegação.
                Controller MyController = new Controller();
                MyController.ViewInit();              

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
