using System;

namespace FlashlightGOF_StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlashlight myFlashlight = new Flashlight();

            var choice = 'x';


            while (char.ToUpper(choice) != 'Q')
            {
                Console.WriteLine("Enter event : ");
                choice = Console.ReadKey().KeyChar;

                switch (char.ToUpper(choice))
                {
                    case 'X':
                        myFlashlight.Power();
                        break;

                    case 'Y':
                        myFlashlight.Mode();
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
