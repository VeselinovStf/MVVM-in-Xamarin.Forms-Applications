using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BethanysPieShopStockApp.Models
{
    public class Pie : INotifyPropertyChanged
    {
        private Guid _id;
        private string _pieName;
        private string _description;
        private double _price;
        private string _imageUrl;
        private bool _inStock;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; RaisePropertyChange(); }
        }
     
        public string PieName
        {
            get { return _pieName; }
            set { _pieName = value; RaisePropertyChange(); }
        }
       
        public string Description
        {
            get { return _description; }
            set { _description = value; RaisePropertyChange(); }
        }
       
        public double Price
        {
            get { return _price; }
            set { _price = value; RaisePropertyChange(); }
        }
       
        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; RaisePropertyChange(); }
        }
       
        public bool InStock
        {
            get { return _inStock; }
            set { _inStock = value; RaisePropertyChange(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
