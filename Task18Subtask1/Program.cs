using System.Reflection;
using Task18Subtask1;
/// <summary>
/// Клиентский код
/// </summary>
class Program
{
    static void Main()
    {
        // создадим отправителя
        var sender = new Sender();

        // создадим получателя
        var receiver = new Receiver();

        // создадим команду
        var commandOne = new CommandOne(receiver);

        // инициализация команды
        sender.SetCommand(commandOne);

        //  выполнение
        sender.Run();
    }
}