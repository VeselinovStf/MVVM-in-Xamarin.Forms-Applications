using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Utility;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailsViewModel : BaseViewModel
    {
        public ICommand SavePieCommand { get; }

        public PieDetailsViewModel()
        {
            SelectedPie = new Pie();


            SavePieCommand = new Command(OnSavePie);
        }

        private void OnSavePie()
        {
            if (SelectedPie.Id == Guid.Empty)
            {
                App.PieDataService.AddPie(SelectedPie);
            }
            else
            {
                App.PieDataService.UpdatePie(SelectedPie);
            }

            MessagingCenter.Send(this, MessageNames.PieChangedMessage, SelectedPie);
            //MessagingCenter.Send(this, MessageNames.PieChangedMessage);

            App.NavigationService.GoBack();
        }

        private Pie _selectedPie;

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
