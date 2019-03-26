using System;

namespace Flashlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flashlight flashlight = new Flashlight();
            flashlight.TurnOn();
            flashlight.TurnOff();
            Console.ReadLine();
        }
    }
}
