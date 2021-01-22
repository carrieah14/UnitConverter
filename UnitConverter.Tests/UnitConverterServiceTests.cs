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

            var inches = unitConverter.ConvertInchesToCM(1);

            Assert.Equal(2.54, inches);
        }

        [Fact]
        public void CMToInches()
        {
            var unitConverter = new UnitConverterService();

            var cm = unitConverter.ConvertCMToInches(1);

            Assert.Equal(0.39, cm);
        }

        [Fact]
        public void YardToMeter()
        {
            var unitConverter = new UnitConverterService();

            var meter = unitConverter.ConvertYardToMeter(1);

            Assert.Equal(0.92, meter);
        }

        [Fact]
        public void MeterToYard()
        {
            var unitConverter = new UnitConverterService();

            var yard = unitConverter.ConvertMeterToYard(1);

            Assert.Equal(1.09, yard);
        }

        [Fact]
        public void MilesToKM()
        {
            var unitConverter = new UnitConverterService();

            var km = unitConverter.ConvertMilesToKM(1);

            Assert.Equal(1.61, km);
        }

        [Fact]
        public void KMToMiles()
        {
            var unitConverter = new UnitConverterService();

            var miles = unitConverter.ConvertKMToMiles(1);

            Assert.Equal(0.62, miles);
        }
    }
}
