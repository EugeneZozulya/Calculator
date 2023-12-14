namespace CalculatorTest
{
    [TestClass]
    public class MathTest
    {
        Calculator.Math math = new Calculator.Math();

        [TestMethod]
        public void Add_Test()
        {
            var a = 34;
            var b = 44;

            var expectedResult = 78;
            var actualResult = math.Add(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Add_Test_2()
        {
            var a = 44;
            var b = 44;

            var expectedResult = 88;
            var actualResult = math.Add(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sub_Test()
        {
            var a = 34;
            var b = 44;

            var expectedResult = -10;
            var actualResult = math.Sub(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sub_Test_2()
        {
            var a = 64;
            var b = 44;

            var expectedResult = 20;
            var actualResult = math.Sub(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Mul_Test()
        {
            var a = 10;
            var b = 44;

            var expectedResult = 440;
            var actualResult = math.Mul(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Div_Test()
        {
            var a = 440;
            var b = 10;

            var expectedResult = 44;
            var actualResult = math.Div(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}