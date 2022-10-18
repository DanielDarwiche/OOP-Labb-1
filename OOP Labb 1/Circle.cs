using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_1
{
    class Circle
    {
        public double radie;
        public double pi = 3.141;       

        public double getArea()
        {
            double area = radie * radie * pi;  
            Console.WriteLine($"Arean av cirklen är: {area}");
            Console.WriteLine();
            return area;
        }
        public void getOmkrets()
        {  
            double diameter = radie * 2;
            double omkrets = pi * diameter; 
            Console.WriteLine($"Omkretsen av cirklen/cylindern (med {diameter} i diameter) är: {omkrets}");
            Console.WriteLine();
        }
        public void getVolym()
        {
            double höjd = 10;
            double volym = (radie*2) * höjd*pi;
            Console.WriteLine($"Volymen av cirkeln/cylindern är {volym} (när höjden är {höjd} och diameter {radie*2})");
            Console.WriteLine();
        }
    }
}

