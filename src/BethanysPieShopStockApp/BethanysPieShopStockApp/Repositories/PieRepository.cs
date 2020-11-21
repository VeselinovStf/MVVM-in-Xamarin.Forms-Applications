using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopStockApp.Repositories
{
    public class PieRepository
    {
        private readonly MockDb _mockDb;

        public PieRepository(MockDb mockDb)
        {
            _mockDb = mockDb;
        }

        public IList<Pie> GetPies()
        {
            return _mockDb.Pies;
        }

        public void AddPie(Pie pie)
        {
            pie.Id = Guid.NewGuid();
            pie.ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg";

            _mockDb.Pies.Add(pie);
        }

        public void UpdatePie(Pie pie)
        {
            var oldPie = _mockDb.Pies.Where(p => p.Id == pie.Id).FirstOrDefault();
            oldPie.PieName = pie.PieName;
            oldPie.Price = pie.Price;
            oldPie.Description = pie.Description;
            oldPie.InStock = pie.InStock;
        }
    }
}
