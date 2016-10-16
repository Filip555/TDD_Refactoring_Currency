using System;
using Xunit;

namespace Waluta.tests
{
    public class CurrenctyTest
    {
        [Fact]
        public void Multiplication_Three_Euro_And_Zloty_Per_Five_Result_Should_be_fifteen()
        {
            Currency zloty = new Zloty(3);
            Currency euro = new Euro(3);

            var resultPLN = zloty.Multiplition(5);
            var resultEUR = euro.Multiplition(5);

            Assert.Equal(15, resultPLN);
            Assert.Equal(15, resultEUR);
        }
        [Fact]
        public void Check_If_One_Euro_Is_Equal_to_One_Zloty()
        {
            Assert.False(new Euro(1).equals(new Zloty(1)));
        }
        [Fact]
        public void Check_If_One_Euro_Is_Equal_to_One_Euro()
        {
            Assert.True(new Euro(1).equals(new Euro(1)));
        }
    }
}
