using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment8Sln.DataSQL
{
    class ToolItemView
    {
        public ObservableCollection<Tools> Tools { get; set; }

        //public ObservableCollection<FoodItems> CartProducts { get; set; }

        public Tools SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public ToolItemView(INavigation navigation)
        {
            Tools = new ObservableCollection<Tools>
    {
        new Tools
        {
            ToolImage = "combs.jpg",
            ToolName = "Revlon",
            ToolDescription = "Thick & Curly Comb Set",
            ToolPrice = 5.99,
            ToolQuantity = 50
        },

        new Tools
        {
            ToolImage = "curlingwand.jpg",
            ToolName = "L'ange",
            ToolDescription = "Hair Le Perlé Titanium Bubble Hair Wand",
            ToolPrice = 52.99,
            ToolQuantity = 50
        },

        new Tools
        {
            ToolImage = "hairdryerflatiron.jpg",
            ToolName = "CHI Haircare",            
            ToolDescription = "The Sparkler V.I.P. Hairdryer & Flat Iron Set",
            ToolPrice = 279.98,
            ToolQuantity = 50
        },

    };

            //CartProducts = new ObservableCollection<FoodItems> { };

            ProductClick = new Command<Tools>(executeProductClickCommand);

            //CartProductClick = new Command<FoodItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(Tools item)
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
