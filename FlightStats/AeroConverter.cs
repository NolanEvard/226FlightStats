using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStats
{
    public class AeroConverter
    {
        #region private attributes
        #endregion region attributes

        #region public methods
        /// <summary>
        /// This method converts Celsius value in Kelvin value
        /// Ref : Celsius + 273 = Kelvin
        ///       273 is a constant
        /// </summary>
        /// <param name="temperatureInCelsius">value in Celsius to convert</param>
        /// <returns>Celsius converted in Kelvin with precision of 2 decimal places (12.34)</returns>
        public double ConvertCelsiusToKelvin(double temperatureInCelsius)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method converts Fahrenheit value in Celsius value
        /// Ref : ((Fahrenheit - 32) * 5 / 9) = Celsius
        ///       32, 5 and 9 are constants
        /// </summary>
        /// <param name="temperatureInFahrenheit">value in Fahrenheit to convert</param>
        /// <returns>Fahrenheit converted in Celsius with precision of 2 decimal places (12.34)</returns>
        public double ConvertFahrenheitToCelsius(double temperatureInFahrenheit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method converts Fahrenheit value in to Kelvin value
        /// Ref : The easiest way is to get the Celsius value from the Fahrenheit then add 273
        ///       273 is a constant
        /// </summary>
        /// <param name="temperatureInFahrenheit"></param>
        /// <returns>Fahrenheit converted in Kelvin with precision of 2 decimal places (12.34)</returns>
        public double ConvertFahrenheitToKelvin(double temperatureInFahrenheit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method gets the local speed of sound, based on Kelvin temperature measure
        /// Ref : Local Speed of Sound = 38.94 * Kelvin ^ 1/2;
        ///       38.94, 1/2 are a constants
        /// </summary>
        /// <param name="temperatureInKelvin"></param>
        /// <returns>Local speed of sound in knots with precision of 2 decimal places (12.34)</returns>
        public double LocalSpeedOfSound(double temperatureInKelvin)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
