using System;

namespace BethanysPieShopStockApp.Models
{
    public class Pie
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
            set { _id = value; }
        }
     
        public string PieName
        {
            get { return _pieName; }
            set { _pieName = value; }
        }
       
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
       
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
       
        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }
       
        public bool InStock
        {
            get { return _inStock; }
            set { _inStock = value; }
        }


    }
}
