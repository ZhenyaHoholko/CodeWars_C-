using System;

public class Button
{
    private string identity;

    public Button(string identity)
    {
        this.identity = identity;
    }
    public event EventHandler<ButtonClickedEventArgs> ClickHandler;
    public void Clicked()
    {
        if (ClickHandler != null)
        {
            ClickHandler?.Invoke(this, new ButtonClickedEventArgs(identity));
        }
        else
        {
            throw new Exception("Событие ClickHandler не имеет подписчиков.");
        }
    }
}
public class ButtonClickedEventArgs : EventArgs
{
    public string Location { get; }
    public int Number { get; }

    public ButtonClickedEventArgs(string identity)
    {
        var parts = identity.Split('#');
        if (parts.Length == 2)
        {
            Location = parts[0];
            Number = int.Parse(parts[1]);
        }
        else
        {
            throw new ArgumentException("Некорректный формат строки identity.");
        }
    }
}
public class Door
{
    private void Open(object sender, ButtonClickedEventArgs e)
    {
        Console.WriteLine($"Дверь открыта кнопкой с номером {e.Number} в комнате {e.Location}.");
    }
    public void Init(Button button)
    {
        button.ClickHandler += Open;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Button button = new Button("LivingRoom#1");
        Door door = new Door();
        door.Init(button);
        button.Clicked();
    }
}