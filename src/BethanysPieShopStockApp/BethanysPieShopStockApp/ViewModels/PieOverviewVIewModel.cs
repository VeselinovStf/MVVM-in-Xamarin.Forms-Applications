using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public ICommand LoadPiesListCommand { get; }
        public ICommand AddNewPieCommand { get; }
        public ICommand PieSelectedCommand { get; }

        public PieOverviewViewModel()
        {
            LoadPiesListCommand = new Command(OnLoadPiesList);
            AddNewPieCommand = new Command(OnAddNewPie);
            PieSelectedCommand = new Command<Pie>(OnPieSelected);
        }

        private void OnPieSelected(Pie obj)
        {
            //TODO
        }

        private void OnAddNewPie()
        {
            //TODO
        }

        private void OnLoadPiesList()
        {
            Pies = new ObservableCollection<Pie>(App.PieDataService.GetPies());
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
