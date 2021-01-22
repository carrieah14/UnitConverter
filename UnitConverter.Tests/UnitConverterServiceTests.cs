using Xunit;
using UnitConverterApp;

namespace UnitConverter.Tests
{
    public class UnitConverterServiceTests

    {
        [Fact]
        public void InchesToCM()
        {
            var unitConverter = new UnitConverterService();

            var inches = unitConverter.ConvertInchesCM(1, "in");

            Assert.Equal(2.54, inches);
        }

        [Fact]
        public void CMToInches()
        {
            var unitConverter = new UnitConverterService();

            var cm = unitConverter.ConvertInchesCM(1, "cm");

            Assert.Equal(0.39, cm);
        }

        [Fact]
        public void YardToMeter()
        {
            var unitConverter = new UnitConverterService();

            var meter = unitConverter.ConvertYardMeter(1, "y");

            Assert.Equal(0.92, meter);
        }

        [Fact]
        public void MeterToYard()
        {
            var unitConverter = new UnitConverterService();

            var yard = unitConverter.ConvertYardMeter(1, "meter");

            Assert.Equal(1.09, yard);
        }
    }
}
