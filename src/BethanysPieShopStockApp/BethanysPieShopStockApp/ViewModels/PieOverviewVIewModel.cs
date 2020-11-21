using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using System;
using System.Collections.ObjectModel;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public PieOverviewViewModel()
        {           
            Initialize();
        }

        private void Initialize()
        {
            Pies = new ObservableCollection<Pie>(PieRepository.GetPies());
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
