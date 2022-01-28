using Klikkerspill;

var clicker = new ClickerGame();
var commands = new CommandSet(clicker);

while (true)
{
    Console.Clear();
    clicker.CommandText();
    Console.WriteLine($"Du har {clicker.Points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Char.ToUpper(Console.ReadKey().KeyChar);
    commands.Run(command);
}