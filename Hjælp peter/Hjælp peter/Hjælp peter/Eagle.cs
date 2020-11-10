using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_peter
{
    public class Eagle : Bird, IFly
    {
        /*We got the eagle bird in this glass and the interface i can fly is also connected to this class because eagles fly normally */
        public override string Draw()
        {
            return "I am an eagle";
        }

        public string SetAltitude(double altitude)
        {
            return $"My altitude is {altitude} and i like it";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return $"My longtitude is {longitude} and my  latitude is {latitude} fresh i would say (Eagle scream!)";
        }
    }
}
