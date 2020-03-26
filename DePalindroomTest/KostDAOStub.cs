using System;
using System.Collections.Generic;
using Taken;

namespace TakenTest
{
    class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 169m;
        }
    }
}
