using System;
using System.Collections.Generic;

namespace TesteDTI
{
    public class PetShopRepostiory
    {
        #region [Properties]
        private readonly FakePetShopDataBase _DBPetShop;
        private double TotalValue { get; set; }
        private int FindIndex { get; set; }
        private double TemporaryValue { get; set; }
        #endregion

        #region [Constructor]
        public PetShopRepostiory()
        {
            _DBPetShop = new FakePetShopDataBase();
        }
        #endregion

        /// <summary>
        /// Lógica que determina qual a PetShop mais próxima do Canil e com o valor mais barato de acordom os dados digitados no console.
        /// </summary>
        /// <param name="NewDogWash">Recebe um objeto do tipo NewDogWash com as informações de acordo com as informações digitadas no console pelo Canil.</param>
        /// <param name="PetShopName">Parâmetro de saída que recebe o nome da PetShop que possuir o melhor preço.</param>
        /// <returns></returns>
        #region [Calculations]
        //Função para os dias de semana
        public double CalculeWeek(DogWash NewDogWash, out string PetShopName)
        {
            TemporaryValue = (_DBPetShop._petShopsList[0].PriceSmallDog * NewDogWash.NumSmallDogs) + (_DBPetShop._petShopsList[0].PriceBigDog * NewDogWash.NumBigDogs);
            FindIndex = 0;

            for (int i = 1; i < _DBPetShop._petShopsList.Count; i++)
            {
                TotalValue = (_DBPetShop._petShopsList[i].PriceSmallDog * NewDogWash.NumSmallDogs) + (_DBPetShop._petShopsList[i].PriceBigDog * NewDogWash.NumBigDogs);
                if (TemporaryValue > TotalValue)
                {
                    TemporaryValue = TotalValue;
                    FindIndex = i;
                }
            }

            PetShopName = _DBPetShop._petShopsList[FindIndex].Name;
            TotalValue = TemporaryValue;

            return TotalValue;
        }

        //Função para os finais de semana
        public double CalculeSpecialDay(DogWash NewDogWash, out string PetShopName)
        {
            TemporaryValue = (_DBPetShop._petShopsList[0].SpecialDayPriceSmallDog * NewDogWash.NumSmallDogs) + (_DBPetShop._petShopsList[0].SpecialDayPriceBigDog * NewDogWash.NumBigDogs);
            FindIndex = 0;

            for (int i = 1; i < _DBPetShop._petShopsList.Count; i++)
            {
                TotalValue = (_DBPetShop._petShopsList[i].SpecialDayPriceSmallDog * NewDogWash.NumSmallDogs) + (_DBPetShop._petShopsList[i].SpecialDayPriceBigDog * NewDogWash.NumBigDogs);
                if (TemporaryValue < TotalValue)
                {
                    TemporaryValue = TotalValue;
                    FindIndex = i;
                }
            }

            PetShopName = _DBPetShop._petShopsList[FindIndex].Name;
            TotalValue = TemporaryValue;


            return TotalValue;
        }
        #endregion

        /// <summary>
        /// Retorna a lista de PetShops cadastrada no sistema. 
        /// </summary>
        /// <returns></returns>
        public List<PetShop> ShowPetShops()        
        {                  
           return _DBPetShop._petShopsList;           
        }
    }
}
