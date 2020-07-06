
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

            PetShop += $"\tNome: {Name}\n";
            PetShop += $"\tDistância: {Distance}\n";
            PetShop += $"\tCachorro pequeno: {PriceSmallDog}\n";
            PetShop += $"\tFim de semana: {SpecialDayPriceSmallDog}\n";
            PetShop += $"\tCachorro grande: {PriceBigDog}\n";
            PetShop += $"\tFim de semana: {SpecialDayPriceBigDog}\n";
            return PetShop;
        }
    }
}
