using System;

namespace Taken
{
    public class Veiling
    {
        private decimal hoogsteBod;
        
        public void DoeBod(decimal bedrag)
        {
            if (HoogsteBod == 0)
                hoogsteBod = bedrag;
            else if (bedrag > hoogsteBod)
                hoogsteBod = bedrag;
        }
        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
        }
    }
}
