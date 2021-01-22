using System;

namespace UnitConverterApp
{
    public class UnitConverterService
    {
        // Conversion Factors
        public const double inchCmConversionFactor = 2.54;
        public const double yardMeterConversionFactor = 1.09;
        public const double milesKmConversionFactor = 1.61;

        static void Main(string[] args)
        {
           Console.WriteLine("Hello! Please input the unit of measure you would like converted." +
               "\nThe following conversions are supported:\n" +
               "\nin <-> cm" +
               "\nyd <-> m\n");

            Console.Write("Please input the numerical value: ");
            string valueAnswer = Console.ReadLine();

            Console.Write("Please input the initial UNIT of your value: ");
            string unit = Console.ReadLine();

            double value = 0;
            double.TryParse(valueAnswer, out value);

            var unitConversion = new UnitConverterService();

            switch(unit)
            {
                case "in":
                    var inResult = unitConversion.ConvertInchesCM(value, unit);
                    Console.WriteLine($"\n{value} {unit} = {inResult} cm");
                    break;
                case "cm":
                    var cmResult = unitConversion.ConvertInchesCM(value, unit);
                    Console.WriteLine($"\n{value} {unit} = {cmResult} in");
                    break;
                case "meter":
                    var mResult = unitConversion.ConvertYardMeter(value, unit);
                    Console.WriteLine($"\n{value} {unit} = {mResult} yd");
                    break;
                case "yd":
                    var ydResult = unitConversion.ConvertYardMeter(value, unit);
                    Console.WriteLine($"\n{value} {unit} = {ydResult} m");
                    break;
            }   
        }

        public double ConvertInchesCM(double value, string unit)
        {
            if(unit == "in")
            {
                // Input = inches, output = cm
                double convertedValue = value * inchCmConversionFactor;
                convertedValue = CorrectFormat(convertedValue);

                return convertedValue;
            }
            else
            {
                // Input = cm, output = inches
                double convertedValue = value / inchCmConversionFactor;
                convertedValue = CorrectFormat(convertedValue);

                return convertedValue;
            }
        }

        public object ConvertYardMeter(double value, string unit)
        {
            if (unit == "meter")
            {
                // Input = m, output = y
                double convertedValue = value * yardMeterConversionFactor;
                convertedValue = CorrectFormat(convertedValue);

                return convertedValue;
            }
            else
            {
                // Input = y, output = m
                double convertedValue = value / yardMeterConversionFactor;
                convertedValue = CorrectFormat(convertedValue);

                return convertedValue;
            }
        }

        public double CorrectFormat(double value)
        {
            value = Math.Round(value, 2);
            return value;
        }
    }
}