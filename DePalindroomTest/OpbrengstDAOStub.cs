using System;
using System.Collections.Generic;
using Taken;

namespace TakenTest
{
    class OpbrengstDAOStub : IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            return 200m;
        }
    }
}
