using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft_excercise_4;

namespace UnitTests
{
    [TestClass]
    public class StrShiftTest
    {
        [TestMethod]
        public void StrShift__LeftArrows__ShiftLastLetterToStart__tmicrosoft()
        {
            StrShift input = "microsoft";
            StrShift result = input << 1;
            Assert.IsTrue(result == "tmicrosof");
        }

        [TestMethod]
        public void StrShift__RightArrows__ShiftFirstLetterToEnd__icrosoftM()
        {
            StrShift input = "Microsoft";
            StrShift result = input >> 1;
            Assert.IsTrue(result == "icrosoftM");
        }

        [TestMethod]
        public void StrShift__LeftDoubleArrows__ShiftLastTwoLettersToStart__ftmicroso()
        {
            StrShift input = "microsoft";
            StrShift result = input << 1 << 1;
            Assert.IsTrue(result == "ftmicroso");
        }

        [TestMethod]
        public void StrShift__RightArrows__ShiftLastTwoLettersToEndAndCheckTextCase__cRosoftMi()
        {
            StrShift input = "MicRosoft";
            StrShift result = input >> 2;
            Assert.IsTrue(result == "cRosoftMi");
        }

        [TestMethod]
        public void StrShift__NotEqual__ShiftLastTwoLettersToEndAndCheckTextCase__cRosoftMi()
        {
            StrShift input = "MicRosoft";
            StrShift result = input != 2;
            Assert.IsTrue(result == "cRosoftMi");
        }


        [TestMethod]
        public void StrShift__DoubleEqual__ShiftLastTwoLettersToStart__ftmicroso()
        {
            StrShift input = "microsoft";
            StrShift result = input == 2;
            Assert.IsTrue(result == "ftmicroso");
        }
    }
}
