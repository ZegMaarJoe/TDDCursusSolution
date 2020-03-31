using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenLibrary
{
    public class Persoon
    {
        private List<string> Voornamen;

        public Persoon (List<string> voornamen)
        {
            bool isUniek = voornamen.Distinct().Count() == voornamen.Count();
            if (!isUniek)
            {
                throw new ArgumentException();
            }

            foreach (string voornaam in voornamen)
                if (voornaam == "")
                {
                    throw new ArgumentException();
                }

            if (voornamen.All(x => string.IsNullOrWhiteSpace(x)))
            {
                throw new ArgumentException();
            }

            if (voornamen.Count == 0)
            {
                throw new ArgumentException();
            }

            this.Voornamen = voornamen;
        }
        public override string ToString()
        {
            return String.Join(" ",Voornamen);
        }
    }
}
