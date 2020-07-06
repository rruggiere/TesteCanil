using System;
using System.Collections.Generic;

namespace TesteDTI
{
    /// <summary>
    /// Contém todas as views que podem ser vistas pelo usuário. 
    /// </summary>
    public static class Menu
    {       
    
        public static void Header()
        {           
            Console.Title = "DTI";           
            Console.WriteLine("\n\n\t\t\t\t\t\tTeste - DTI");
        }

        public static void Options()
        {
            Console.SetCursorPosition(0, 1);          
            Console.WriteLine("\n\n\n\t\t\tDigite \"exit\" a qualquer momento para sair ou");
            Console.WriteLine("\t\tdigite uma opção:\n");
            Console.WriteLine("\t\tDígito |         Opção");
            Console.WriteLine("\t\t1      |  Calcular melhor PetShop.");
            Console.WriteLine("\t\t2      |  PetShop's cadastradas.");
            Console.Write("\t- ");
            
        }
        public static void InvalidEntry()
        {  
            Console.Write("\tO valor digitado não é válido. Tente novamente.");
            ConsoleManager.ClearPrevLine();
        }
        public static void AskExecuteAgain()
        {
            Console.WriteLine("\n\tPressione qualquer tecla para voltar ao menu principal ou digite \"exit\" para encerrar.");
            Console.Write("\t- ");
        }

        public static void Option_1_Date()
        {           
            Console.WriteLine("\n\tData: (dd/MM/aaaa)");
            Console.Write("\t- ");
        }
        public static void Option_1_NumSmallDogs()
        {
            ConsoleManager.ClearLine();
            Console.WriteLine("\tQuantidade de cães pequenos: (Número inteiro não-negativo.)");
            Console.Write("\t- ");
        }
        public static void Option_1_NumBigDogs()
        {
            ConsoleManager.ClearLine();
            Console.WriteLine("\tQuantidade de cães grandes: (Número inteiro não-negativo.)");
            Console.Write("\t- ");
        }

        public static void Option_2(List<PetShop> PetShopList)
        {
            ConsoleManager.ClearLine();
            Console.WriteLine();
            for (int i = 0; i < PetShopList.Count; i++)            
            Console.WriteLine($" {PetShopList[i]} ____________________________________\n");
        }
        public static void NoOption()
        {
            Console.WriteLine("\tEssa opção não existe.");           
        }       
        public static void Option1Result(double Value, string PetShopName)
        {
            ConsoleManager.ClearLine();
            Console.WriteLine($"\n\tMelhor canil: {PetShopName} - Preço total: {Value}");
        }
    }
}
