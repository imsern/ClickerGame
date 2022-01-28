namespace Klikkerspill;

public class ExitGame : ICommand
{
    
    public char Character { get; } = 'X';

    public void Run()
    {
        Environment.Exit(0);
    }

    
}