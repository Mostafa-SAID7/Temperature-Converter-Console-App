using System;

class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    public static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    public static double CelsiusToKelvin(double c) => c + 273.15;
    public static double KelvinToCelsius(double k) => k - 273.15;

    public static string GetTemperatureCategory(double celsius)
    {
        if (celsius < 0)
            return "Freezing cold (below 0°C)";
        else if (celsius < 10)
            return "Cold (0°C to 9.9°C)";
        else if (celsius < 20)
            return "Cool (10°C to 19.9°C)";
        else if (celsius < 30)
            return "Moderate (20°C to 29.9°C)";
        else if (celsius < 40)
            return "Warm (30°C to 39.9°C)";
        else
            return "Hot (40°C and above)";
    }

    static void Main()
    {
        Console.WriteLine("=== Temperature Converter ===");
        Console.WriteLine("Type 'exit' at any time to quit.\n");

        Console.WriteLine("Valid Temperature Ranges:");
        Console.WriteLine("  Celsius:    -273.15 to 1000");
        Console.WriteLine("  Fahrenheit: -459.67 to 1832");
        Console.WriteLine("  Kelvin:     0 to 1273.15\n");

        while (true)
        {
            Console.Write("Choose input scale: (C)elsius, (F)ahrenheit, or (K)elvin: ");
            string scale = Console.ReadLine().Trim().ToUpper();

            if (scale == "EXIT") break;

            if (scale != "C" && scale != "F" && scale != "K")
            {
                Console.WriteLine("Invalid scale. Please enter C, F, or K.\n");
                continue;
            }

            Console.Write("Enter the temperature value: ");
            string inputStr = Console.ReadLine().Trim();
            if (inputStr.ToLower() == "exit") break;

            if (!double.TryParse(inputStr, out double input))
            {
                Console.WriteLine("Invalid number. Try again.\n");
                continue;
            }

            // Validate temperature range
            bool isValid = (scale == "C" && input >= -273.15 && input <= 1000) ||
                           (scale == "F" && input >= -459.67 && input <= 1832) ||
                           (scale == "K" && input >= 0 && input <= 1273.15);

            if (!isValid)
            {
                Console.WriteLine("Temperature out of valid range. Please try again.\n");
                continue;
            }

            // Convert to Celsius
            double celsius;
            switch (scale)
            {
                case "C":
                    celsius = input;
                    break;
                case "F":
                    celsius = FahrenheitToCelsius(input);
                    break;
                case "K":
                    celsius = KelvinToCelsius(input);
                    break;
                default:
                    Console.WriteLine("Unexpected error.");
                    continue;
            }

            // Perform conversions
            double fahrenheit = CelsiusToFahrenheit(celsius);
            double kelvin = CelsiusToKelvin(celsius);
            string category = GetTemperatureCategory(celsius);

            // Output results
            Console.WriteLine("\nConverted Temperatures:");
            Console.WriteLine($"Celsius:    {celsius:F2} °C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Kelvin:     {kelvin:F2} K");
            Console.WriteLine($"Temperature Category: {category}\n");
        }

        Console.WriteLine("\nThank you for using the Temperature Converter!");
    }
}
