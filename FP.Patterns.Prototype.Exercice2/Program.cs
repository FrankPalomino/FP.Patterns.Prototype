using FP.Patterns.Prototype.Exercice2;

IDocumentPrototype presentationPrototype = new Presentation();
IDocumentPrototype reportPrototype = new Report();

var presentation1 = presentationPrototype.Clone();
presentation1.Month = "Febrero";

var presentation2 = presentationPrototype.Clone();
presentation2.Description = "Presentación 2";

var  report1 = reportPrototype.Clone();
report1.Month = "Marzo";

var report2 = reportPrototype.Clone();
report2.Description = "Reporte 2";

Console.WriteLine(presentation1.Month + " " + presentation1.Description);
Console.WriteLine(presentation2.Month + " " + presentation2.Description);
Console.WriteLine(report1.Month + " " + report1.Description);
Console.WriteLine(report2.Month + " " + report2.Description);