﻿
namespace ASMLEngineSdk
{
    /// <summary>
    /// Interface for controlling a missile launcher.
    /// </summary>
    public interface IMissileLauncher
    {
        /// <summary>
        /// Resets the missile launcher 
        /// </summary>
        void Reset();
        /// <summary>
        /// Moves the missile launcher by a relative amount.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="phi"></param>
        void MoveBy(double phi, double theta);
        /// <summary>
        /// Moves the missile launcher to an absolute position.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="psi"></param>
        void MoveTo(double phi, double theta);
        /// <summary>
        /// Fires a missile.
        /// </summary>
        void Fire();
        /// <summary>
        /// Gets the phi position of the missile launcher.
        /// </summary>
        double Phi { get; }
        /// <summary>
        /// Gets the Theta position of the missile launcher.
        /// </summary>
        double Theta { get; }
    }
}
