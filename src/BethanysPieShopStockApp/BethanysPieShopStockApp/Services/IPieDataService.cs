using BethanysPieShopStockApp.Models;
using System.Collections.Generic;

namespace BethanysPieShopStockApp.Services
{
    public interface IPieDataService
    {
        void AddPie(Pie pie);
        IList<Pie> GetPies();
        void UpdatePie(Pie pie);
    }
}