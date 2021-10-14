using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightStats;

namespace FlightStats
{
    public class Measure
    {
        #region private attributes
        private double temperatureInFahrenheit;
        private double temperatureInCelsius;
        private double temperatureInKelvin;
        private double localSpeedOfSound;
        AeroConverter converter = new AeroConverter();
        #endregion private attributes

        #region constructors
        public Measure(double temperatureInFahrenheit)
        {
            this.temperatureInFahrenheit = temperatureInFahrenheit;
            this.temperatureInCelsius = converter.ConvertFahrenheitToCelsius(temperatureInFahrenheit);
            this.temperatureInKelvin = converter.ConvertFahrenheitToKelvin(temperatureInFahrenheit);
            this.localSpeedOfSound = converter.LocalSpeedOfSound(temperatureInKelvin);
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius)
        {
            this.temperatureInFahrenheit = temperatureInFahrenheit;
            this.temperatureInCelsius = temperatureInCelsius;
            this.temperatureInKelvin = converter.ConvertFahrenheitToKelvin(temperatureInFahrenheit);
            this.localSpeedOfSound = converter.LocalSpeedOfSound(temperatureInKelvin);
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin)
        {
            this.temperatureInFahrenheit = temperatureInFahrenheit;
            this.temperatureInCelsius = temperatureInCelsius;
            this.temperatureInKelvin = temperatureInKelvin;
            this.localSpeedOfSound = converter.LocalSpeedOfSound(temperatureInKelvin);
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin, double localSpeedOfSound)
        {
            this.temperatureInFahrenheit = temperatureInFahrenheit;
            this.temperatureInCelsius = temperatureInCelsius;
            this.temperatureInKelvin = temperatureInKelvin;
            this.localSpeedOfSound = localSpeedOfSound;
        }
        #endregion constructors

        #region public accessors and mutators methods
        public override string ToString()
        {
            CultureInfo ci = new CultureInfo("en-us");
            return temperatureInFahrenheit.ToString("F2", ci) + ";" + temperatureInCelsius.ToString("F2", ci) + ";" + temperatureInKelvin.ToString("F2", ci) + ";" + localSpeedOfSound.ToString("F2", ci);
        }
        #endregion public accessors and mutators methods
    }
}
