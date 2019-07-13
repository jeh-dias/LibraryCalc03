using LibraryCalc03.Domain;
using System;
using System.Drawing;
using Xunit;

namespace LibraryCalc03.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void SomaSucesso()
        {
            var point = new PointTest(10, 20);
            var operation = new Operation();

            var resultado = operation.sum(point);
            Assert.True((point.x + point.y) == resultado);
        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(10, 15, 21)]
        [InlineData(-8, 8, 18)]
        [InlineData(-1, -5, -9)]
        public void SomaAtualizadaSucesso(int x, int y,int z)
        {
            var operation = new Operation();
            var resultado = operation.sum(x,y,z);
            Assert.True((x + y +z) == resultado);
        }

        [Fact]
        public void SubtracaoSucesso()
        {
            var point = new PointTest(30, 20);
            var operation = new Operation();

            var resultado = operation.subtraction(point);
            Assert.True((point.x - point.y) == resultado);
        }

        [Fact]
        public void MultiplicacaoSucesso()
        {
            var point = new PointTest(30, 20);
            var operation = new Operation();

            var resultado = operation.multiplication(point);
            Assert.True((point.x * point.y) == resultado);
        }

        [Fact]
        public void DivisaoSucesso()
        {
            var point = new PointTest(25, 25);
            var operation = new Operation();

            var resultado = operation.division(point);
            double x = Double.Parse(point.x.ToString());
            double y = Double.Parse(point.y.ToString());
            Assert.True((x / y) == resultado);
        }
    }
}
