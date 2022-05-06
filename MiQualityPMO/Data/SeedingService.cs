using MiQualityPMO.Models;
using System.Linq;

namespace MiQualityPMO.Data
{
    public class SeedingService
    {
        private MiQualityPMOContext _context;

        public SeedingService(MiQualityPMOContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Mqaa.Any() ||
                _context.Copq.Any() ||
                _context.Btp.Any())
            {
                return;
            }


            Mqaa m1 = new Mqaa(1, "Coopershoes PC", "FY22", "Q3", 84.0, 0);
            Mqaa m2 = new Mqaa(2, "Coopershoes MN", "FY22", "Q3", 90.0, 0);
            Mqaa m3 = new Mqaa(3, "Coopershoes LF", "FY22", "Q3", 93.0, 20);
            Mqaa m4 = new Mqaa(4, "Dass BD", "FY22", "Q3", 97.21, 35);
            Mqaa m5 = new Mqaa(5, "Aniger BP", "FY22", "Q3", 95.8, 30);

            Copq c1 = new Copq(1,"Coopershoes PC","FY22","Q3",36.17,0.05,16);
            Copq c2 = new Copq(2, "Coopershoes MN", "FY22", "Q3", 36.17, 0.02, 20);
            Copq c3 = new Copq(3, "Coopershoes LF", "FY22", "Q3", 36.17, 0.03, 20);
            Copq c4 = new Copq(4, "Dass BD", "FY22", "Q3", 36.72, 0.01, 20);
            Copq c5 = new Copq(5, "Aniger BP", "FY22", "Q3", 41.21, 0.01, 20);

            Btp b1 = new Btp(1, "Coopershoes PC", "FY22", "Q3", 97.2, 30);
            Btp b2 = new Btp(2, "Coopershoes MN", "FY22", "Q3", 95.8, 20);
            Btp b3 = new Btp(3, "Coopershoes LF", "FY22", "Q3", 93.7, 20);
            Btp b4 = new Btp(4, "Dass BD", "FY22", "Q3", 96.5, 20);
            Btp b5 = new Btp(5, "Aniger BP", "FY22", "Q3", 94, 20);

            _context.Mqaa.AddRange(m1,m2,m3,m4,m5);
            _context.Copq.AddRange(c1,c2,c3,c4,c5);
            _context.Btp.AddRange(b1,b2,b3,b4,b5);

            _context.SaveChanges();
        }


    }
}
