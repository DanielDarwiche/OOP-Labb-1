using System;

namespace OOP_Labb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle nyForm = new Circle();
            nyForm.radie = 5;
            Circle storForm = new Circle();
            storForm.radie = 6;

            nyForm.getArea();
            nyForm.getOmkrets();
            nyForm.getVolym();
            Console.WriteLine("-----------");
            storForm.getArea();
            storForm.getOmkrets();
            storForm.getVolym();
            Console.WriteLine("-----------");
            Circle valFri = new Circle();
            Console.WriteLine("Ange valfri radie på en cirkel för att se alla värden!");
            valFri.radie = double.Parse(Console.ReadLine());
            valFri.getArea();
            valFri.getOmkrets();
            valFri.getVolym();

        }
    }
}
