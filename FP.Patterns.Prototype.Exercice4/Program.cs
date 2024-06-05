using FP.Patterns.Prototype.Exercice4;

Report report = new Report("Report", "This is a report");
var clon = report.Clone();

clon.Show();

Console.WriteLine("--------------------------");
Contract contract = new Contract("Contract", "This a contract");
var contractClon = contract.Clone();
contractClon.Show();
Console.WriteLine("--------------------------");

Presentation presentation= new Presentation("Presentation", "This a presentation");
var presentationClon = presentation.Clone();
presentationClon.Show();