# Semantity

This package provides semantic types for physical quantities and units of measurement. They are typesafe and offer convenient extensions in order to use them for calculations and display.

## NuGet

Please find the latest NuGet package [here](https://www.nuget.org/packages/Semantity/).

## Usage

The combination of operator overloading and extension methods simplifies the code drastically. Type inference allows for code like this:
```c#
var area = 40.MilliMeters() * 2.5.Meters();
var intensity = 100.Watts() / area;

// Prints "Intensity: 1000 W/m²"
Console.WriteLine($"Intensity: {intensity}");
```
Each quantity has a base unit and multiple other units to which they can be converted easily:
```c#
Memory memory = 2.KibiBytes();
Memory memoryInBytes = memory.In<Bytes>();

// Prints "Memory in bytes: 2048 B"
Console.WriteLine($"Memory in bytes: {memoryInBytes.Value} B");
```

Type safety prevents you from making mistakes like the following:
```c#
Mass mass = 0.4.KiloGrams();
Mass anotherMass = mass.In<Hertz>();    // Won't compile!
Frequency frequency = mass.In<Hertz>(); // Won't compile!
```

The basic arithmetic operations are implemented generically:
``` c#
Console.WriteLine(1.5.Seconds() + 500.MilliSeconds());      // Prints "2 s"
Console.WriteLine(1.CubicMeters() - 200.Liters());          // Prints "0.8 m³"
Console.WriteLine(10e6.PartsPerMillion() * 100.Percent());  // Prints "1 "
Console.WriteLine(2.Joules() / 100.MilliJoules());          // Prints "20 J"
```

The current implementation includes the following quantities:
* Acceleration
* Area
* Density
* Energy
* Frequency
* Intensity
* Length
* Mass
* Memory
* Power
* Ratio
* Temperature
* Time
* Velocity
* Volume

Soon to come:
* Force

If you have any suggestions or requests regarding **Semantity** feel free to [contact me](mailto:moritz.freyburger@gmx.de).
