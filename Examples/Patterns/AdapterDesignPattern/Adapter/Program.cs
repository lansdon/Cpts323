using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();
            controller.Launcher   = new MissileLauncherAdapter();
            controller.RunProgram();
        }
    }
    /// <summary>
    /// Client
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Runs the missile launcher 
        /// </summary>
        public void RunProgram()
        {
            Launcher.FireMissile(0, 5);
        }
        /// <summary>
        /// Reference to a missile launcher.
        /// </summary>
        public IMissileLauncher Launcher
        {
            get;
            set;
        }
    }


    /// <summary>
    /// Target 
    /// </summary>
    public interface IMissileLauncher
    {
        void FireMissile(double x, double y);
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class MissileLauncherAdapter : IMissileLauncher
    {
        AForeignMissileLauncher m_launcher;

        public MissileLauncherAdapter()
        {
            m_launcher = new AForeignMissileLauncher();
        }

        /// <summary>
        /// This is the implementation of the request
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void FireMissile(double x, double y)
        {
            // We know how to correctly call the class that does what we want.  
            // So we provide the interface to just send x, y and then provide 0 for z.
            m_launcher.FireZeMissile(x, y, 0);   
        }
    }

    /// <summary>
    /// Adaptee
    /// </summary>
    public class AForeignMissileLauncher
    {
        /// <summary>
        /// Fires ze missiles
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void FireZeMissile(double x, double y, double z)
        {
            Console.WriteLine("Fire ze missiles at ! {0}, {1}, {2}", x, y, z);
        }
    }
}
