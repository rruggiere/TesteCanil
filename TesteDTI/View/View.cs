﻿using System;
using System.Collections.Generic;

namespace TesteDTI
{
    /// <summary>
    /// Contém todas as views que podem ser vistas pelo usuário. 
    /// </summary>
    public static class View
    {

        /// <summary>
        /// Cabeçalho da View.
        /// </summary>
        public static void Header()
        {
            Console.Title = "DTI";
            Console.WriteLine("\n\n\t\t\t\t\t\tTeste - DTI");
        }

        /// <summary>
        /// Conjunto de opções.
        /// </summary>
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

        /// <summary>
        /// Mensagens do sistema.
        /// </summary>
        #region [SystemMensages]
        /// <summary>
        /// Mensagem para entradas inválidas no console.
        /// </summary>
        public static void InvalidEntry()
        {
            Console.Write("\tO valor digitado não é válido. Tente novamente.");
            ClearPrevLine();
        }

        /// <summary>
        /// Mensagem ao fim das execuções escolhidas pelo usuário.
        /// </summary>
        public static void AskExecuteAgain()
        {
            Console.WriteLine("\n\tPressione qualquer tecla para voltar ao menu principal ou digite \"exit\" para encerrar.");
            Console.Write("\t- ");
        }
        /// <summary>
        /// Mensagem caso a opção digita seja inexistente.
        /// </summary>
        public static void NoOption()
        {
            Console.WriteLine("\tEssa opção não existe.");
        }
        #endregion
        #region [Option_1]
        /// <summary>
        /// Conjunto de entradas da opção 1
        /// </summary>
        public static void Option_1_Date()
        {
            ClearLine();
            Console.WriteLine("\n\tData: (dd/MM/aaaa)");
            Console.Write("\t- ");
        }
        public static void Option_1_NumSmallDogs()
        {
            ClearLine();
            Console.WriteLine("\tQuantidade de cães pequenos: (Número inteiro positivo.)");
            Console.Write("\t- ");
        }
        public static void Option_1_NumBigDogs()
        {
            ClearLine();
            Console.WriteLine("\tQuantidade de cães grandes: (Número inteiro positivo.)");
            Console.Write("\t- ");
        }
        public static void Option1Result(string Value, string PetShopName)
        {
            ClearLine();
            Console.WriteLine($"\n\tMelhor petshop: {PetShopName} - Preço total: {Value}");
        }

        #endregion
        /// <summary>
        /// Saída da opção 2.
        /// </summary>
        /// <param name="PetShopList">Lista de PetShops cadastradas.</param>
        #region [Option_2]
        public static void Option_2(List<PetShop> PetShopList)
        {
            ClearLine();
            Console.WriteLine();
            for (int i = 0; i < PetShopList.Count; i++)
                Console.WriteLine($" {PetShopList[i]} ____________________________________\n");
        }
        #endregion

        #region [ ConsoleClearLineFunctions ]
        /// <summary>
        /// Limpa a linha anterior do console e envia o cursor de digitação para a linha de cima.
        /// </summary>
        public static void ClearPrevLine()
        {
            Console.SetCursorPosition(9, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.SetCursorPosition(10, Console.CursorTop - 1);
        }
        /// <summary>
        /// Limpa a linha atual do console e envia o cursor de digitação de volta para o começo da linha.
        /// </summary>
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        #endregion
    }
}
