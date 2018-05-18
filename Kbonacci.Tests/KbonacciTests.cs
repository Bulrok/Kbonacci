using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kbonacci;
using Xunit;

namespace Kbonacci.Tests
{
    public class KbonacciTests
    {
        [Fact]
        public void Kbonacci_Test_3_and_4()
        {
            //Arrange
            string expect = "5";

            //Act
            string result = Kbonacci.KbonacciCalc(3, 4);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
