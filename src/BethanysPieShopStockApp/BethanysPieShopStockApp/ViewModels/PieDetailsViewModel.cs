using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Utility;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailsViewModel : BaseViewModel
    {
        private Pie _selectedPie;
        private readonly IPieDataService _pieDataService;
        private readonly INavigationService _navigationService;

        public ICommand SavePieCommand { get; }

        public PieDetailsViewModel(
            IPieDataService pieDataService,
            INavigationService navigationService)
        {
            _pieDataService = pieDataService;
            _navigationService = navigationService;

            SelectedPie = new Pie();


            SavePieCommand = new Command(OnSavePie);

        }

        private void OnSavePie()
        {
            if (SelectedPie.Id == Guid.Empty)
            {
                _pieDataService.AddPie(SelectedPie);
            }
            else
            {
                _pieDataService.UpdatePie(SelectedPie);
            }

            MessagingCenter.Send(this, MessageNames.PieChangedMessage, SelectedPie);
            //MessagingCenter.Send(this, MessageNames.PieChangedMessage);

            _navigationService.GoBack();
        }

        public Pie SelectedPie
        {
            get { return _selectedPie; }
            set 
            { 
                _selectedPie = value;
                OnPropertyChange(); 
            }
        }

        public override void Initialize(object parameter)
        {
            if (parameter == null)
            {
                SelectedPie = new Pie();
            }
            else
            {
                SelectedPie = parameter as Pie;
            }
        }

    }
}
