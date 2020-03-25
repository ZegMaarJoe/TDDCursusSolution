using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class LandService
    {
        // Verwijzing naar Interface
        private readonly ILandDAO landDAO;
        // Constructor
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal VindVerhoudingOppTotOppVanAlleLanden(string landcode)
        {
            var land = landDAO.Read(landcode);
            var oppvervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppvervlakteAlleLanden;
        }
    }
}
