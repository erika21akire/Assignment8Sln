using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment8Sln.DataSQL
{
    class ProductItemView
    {
        public ObservableCollection<Products> Products { get; set; }

        //public ObservableCollection<FoodItems> CartProducts { get; set; }

        public Products SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public ProductItemView(INavigation navigation)
        {
            Products = new ObservableCollection<Products>
    {
        new Products
        {
            ProductImage = "japanandhoneyherb.jpg",
            ProductName = "Japan & Honey Herb",
            ProductDescription = "Smooth Shampoo & Conditioner Botanical Essence Scalp Treatment Oil Control 250ml",
            ProductPrice = 29.99,
            ProductQuantity = 50
        },

        new Products
        {
            ProductImage = "foxylocks",
            ProductName = "Foxy Locks",
            ProductDescription = "Luxury Duo Shampoo & Conditioner infused with Argan Oil 500ml",
            ProductPrice = 288.89,
            ProductQuantity = 50
        },

        new Products
        {
            ProductImage = "oribe.jpg",
            ProductName = "Oribe",
            ProductDescription = "Shampoo & Coditioner for moisture and control",
            ProductPrice = 995.55,
            ProductQuantity = 50
        },

    };

            //CartProducts = new ObservableCollection<FoodItems> { };

            ProductClick = new Command<Products>(executeProductClickCommand);

            //CartProductClick = new Command<FoodItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(Products item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            //await navigation.PushModalAsync(new (this));
        }

        //async void executeCartProductClickCommand(FoodItems item)
        //{
        //    this.CartProducts.Add(this.SelectedProduct);
        //    //await navigation.PushModalAsync(new CartPage(this));
        //}
    }
}
