namespace Klikkerspill;

public class Upgrade : ICommand
{
    private ClickerGame _game;
    public char Character { get; } = 'K';

    public Upgrade(ClickerGame game)
    {
        _game = game;
    }
    public void Run()
    {
        _game.Upgrade();
    }

    
}