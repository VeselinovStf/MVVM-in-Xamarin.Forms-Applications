using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using BethanysPieShopStockApp.Services;
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
        private readonly IPieDataService _pieDataService;
        private readonly INavigationService _navigationService;

        public ICommand LoadPiesListCommand { get; }
        public ICommand AddNewPieCommand { get; }
        public ICommand PieSelectedCommand { get; }

        public PieOverviewViewModel(
            IPieDataService pieDataService, 
            INavigationService navigationService)
        {
            _pieDataService = pieDataService;
            _navigationService = navigationService;

            LoadPiesListCommand = new Command(OnLoadPiesList);
            AddNewPieCommand = new Command(OnAddNewPie);
            PieSelectedCommand = new Command<Pie>(OnPieSelected);

            MessagingCenter.Subscribe<PieDetailsViewModel, Pie>
                (this, MessageNames.PieChangedMessage, OnPieChange);

            Pies = new ObservableCollection<Pie>();

            //MessagingCenter.Subscribe<PieDetailsViewModel>
            //   (this, MessageNames.PieChangedMessage, ..... );
        }

        private void OnPieChange(PieDetailsViewModel arg1, Pie arg2)
        {
            Pies = new ObservableCollection<Pie>(_pieDataService.GetPies());
        }

        private void OnPieSelected(Pie pie)
        {
            _navigationService.NavigateTo(ViewNames.PieDetailView, pie);
        }

        private void OnAddNewPie()
        {
            _navigationService.NavigateTo(ViewNames.PieDetailView);
        }

        public void OnLoadPiesList()
        {
            Pies = new ObservableCollection<Pie>(_pieDataService.GetPies());
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
