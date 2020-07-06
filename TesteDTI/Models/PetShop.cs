
using System.Globalization;

namespace TesteDTI
{
    public class PetShop
    { 
        /// <summary>
        /// Entidade PetShop
        /// </summary>
        public string Name { get; set; }
        public int Distance { get; set; }
        public double PriceSmallDog { get; set; }
        public double PriceBigDog { get; set; }
        public double SpecialDayPriceSmallDog { get; set; }
        public double SpecialDayPriceBigDog { get; set; }

        /// <summary>
        /// ToString sobrescrevendo PetShop.
        /// </summary>
        /// <returns>Dados das PetShops cadastradas.</returns>
        public override string ToString()
        {
            string PetShop = string.Empty;

            PetShop += $"\tPetshop: {Name}\n";
            PetShop += $"\tDistância: {Distance}m\n";
            PetShop += $"\tCachorro pequeno: {PriceSmallDog.ToString("C", CultureInfo.CurrentCulture)}\n";
            PetShop += $"\tFim de semana: {SpecialDayPriceSmallDog.ToString("C", CultureInfo.CurrentCulture)}\n";
            PetShop += $"\tCachorro grande: {PriceBigDog.ToString("C", CultureInfo.CurrentCulture)}\n";
            PetShop += $"\tFim de semana: {SpecialDayPriceBigDog.ToString("C", CultureInfo.CurrentCulture)}\n";
            return PetShop;
        }
    }
}
