using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TesteDTI;

namespace TesteDTI_UnitTest
{
    [TestClass]
    public class TesteDTI_Tests
    {
        [TestMethod]
        public void TestCalculeWeek()
        {
            //Testa se o cáculo feito para os dias de semana volta corretamente o menor valor de acordo com a entrada. 
            PetShopRepostiory actualCalc = new PetShopRepostiory();

            double Actual = actualCalc.CalculeWeek(new DogWash { Date = Convert.ToDateTime("03/07/2020"), NumBigDogs = 10, NumSmallDogs = 10 }, out _);

            double Expected = 600.00;

            Assert.AreEqual(Expected, Actual, 0.00, "Inconsistent calcule.");
        }

        [TestMethod]
        public void TestCalculeSpecialDay()
        {
            //Testa se o cáculo feito para os finais de semana volta corretamente o menor valor de acordo com a entrada. 
            PetShopRepostiory actualCalc = new PetShopRepostiory();

            double Actual = actualCalc.CalculeSpecialDay(new DogWash { Date = Convert.ToDateTime("04/07/2020"), NumBigDogs = 10, NumSmallDogs = 10 }, out _);

            double Expected = 720.00;

            Assert.AreEqual(Expected, Actual, 0.00, "Inconsistent calcule.");
        }
        [TestMethod]
        public void TestCalculeSpecialDayDraw()
        {
            //Testa se o cáculo feito para os finais de semana volta corretamente a PetShop mais próxima em caso de empate. O empate será entre ChowChawgas, a mais próxima, e Meu Canino Feliz.
            PetShopRepostiory actualCalc = new PetShopRepostiory();
            _ = actualCalc.CalculeSpecialDay(new DogWash { Date = Convert.ToDateTime("04/07/2020"), NumBigDogs = 2, NumSmallDogs = 1 }, out string PetShopName);

            string Expected = "ChowChawgas"; 

            Assert.AreEqual(Expected, PetShopName, "", "Wrong PetShop.");
        }
        [TestMethod]
        public void TestCalculeWeekDraw()
        {
            //Testa se o cáculo feito para os dias de semana volta corretamente a PetShop mais próxima em caso de empate. O empate será entre Vai Rex, a mais próxima, e Meu Canino Feliz.
            PetShopRepostiory actualCalc = new PetShopRepostiory();
            _ = actualCalc.CalculeSpecialDay(new DogWash { Date = Convert.ToDateTime("03/07/2020"), NumBigDogs = 1, NumSmallDogs = 2 }, out string PetShopName);

            string Expected = "Vai Rex";

            Assert.AreEqual(Expected, PetShopName, "", "Wrong PetShop.");
        }

        [TestMethod]
        public void TestConsoleManagerToDate()
        {
            //Testa se a validação de entrada de data do console está sendo feita corretamente.

            string Today = DateTime.Now.ToString("dd/MM/yyyy");

            DateTime Expected = Convert.ToDateTime(Today);

            DateTime Actual = ConsoleManager.DateVerify(Today);

            Assert.AreEqual(Expected, Actual, "dd/MM/yyyy" ,"Fail to convert.");         

        }

        [TestMethod]
        public void TestConsoleManagerToInt()
        {
            //Testa se a validação de entrada de númeiros inteiros maior ou igual a 0 do console está sendo feita corretamente.
            Console.WriteLine(" ");
            int Expected = 1;

            int Actual = ConsoleManager.NumDogsVerify("1");

            Assert.AreEqual(Expected, Actual, 0, "Fail to convert.");

        }

    }
}
