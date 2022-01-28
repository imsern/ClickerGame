namespace Klikkerspill;

public interface ICommand
{
    public void Run(){}
    char Character { get; }
}