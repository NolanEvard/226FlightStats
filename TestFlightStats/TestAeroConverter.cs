using NUnit.Framework;
using System;

namespace FlightStats
{
    /// <summary>
    /// This test class is designed to verify proper operation and compliance 
    /// with "AeroConverter" class specifications.
    /// Project: FlightStats
    /// Author : nicolas.glassey@cpnv.ch
    /// Version: 12-NOV-2019
    /// </summary>
    [TestFixture]
    public class TestAeroConverter
    {
        /// <summary>
        /// This test method is designed to test the conversion of a Celsius temperature value to a kelvin value
        /// </summary>
        [Test]
        public void ConvertCelsiusToKelvin_BasicCase_Success()
        {
            //given
            double outsideAirTemperatureInCelsius = -52;
            double expectedTemperatureInKelvin = 221;
            double actualTemperatureInKelvin = 0;

            AeroConverter aeroConverter = new AeroConverter();

            //when
            actualTemperatureInKelvin = aeroConverter.ConvertCelsiusToKelvin(outsideAirTemperatureInCelsius);

            //then
            Assert.AreEqual(expectedTemperatureInKelvin, actualTemperatureInKelvin);
        }

        /// <summary>
        /// This test method is designed to test the conversion of a Fahrenheit temperature value to a Celsius value
        /// </summary>
        [Test]
        public void ConvertFahrenheitToCelsius_BasicCase_Success()
        {
            //given
            double outsideAirTemperatureInFahrenheit = 48;
            double expectedTemperatureInCelsius = 8.89;
            double actualTemperatureInCelsius = 0;

            AeroConverter aeroConverter = new AeroConverter();

            //when
            actualTemperatureInCelsius = aeroConverter.ConvertFahrenheitToCelsius(outsideAirTemperatureInFahrenheit);

            //then
            Assert.AreEqual(expectedTemperatureInCelsius, actualTemperatureInCelsius);
        }

        /// <summary>
        /// This test method is designed to test the conversion of a Fahrenheit temperature value to a Kelvin value
        /// </summary>
        [Test]
        public void ConvertFarheneitToKelvin_BasicCase_Success()
        {
            AeroConverter aeroConverter = new AeroConverter();
            double outsideAirTemperatureInFahrenheit = 32;
            double expectedTemperatureInKelvin = 273;
            double actualTemperatureInKelvin = 0;

            //when
            actualTemperatureInKelvin = aeroConverter.ConvertFahrenheitToKelvin(outsideAirTemperatureInFahrenheit);

            //then
            Assert.AreEqual(expectedTemperatureInKelvin, actualTemperatureInKelvin);
        }

        /// <summary>
        /// This test method is designed to test the value of the Local Speed of Sound based on the temperature in Kelvin
        /// </summary>
        [Test]
        public void LocalSpeedOfSound_BasicCase_Success()
        {
            //given
            double outsideAirTemperatureInKelvin = 221;
            double expectedSpeedOfSoundInKnots = 578.88;
            double actualSpeedOfSoundInKnots = 0;

            AeroConverter aeroConverter = new AeroConverter();

            //when
            actualSpeedOfSoundInKnots = aeroConverter.LocalSpeedOfSound(outsideAirTemperatureInKelvin);

            //then
            Assert.AreEqual(expectedSpeedOfSoundInKnots, actualSpeedOfSoundInKnots);
        }
    }
}
