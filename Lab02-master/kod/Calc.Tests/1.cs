using Calc;
using NUnit.Framework;

// ZMEINIONE NA CWIKACH jak chcemy dołączyc do teswó to tu pogłączamy np program2 itd
using Sut = Calc.Program;

namespace Calculator.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Main_Returns_IntMin_When_Null_Args()
        {
            // arrange
            int expected = int.MinValue;

            // act
            int actual = Sut.Main(null);

            // assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Main_Returns_IntMin_When_Empty_Args()
        {
            int expected = int.MinValue;

            // act
            int actual = Program.Main(new string[] { });

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Main_Returns_IntMin_When_First_Arg_Not_sum_Or_product()
        {
            int expected = int.MinValue;

            // act
            int actual = Program.Main(new[] { "limes"});

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Main_Returns_Zero_When_There_Is_Only_One_Argument_string_sum()
        {
            int expected = 0;

            int actual = Program.Main(new[] { "sum" });

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_Sum_Of_All_Remaining_Arguments_After_sum_String()
        {
            string[] sumArguments = {"sum", "2", "4", "6"};
            int expected = 12;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_One_When_There_Is_Only_One_Argument_string_product()
        {
            int expected = 1;

            int actual = Program.Main(new[] { "product" });

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_Product_Of_All_Remaining_Arguments_After_product_String()
        {
            string[] sumArguments = { "product", "2", "5", "3" };
            int expected = 30;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_1_When_All_Arguments_Create_Arithmetic()
        {
            string[] sumArguments = { "aseq", "-10", "0", "10", "20" };
            int expected = 1;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_0_When_All_Arguments_Dont_Create_Arithmetic()
        {
            string[] sumArguments = { "aseq", "0", "0", "10", "20" };
            int expected = 0;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_1_When_All_Arguments_Create_Nondecreasing_Sequence()
        {
            string[] sumArguments = { "ndec", "0", "0", "1", "1", "7", "100" };
            int expected =1;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Main_Returns_0_When_All_Arguments_Dont_Create_Nondecreasing_Sequence()
        {
            string[] sumArguments = { "ndec", "0", "0", "1", "7", "100", "10", "1000" };
            int expected = 0;

            int actual = Program.Main(sumArguments);

            Assert.AreEqual(expected, actual);
        }
    }
}