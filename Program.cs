using System;
using System.Linq;

namespace AscendingOrder;

class Program
{
    public static void Main(string[] args)
    {
        string [] cities = { "ABU DHABI","PARIS", "AMSTERDAM", "ROME", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI" };

       

        System.Console.WriteLine("\n \nThe list of cities are \n");
        foreach(string values in cities)
        {
            System.Console.WriteLine(values + "\n");
        }

        var sortedCities = cities.OrderBy(x=> x.Length).ThenBy(x=> x);

        System.Console.WriteLine("\n \nThe sorted list is \n");

        foreach(string values in sortedCities)
        {
            System.Console.WriteLine(values + "\n");
        }

        
    }
}
