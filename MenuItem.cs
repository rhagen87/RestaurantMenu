using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private bool newItem;
        public bool NewItem
        {
            get { return newItem; }
            set { newItem = value; }
        }
    }
}
