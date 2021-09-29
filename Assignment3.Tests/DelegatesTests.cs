using System.IO;
using System.Linq;
using System;
using Xunit;

namespace BDSA2021.Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void NumEqual_given_stringas2_and_int2_Returns_True()
        {
            Delegates del = new Delegates();
            string input1 = "2";
            int input2 = 2;

            var actual = del.NumEqual((input1, input2));

            Assert.True(actual);
        }

        [Fact]
        public void Product_given_3_5_returns_15()
        {
            Delegates del = new Delegates();
            double input1 = 3;
            double input2 = 5;
            double expected = input1 * input2;

            var prod = del.Product((input1,input2));

            Assert.Equal(expected, prod);

        }

        [Theory]
        [InlineData("welcome")]
        [InlineData("to")]
        [InlineData("Hogwarts")]
        public void reverse_String_given_strings(string input)
        {
            //set up
            String expected = new string(input.Reverse().ToArray());

            var output = new StringWriter();
            Console.SetOut(output);
            Delegates del = new Delegates();

            //Act
            del.ReverseString(input);

            //Assert
            Assert.Equal(expected, output.ToString().Trim());
        }
    }
}
