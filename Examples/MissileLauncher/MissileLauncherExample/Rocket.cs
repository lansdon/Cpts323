using BuildDefender;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UsbLibrary;

namespace MissileLauncherExample
{


    public class RocketProgram
    {
        [STAThread]
        public static void Main(string []args)
        {
            bool shouldFire         = true;
            MissileLauncher missile = new MissileLauncher();

            // Blink the LED
            bool on = true;
            for (int i = 0; i < 10; i++)
            {
                missile.command_switchLED(on);
                System.Threading.Thread.Sleep(1000);
                on = !on;
            }

            double ratio = Math.PI / 180.0;            

            
            missile.command_reset();
            
            // Move the missile launcher           
            for (int i = 0; i < 360*3; i+=5)
            {
                double radians  = Convert.ToDouble(i) * ratio;
                int amount      = Convert.ToInt32(Math.Sin(radians) * (1/ratio));

                Console.WriteLine("Moving up to: {0} for {1}", amount, radians);

                if (amount >= 0)
                    missile.command_Up(amount);
                else
                    missile.command_Down(amount * -1);
                missile.command_Left(1);
            }
            

            // Fire Ze Missiles!
            if (shouldFire)
            { 
                // Fire!
                for (int i = 0; i < 4; i++)
                {
                    missile.command_Fire();
                }
            }
        }
    }

    
}

