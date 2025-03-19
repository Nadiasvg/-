using ConsoleApp1;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var tanks = Tanks.GetTanks();
        var units = Units.GetUnits();
        var factories = Factory.GetFactories();
        Console.WriteLine($"Количество резервуаров: {tanks.Length}, установок: {units.Length}");

        var foundUnit = Units.FindUnit(units, tanks, "Резервуар 2");
        var factory = Factory.FindFactory(factories, foundUnit);

        Console.WriteLine($"Резервуар 2 принадлежит установке {foundUnit.Name} и заводу {factory.Name}");

        var totalVolume = Tanks.GetTotalVolume(tanks);
        Console.WriteLine($"Общий объем резервуаров: {totalVolume}");
    }

}

