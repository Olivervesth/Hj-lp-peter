using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_peter
{
    public class Penguin : Bird
    {
        /*This class the penguin owns here we tell information about the bird that cant fly.*/
        public override string SetLocation(double longitude, double latitude)
        {
            return $"My Location is longtitude {longitude} latitude {latitude}";
        }

        public override string Draw()
        {
            return "Im a penguin pip pip i do not fly sorry";
        }
    }
}
