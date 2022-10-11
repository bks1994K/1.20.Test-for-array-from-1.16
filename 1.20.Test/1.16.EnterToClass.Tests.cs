using _1._20;

namespace _1._20.Test
{
    public class EnterToClassTests
    {
        //1

        [TestCase(2, 20, 40, 10)]
        [TestCase(5, 10, 0, -2)]
        [TestCase(100, -150, -50, 1)]
        [TestCase(7, 40, 40, 0)]
        public void MinusAndDivision(int a, int b, int c, int expected)
        {
            int actual = EnterToClass.MinusAndDivision(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        //2

        [TestCase(0, -5, -5)]
        [TestCase(100, 2, 102)]
        [TestCase(-10, -20, -30)]

        [TestCase(0, 50, -50)]
        [TestCase(40, 100, -60)]
        [TestCase(-100, -25, -75)]

        [TestCase(0, 0, 0)]
        [TestCase(5, 5, 25)]
        [TestCase(-3, -3, 9)]


        public void PlusOrMultiplicationOrMinus(int a, int b, int expected)
        {
            int actual = EnterToClass.PlusOrMultiplicationOrMinus(a, b);

            Assert.AreEqual(expected, actual);
        }

        //3

        [TestCase(20, "Двадцать ")]
        [TestCase(10, "Десять ")]
        [TestCase(19, "Девятнадцать ")]
        [TestCase(51, "Пятьдесят один")]
        [TestCase(99, "Девяносто девять")]

        public void ConvertingTwodigitNumberToString(int a, string expected)
        {
            string actual = EnterToClass.ConvertingTwodigitNumberToString(a);

            Assert.AreEqual(expected, actual);
        }

        //4

        [TestCase(0, true)]
        [TestCase(10, true)]
        [TestCase(5, true)]
        [TestCase(20, true)]
        [TestCase(30, true)]
        [TestCase(35, false)]
        [TestCase(40, true)]
        [TestCase(50, true)]
        [TestCase(45, true)]
        [TestCase(-1, false)]
        [TestCase(11, false)]
        [TestCase(15, false)]
        [TestCase(19, false)]
        [TestCase(31, false)]
        [TestCase(39, false)]
        [TestCase(51, false)]
        [TestCase(102, false)]
        [TestCase(-29, false)]
    

        public void NumberInRangeFrom0To10OrFrom20To30OFrom40To50(int a, bool expected)
        {
            bool actual = EnterToClass.NumberInRangeFrom0To10OrFrom20To30OFrom40To50(a);

            Assert.AreEqual(expected, actual);
        }


        //5

        [TestCase(5,15,21)]
        [TestCase(-7,7,0)]

        public void SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(int a, int b, int expected)
        {
            int actual = EnterToClass.SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        //6

        [TestCase(1,0)]
        [TestCase(2,1)]
        [TestCase(3,1)]
        [TestCase(4,2)]
        [TestCase(13,144)]

        public void ReturnsNumberFromFibonacciSeries(int a, int expected)
        {
            int actual = EnterToClass.ReturnsNumberFromFibonacciSeries(a);

            Assert.AreEqual(expected, actual);
        }

        //7

        [TestCase(21554, 3)]
        [TestCase(987, 2)]
        [TestCase(0144422997, 4)]
        [TestCase(126230, 2)]
        [TestCase(84684, 0)]
        [TestCase(-89745, 3)]

        public void CountOddDigitsAreTheNumbers(int a, int expected)
        {
            int actual = EnterToClass.CountOddDigitsAreTheNumbers(a);

            Assert.AreEqual(expected, actual);
        }

        //8

        [TestCase(9,9)]
        [TestCase(02581,1852)]
        [TestCase(6580,0856)]
        [TestCase(-6329,-9236)]

        public void MirroringEnteredNumber(int a, int expected)
        {
            int actual = EnterToClass.MirroringEnteredNumber(a);

            Assert.AreEqual(expected, actual);
        }

        //9

        [TestCase(1254,9847, true)]
        [TestCase(9804,70, true)]
        [TestCase(10874,563330, true)]
        [TestCase(-958,6573, true)]
        [TestCase(2458,79, false)]
        [TestCase(-789,12304, false)]
        [TestCase(08,6573, false)]
        [TestCase(9805,74122, false)]

        public void IdenticalDigitsInTwoNumbers(int a, int b, bool expected)
        {
             bool actual = EnterToClass.IdenticalDigitsInTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

    }
}