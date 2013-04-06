using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    /// <summary>
    /// Interface example
    /// </summary>
    public interface IMissileLauncher
    {
        void FireMissile();
        void Turn(double angle);
        void TurnUp(double angle);
    }

    /// <summary>
    /// Dummy class for pretending that the below concrete class realizes the IMissileLauncher interface.
    /// </summary>
    public class DreamCheekyMissileLauncher: IMissileLauncher
    {

        public void FireMissile()
        {
            throw new NotImplementedException();
        }

        public void Turn(double angle)
        {
            throw new NotImplementedException();
        }

        public void TurnUp(double angle)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
