# Semantity

This package provides semantic types for physical quantities and units of measurement. They are typesafe and offer convenient extensions in order to use them for calculations and display.

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

The current implementation includes the following quantities:
* Acceleration
* Area
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
