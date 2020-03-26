using System;
using System.Collections.Generic;
using System.Text;

namespace Taken
{
    public class WinstService
    {   
        // dependencies
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IKostDAO kostDAO;

        
        // Constructor
        public WinstService(IOpbrengstDAO opbrengstDAO, IKostDAO kostDAO)
        { 
            this.opbrengstDAO = opbrengstDAO;
            this.kostDAO = kostDAO;
        }

        // properties
        public Decimal Winst
        {
            get
            {
                return opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
            }
        }

    }
}
