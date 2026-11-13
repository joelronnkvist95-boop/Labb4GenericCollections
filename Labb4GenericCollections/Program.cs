using Labb4GenericCollections.Classes;

namespace Labb4GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant1 = new Restaurant();
            
            restaurant1.AddToMenu(new MenuItem(1, "Carbonara", 129));
            restaurant1.AddToMenu(new MenuItem(2, "Bolognese", 139));
            restaurant1.AddToMenu(new MenuItem(3, "Alfredo", 139));
            restaurant1.AddToMenu(new MenuItem(4, "Arrabbiata", 129));

            Console.WriteLine("\n----------------------------\n");
            
            restaurant1.ShowMenu();


        }
    }
}
