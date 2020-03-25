using System;
using System.Linq;

namespace TDDCursusLibrary
{
    public class Statistiek
    {
        public static decimal Gemiddelde(decimal[] getallen)
        {
            //  throw new NotImplementedException();
            if (getallen == null)
            {
                throw new ArgumentNullException();
            }
            if (getallen.Length == 0)
            {
                throw new ArgumentException();
            }

            return getallen.Average();
        }
    }
}
