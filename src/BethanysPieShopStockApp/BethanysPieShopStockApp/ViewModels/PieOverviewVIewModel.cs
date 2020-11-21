using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using BethanysPieShopStockApp.Utility;
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

            MessagingCenter.Subscribe<PieDetailsViewModel, Pie>
                (this, MessageNames.PieChangedMessage, OnPieChange);

            //MessagingCenter.Subscribe<PieDetailsViewModel>
            //   (this, MessageNames.PieChangedMessage, ..... );
        }

        private void OnPieChange(PieDetailsViewModel arg1, Pie arg2)
        {
            Pies = new ObservableCollection<Pie>(App.PieDataService.GetPies());
        }

        private void OnPieSelected(Pie pie)
        {
            App.NavigationService.NavigateTo(ViewNames.PieDetailView, pie);
        }

        private void OnAddNewPie()
        {
            App.NavigationService.NavigateTo(ViewNames.PieDetailView);
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
