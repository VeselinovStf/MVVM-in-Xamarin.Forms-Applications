using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShopStockApp.Services
{
    public class PieDataService : IPieDataService
    {
        private readonly PieRepository _pieRepository;

        public PieDataService(PieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IList<Pie> GetPies()
        {
            return _pieRepository.GetPies();
        }

        public void AddPie(Pie pie)
        {
            if (pie != null)
            {
                _pieRepository.AddPie(pie);
            }
        }

        public void UpdatePie(Pie pie)
        {
            var oldPie = _pieRepository.GetPies().Where(p => p.Id == pie.Id).FirstOrDefault();
            oldPie.PieName = pie.PieName;
            oldPie.Price = pie.Price;
            oldPie.Description = pie.Description;
            oldPie.InStock = pie.InStock;

            _pieRepository.UpdatePie(oldPie);
        }
    }
}
