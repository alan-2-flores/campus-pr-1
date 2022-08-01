using PerformanceReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PerformanceTesting
{
    public class DelegateTesting
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 4, 5)]
        public void ShouldSumar(int a, int b, int esperado) {
            Delegados delegados = new Delegados();
            Assert.Equal(esperado, delegados.suma(a, b));
        }
    }
}
