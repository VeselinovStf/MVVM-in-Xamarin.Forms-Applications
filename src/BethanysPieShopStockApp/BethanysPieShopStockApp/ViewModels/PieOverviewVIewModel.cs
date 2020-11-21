using BethanysPieShopStockApp.Models;
using System.Collections.ObjectModel;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewVIewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public PieOverviewVIewModel()
        {
            Pies = new ObservableCollection<Pie>();
        }
       
        public ObservableCollection<Pie> Pies
        {
            get { return _pies; }
            set 
            {
                _pies = value;
                OnPropertyChange();
            }
        }

    }
}
