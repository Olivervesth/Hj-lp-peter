using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_peter
{
    public abstract class Bird
    {
        /*This class we got the bird abstract methods so we can define what a bird does or at least some things :d*/
        public abstract string SetLocation(double longitude, double latitude);
        public abstract string Draw();
    }

    //Første udgave af appen "BirdsFlyingAroundApp" er en kæmpe succes.I version 1.2 tilføjes der 12 nye typer af fugle og hurra for at Peter havde tænkt sig godt om i forhold til at benytte OCP.

    //Fordi begge versioner af appen havde været en kæmpe succes, står man nu med version 1.3. I denne udgave skal der tilføjes endnu et dyr, nemlig pingviner. Peter skynder sig straks at oprette en Penguin klasse, men bliver så i tvivl for pingviner kan jo ikke flyve.......

    

}
