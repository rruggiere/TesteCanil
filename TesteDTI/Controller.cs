using System;
using System.Collections.Generic;

namespace TesteDTI
{
    public class Controller
    {
        #region [Properties]
        private int InputOption { get; set; }
        private DogWash MyDogWash { get; set; }

        private PetShopRepostiory Result { get; set; }
        #endregion
        /// <summary>
        /// Inicia o Menu de navegação.
        /// </summary>
        public void MenuInit()
        {
            Console.Clear();
            Menu.Header();
            Menu.Options();
            MenuController();
        }
        /// <summary>
        /// Executa a lógica do Menu de navegação do software.
        /// </summary>
        private void MenuController()
        {                          
            do
            {
                //Inicializa o Menu de opções e carrega a variável InputOption com a entrada que for digitada no console.
                           
                InputOption = ConsoleManager.OptionVerify(Console.ReadLine());

                #region [Menu logic]
                if (InputOption == 1)
                {
                    MyDogWash = new DogWash();

                    Menu.Option_1_Date();
                    MyDogWash.Date = ConsoleManager.DateVerify(Console.ReadLine());

                    Menu.Option_1_NumSmallDogs();
                    MyDogWash.NumSmallDogs = ConsoleManager.NumDogsVerify(Console.ReadLine());

                    Menu.Option_1_NumBigDogs();
                    MyDogWash.NumBigDogs = ConsoleManager.NumDogsVerify(Console.ReadLine());

                    Option_1_Calcule(MyDogWash);
                }
                else if (InputOption == 2) Menu.Option_2(Option_2());
              
                Menu.AskExecuteAgain();
                ConsoleManager.Exit(Console.ReadLine());
                MenuInit();

                #endregion
            } while (!InputOption.Equals("Exit"));
        
        }

        #region [Option_1_Calcule]
        /// <summary>
        /// Efetua o cálculo que determina qual o melhor custo entre as PetShops de acordo com os dados fornecidos no console.
        /// </summary>
        /// <param name="NewDogWash">Recebe um objeto do tipo NewDogWash com as informações de acordo com as informações digitadas no console pelo Canil.</param>
        public void Option_1_Calcule(DogWash NewDogWash)
        {
            string PetShopName;           

            //Efetua a chamada de função após verificar qual o dia da semana baseado na data fornecida.
            Result = new PetShopRepostiory();
            double result = NewDogWash.Date.DayOfWeek.Equals(DayOfWeek.Saturday) || NewDogWash.Date.DayOfWeek.Equals(DayOfWeek.Sunday) ? Result.CalculeSpecialDay(NewDogWash, out PetShopName)
                : Result.CalculeWeek(NewDogWash, out PetShopName);

            Menu.Option1Result(result, PetShopName);
        }
        #endregion
        /// <summary>
        /// Retorna uma lista com todas as PetShop's cadastradas no sistema. 
        /// </summary>
        /// <returns></returns>
        #region [Option_2]
        public List<PetShop> Option_2()
        {
            Result = new PetShopRepostiory();
            return Result.ShowPetShops();
        }
        #endregion
    }
}
