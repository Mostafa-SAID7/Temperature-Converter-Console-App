# Temperature Converter Console App

A simple and efficient console-based temperature converter application built in C# that allows users to convert temperatures between Celsius, Fahrenheit, and Kelvin.

## Features

- **Multiple Temperature Scales**: Convert between Celsius (°C), Fahrenheit (°F), and Kelvin (K)
- **Interactive Console Interface**: User-friendly command-line interface
- **Input Validation**: Robust error handling for invalid inputs
- **Precise Calculations**: Accurate temperature conversion formulas
- **Clean Code Structure**: Well-organized and maintainable codebase

## Supported Conversions

The application supports all possible conversions between:
- Celsius to Fahrenheit
- Celsius to Kelvin
- Fahrenheit to Celsius
- Fahrenheit to Kelvin
- Kelvin to Celsius
- Kelvin to Fahrenheit

## Installation

### Prerequisites
- .NET Core 3.1 or later
- Any C# compatible IDE (Visual Studio, Visual Studio Code, etc.)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App.git
   ```

2. Navigate to the project directory:
   ```bash
   cd Temperature-Converter-Console-App
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

## Usage

1. Launch the application
2. Follow the on-screen prompts to:
   - Enter the temperature value
   - Select the source temperature scale
   - Select the target temperature scale
3. View the converted result
4. Choose to perform another conversion or exit

### Example Usage
```
Welcome to Temperature Converter!

Enter temperature value: 100
Select source scale:
1. Celsius
2. Fahrenheit
3. Kelvin
Choice: 1

Select target scale:
1. Celsius
2. Fahrenheit
3. Kelvin
Choice: 2

Result: 100°C = 212°F
```

## Temperature Conversion Formulas

The application uses the following standard conversion formulas:

**Celsius to Fahrenheit:**
```
°F = (°C × 9/5) + 32
```

**Celsius to Kelvin:**
```
K = °C + 273.15
```

**Fahrenheit to Celsius:**
```
°C = (°F - 32) × 5/9
```

**Fahrenheit to Kelvin:**
```
K = (°F - 32) × 5/9 + 273.15
```

**Kelvin to Celsius:**
```
°C = K - 273.15
```

**Kelvin to Fahrenheit:**
```
°F = (K - 273.15) × 9/5 + 32
```

## Project Structure

```
Temperature-Converter-Console-App/
├── Program.cs              # Main application entry point
├── TemperatureConverter.cs # Core conversion logic
├── README.md              # Project documentation
└── Temperature-Converter-Console-App.csproj # Project file
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Future Enhancements

- [ ] Add support for additional temperature scales (Rankine, Réaumur)
- [ ] Implement batch conversion from file input
- [ ] Add GUI version using Windows Forms or WPF
- [ ] Include unit tests for conversion accuracy
- [ ] Add configuration file for custom settings

## License

This project is open source and available under the [MIT License](LICENSE).

## Author

**Mostafa SAID**
- GitHub: [@Mostafa-SAID7](https://github.com/Mostafa-SAID7)

## Acknowledgments

- Thanks to the .NET community for excellent documentation
- Inspired by the need for a simple, reliable temperature conversion tool

---

*For any questions or suggestions, please open an issue or contact the author directly.*
