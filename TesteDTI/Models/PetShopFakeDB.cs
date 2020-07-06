using System.Collections.Generic;
using System.Linq;

namespace TesteDTI
{
    /// <summary>
    /// Contém os dados fornecidos de possíveis PetShop's. 
    /// </summary>
    public class PetShopFakeDB
    {
        public readonly List<PetShop> _petShopsList;

        public PetShopFakeDB() 
        {
            _petShopsList = new List<PetShop>();

            _petShopsList.Add(new PetShop
            {
                Name = "Meu Canino Feliz",
                Distance = 2000,
                PriceSmallDog = 20.00,
                PriceBigDog = 40.00,
                SpecialDayPriceSmallDog = 24.00,
                SpecialDayPriceBigDog = 48.00
            });

            _petShopsList.Add(new PetShop
            {
                Name = "ChowChawgas",
                Distance = 800,
                PriceSmallDog = 30.00,
                PriceBigDog = 45.00,
                SpecialDayPriceSmallDog = 30.00,
                SpecialDayPriceBigDog = 45.00 
            });


            _petShopsList.Add(new PetShop
            {
                Name = "Vai Rex",
                Distance = 1700,
                PriceSmallDog = 15.00,
                PriceBigDog = 50.00,
                SpecialDayPriceSmallDog = 20.00,
                SpecialDayPriceBigDog = 55.00
            });

            _petShopsList = _petShopsList.OrderBy(x => x.Distance).ToList();
        }
    }
}
