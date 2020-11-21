using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopStockApp.Repositories
{
    public static class PieRepository
    {
        public static IList<Pie> GetPies()
        {
            return MockDbService.Pies;
        }

        public static void AddPie(Pie pie)
        {
            pie.Id = Guid.NewGuid();
            pie.ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg";

            MockDbService.Pies.Add(pie);
        }

        public static void UpdatePie(Pie pie)
        {
            var oldPie = MockDbService.Pies.Where(p => p.Id == pie.Id).FirstOrDefault();
            oldPie.PieName = pie.PieName;
            oldPie.Price = pie.Price;
            oldPie.Description = pie.Description;
            oldPie.InStock = pie.InStock;
        }
    }
}
