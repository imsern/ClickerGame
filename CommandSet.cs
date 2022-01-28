namespace Klikkerspill;

public class CommandSet
{
    private ICommand[] _commands;


    public CommandSet(ClickerGame game)
    {
        _commands = new ICommand[]
        {
            new ExitGame(),
            new Click(game),
            new Upgrade(game),
            new SuperUpgrade(game),
        };
    }

    public void Run(char charCommand)
    {
        var command = FindCommand(charCommand);
        if (command != null) command.Run();
    }

    private ICommand FindCommand(char commandChar)
    {
        foreach (var command in _commands)
        {
            if (command.Character == commandChar) return command;
        }
        return null;
    }
}