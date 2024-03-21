using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;
using Assignment8Sln.DataSQL;
//using ThreadNetwork;

namespace Assignment8Sln.ShoppingservicesDatabase
{
    public class Shoppingservices
    {
        public SQLiteConnection _dbconnection;

        public string GetDatabasePath()
        {
            string filename = "AppDatabase.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return pathToDb + filename;

        }


        public Shoppingservices()
        {
            GetDatabasePath();
            _dbconnection = new SQLiteConnection(GetDatabasePath());

            _dbconnection.CreateTable<Profile>();
            _dbconnection.CreateTable<Products>();
            _dbconnection.CreateTable<Tools>();


            SeedDatabase();
        }

        public void SeedClient()
        {

            if (_dbconnection.Table<Profile>().Count() == 0)

            {
                Profile profile = new Profile()
                {
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    Bio = ""


                };
                _dbconnection.Insert(profile);
            }
        }

        public void SeedDatabase()
        {
            if (_dbconnection.Table<Products>().Count() == 0)
            {

                Products products = new Products()
                {
                    ProductImage = "japanandhoneyherb.jpg",
                    ProductName = "Japan & Honey Herb",
                    ProductDescription = "Shampoo Conditioner Botanical Essence Scalp Oil Control",
                    ProductQuantity = 50,
                    ProductPrice = 29.99
                };
                _dbconnection.Insert(products);

                products = new Products()
                {
                    ProductImage = "foxylocks",
                    ProductName = "Foxy Locks",
                    ProductDescription = "Luxury Duo Shampoo + Conditioner - Infused with Argan Oil",
                    ProductQuantity = 50,
                    ProductPrice = 12.00
                };
                _dbconnection.Insert(products);

                products = new Products()
                {
                    ProductImage = "oribe.jpg",
                    ProductName = "Oribe",
                    ProductDescription = "Shampoo & Conditioner for Moisture & Control",
                    ProductQuantity = 50,
                    ProductPrice = 95.99

                };


                _dbconnection.Insert(products);
            }

            if (_dbconnection.Table<Tools>().Count() == 0)
            {

                Tools tools = new Tools()
                {
                    ToolImage = "combs.jpg",
                    ToolName = "Revlon",
                    ToolDescription = "Thick & Curly Comb Set",
                    ToolQuantity = 50,
                    ToolPrice = 5.99
                };
                _dbconnection.Insert(tools);

                tools = new Tools()
                {
                    ToolImage = "curlingwand.jpg",
                    ToolName = "L'ange Hair",
                    ToolDescription = "Le Perlé Titanium Bubble Hair Wand",
                    ToolQuantity = 50,
                    ToolPrice = 52.99
                };
                _dbconnection.Insert(tools);

                tools = new Tools()
                {
                    ToolImage = "hairdryerflatiron.jpg",
                    ToolName = "CHI Haircare",
                    ToolDescription = "The Sparkler V.I.P. Hairdryer & Flatiron Set",
                    ToolQuantity = 50,
                    ToolPrice = 279.98

                };


                _dbconnection.Insert(tools);
            }

            public void UpdateProfile(Profile profile)
            {

                SeedClient();

                _dbconnection.Update(profile);
            }

            public void SaveProfile(Profile profile)
            {

                _dbconnection.Insert(profile);

            }

            public List<Products> GetProducts()
            {
                return _dbconnection.Table<Products>().ToList();
            }
        }

        private Profile GetProfileId(int id)
        {
            Profile profile = _dbconnection.Table<Profile>().Where(x => x.ProfileId == id).FirstOrDefault();

            if (profile == null)
            {
                _dbconnection.GetChildren(profile, true);
            }
            return profile;
        }

    }
}

    




   



