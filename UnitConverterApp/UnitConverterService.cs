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
                    var inResult = unitConversion.ConvertInchesToCM(value);
                    Console.WriteLine($"\n{value} {unit} = {inResult} cm");
                    break;
                case "cm":
                    var cmResult = unitConversion.ConvertCMToInches(value);
                    Console.WriteLine($"\n{value} {unit} = {cmResult} in");
                    break;
                case "yd":
                    var ydResult = unitConversion.ConvertYardToMeter(value);
                    Console.WriteLine($"\n{value} {unit} = {ydResult} m");
                    break;
                case "meter":
                    var mResult = unitConversion.ConvertMeterToYard(value);
                    Console.WriteLine($"\n{value} {unit} = {mResult} yd");
                    break;
            }   
        }

        public double ConvertInchesToCM(double inches)
        {
            // Divides by factor 2.54 and rounds to 2 decimal places
            double cm = inches * inchCmConversionFactor;
            cm = CorrectFormat(cm);

            return cm;
        }

        public double ConvertCMToInches(double cm)
        {
            // Multiples by a fator of and rounds to 2 decimal places
            double inches = cm / inchCmConversionFactor;
            inches = CorrectFormat(inches);

            return inches;
        }

        public double ConvertYardToMeter(double yard)
        {
            double meter = yard / yardMeterConversionFactor;
            meter = CorrectFormat(meter);

            return meter;
        }

        public double ConvertMeterToYard(double meter)
        {
            double yard = meter * yardMeterConversionFactor;
            yard = CorrectFormat(yard);

            return yard;
        }

        public double ConvertMilesToKM(double miles)
        {
            double km = miles * milesKmConversionFactor;
            km = CorrectFormat(km);

            return km;
        }

        public double ConvertKMToMiles(double km)
        {
            double miles = km / milesKmConversionFactor;
            miles = CorrectFormat(miles);

            return miles;
        }

        public double CorrectFormat(double value)
        {
            value = Math.Round(value, 2);
            return value;
        }
    }
}