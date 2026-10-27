string deviceId = "laser-01";
string state = "On";
double Ausgangsleistung = 800;
double Kühlmitteltemperatur = 22;
Random random = new Random();


Console.WriteLine("Starting the Device Simulator...");

for (int i = 0; i < 10; i++)
{
    double AusgangsleistungOffset = random.NextDouble() * 100 - 50;
        Ausgangsleistung = Math.Clamp(Ausgangsleistung + AusgangsleistungOffset,0,1500);

    double KühlmitteltemperaturOffset = random.NextDouble() * 4 - 2;
        Kühlmitteltemperatur = Math.Clamp(Kühlmitteltemperatur + KühlmitteltemperaturOffset, 18, 35);
        
    Console.WriteLine($"Index: {i}"); // Generate a random offset between -0.2 and 0.2
    Console.WriteLine($"Ausgangsleistung: {Ausgangsleistung} W");
    Console.WriteLine($"Kühlmitteltemperatur: {Kühlmitteltemperatur} °C");
    Console.WriteLine($"Gerät: {deviceId}");
    Console.WriteLine($"Zustand: {state}");
    Thread.Sleep(1000); // Simulate a delay for data generation
}


