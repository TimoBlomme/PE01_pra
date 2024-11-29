using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Wine.Keeper.Wpf.Class_Library
{
    public static class WineSeeder
    {
        public static WineCollection Seed()
        {
            var wines = new WineCollection
            {
                new WineBox("Cabernet Sauvignon", 12, 24, DateTime.Now.AddMonths(-6), 6),
                new WineBox("Merlot", 8, 18, DateTime.Now.AddMonths(-3), 12)
            };
            return wines;
        }
    }


}
