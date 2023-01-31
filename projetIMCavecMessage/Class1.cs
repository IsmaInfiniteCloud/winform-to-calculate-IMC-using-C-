using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetIMCavecMessage
{
    internal class Util
    {
        internal static double AfficherResultatIMC(double poids, object taille)
        {
            return poids / Math.Pow((double)taille, 2);
        }
        internal static string AfficherMessageIMC( double resultat)
        {
            string message = "";
            return message;
        }

    }
}
