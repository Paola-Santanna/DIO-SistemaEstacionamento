namespace ParkSystemDIO.Domain;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int option;

        Console.WriteLine(">>>Bem Vindo ao Estacionamento!<<<\n".ToUpper());

        option = menu.MenuOptions();
        menu.OptionChoosed(option);
    }
}