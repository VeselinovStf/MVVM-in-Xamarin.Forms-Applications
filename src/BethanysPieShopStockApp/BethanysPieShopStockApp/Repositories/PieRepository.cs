using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using System;
using System.Linq;

namespace BethanysPieShopStockApp.Repositories
{
    public class PieRepository
    {

        public void AddPie(Pie pie)
        {
            pie.Id = Guid.NewGuid();
            pie.ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg";

            MockDbService.Pies.Add(pie);
        }

        public void UpdatePie(Pie pie)
        {
            var oldPie = MockDbService.Pies.Where(p => p.Id == pie.Id).FirstOrDefault();
            oldPie.PieName = pie.PieName;
            oldPie.Price = pie.Price;
            oldPie.Description = pie.Description;
            oldPie.InStock = pie.InStock;
        }
    }
}
