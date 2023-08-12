﻿namespace TemperatureConversion
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        public static double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit + 459.67) * 5 / 9;
        }

        public static double KelvinToFahrenheit(double kelvin)
        {
            return kelvin * 9 / 5 - 459.67;
        }
    }
}
