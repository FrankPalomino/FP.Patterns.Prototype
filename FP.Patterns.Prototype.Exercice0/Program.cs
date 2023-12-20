using FP.Patterns.Prototype;

AutoPrototype alfaRomeoPrototype = new AlfaRomeoPrototype();
AutoPrototype fiatPrototype = new FiatPrototype();
AutoPrototype dsPrototype = new DSPrototype();

AutoPrototype fiatPalio = fiatPrototype.Clone();
fiatPalio.Model = "Palio";
fiatPalio.Color = "Red";
Console.WriteLine(fiatPalio.GetInfo());

AutoPrototype fiatPunto = fiatPrototype.Clone();
fiatPunto.Model = "Punto";
fiatPunto.Color = "Blue";
Console.WriteLine(fiatPunto.GetInfo());

AutoPrototype ds3 = dsPrototype.Clone();
ds3.Model = "DS3";
ds3.Color = "White";
Console.WriteLine(ds3.GetInfo());

AutoPrototype ds4 = dsPrototype.Clone();
ds4.Model = "DS4";
ds4.Color = "Black";
Console.WriteLine(ds4.GetInfo());