using System;
using System.Collections.Generic;
using System.Globalization;

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
        /// Inicia o View de navegação.
        /// </summary>
        public void ViewInit()
        {
            Console.Clear();
            View.Header();
            View.Options();
            ViewController();
        }
        /// <summary>
        /// Executa a lógica do View de navegação do software.
        /// </summary>
        private void ViewController()
        {                          
            do
            {
                //Inicializa o View de opções e carrega a variável InputOption com a entrada que for digitada no console.
                           
                InputOption = ConsoleManager.OptionVerify(Console.ReadLine());

                #region [View logic]
                if (InputOption == 1)
                {
                    MyDogWash = new DogWash();

                    View.Option_1_Date();
                    MyDogWash.Date = ConsoleManager.DateVerify(Console.ReadLine());

                    View.Option_1_NumSmallDogs();
                    MyDogWash.NumSmallDogs = ConsoleManager.NumDogsVerify(Console.ReadLine());

                    View.Option_1_NumBigDogs();
                    MyDogWash.NumBigDogs = ConsoleManager.NumDogsVerify(Console.ReadLine());

                    Option_1_Calcule(MyDogWash);
                }
                else if (InputOption == 2) View.Option_2(Option_2());
              
                View.AskExecuteAgain();
                ConsoleManager.Exit(Console.ReadLine());
                ViewInit();

                #endregion
            } while (!InputOption.Equals("EXIT"));        
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

            View.Option1Result(result.ToString("C", CultureInfo.CurrentCulture), PetShopName);
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
