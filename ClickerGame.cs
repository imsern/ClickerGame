namespace Klikkerspill;

public class ClickerGame
{
    public int Points { get; private set; } = 0;
    int _pointsPerClick = 1;
    int _pointsPerClickIncrease = 1;


    public void CommandText()
    {
        Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            
    }

    public void ClickyClick()
    {
        Points += _pointsPerClick;
    }

    public void Upgrade()
    {
        if (Points < 10) return;
        Points -= 10;
        _pointsPerClick += _pointsPerClickIncrease;
    }

    public void SuperUpgrade()
    {
        if (Points < 100) return;
        Points -= 100;
        _pointsPerClickIncrease++;
    }
}