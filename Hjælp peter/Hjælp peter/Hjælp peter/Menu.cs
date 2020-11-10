using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_peter
{
    class Menu
    {
        /*This class is only for the menu for the user to test the birds*/
        /*This class is very hardcoded and is not very good but now you can improve your skills peter :D you can se that this works now you just need to make it better dont ask me to help you again please thanks bye*/
        public void start()
        {
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            string altitude = "";
            double longtitude = 0;
            double latitude = 0;
            string location = "";
            string draw = "";
            int choice = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Pick a bird\n1.Eagle\n2.Penguin");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            draw = eagle.Draw();
                            Console.Write("Set the altitude of the Eagle: ");
                            altitude = eagle.SetAltitude(double.Parse(Console.ReadLine()));
                            Console.WriteLine("Enter longtitude: ");
                            longtitude = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter latitude: ");
                            latitude = double.Parse(Console.ReadLine());
                            location = eagle.SetLocation(longtitude, latitude);
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            draw = penguin.Draw();
                            Console.WriteLine("Enter longtitude: ");
                            longtitude = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter latitude: ");
                            latitude = double.Parse(Console.ReadLine());
                            location = penguin.SetLocation(longtitude, latitude);
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine($"something went wrong{e}");
                }
                Console.WriteLine(draw + "\n" + location);
                if (choice == 1)
                {
                    Console.WriteLine(altitude);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
