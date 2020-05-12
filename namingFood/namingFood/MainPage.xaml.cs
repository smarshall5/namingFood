using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace namingFood
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string name;
        public string food;
        
        ObservableCollection<foodItem> itemList;

      //  ObservableCollection<String> listString;
        public MainPage()
        {
            InitializeComponent();
            itemList = new ObservableCollection<foodItem>();
        }

        void showNamer(object sender, EventArgs args)
        {
            nameLabel.IsVisible = true;
            foodLabel.IsVisible = false;
            newFood.IsVisible = false;
            newName.IsVisible = true;
        }
        void showFooder(object sender, EventArgs args)
        {
            foodLabel.IsVisible = true;
            nameLabel.IsVisible = false;
            newFood.IsVisible = true;
            newName.IsVisible = false;
        }
        void addName(object sender, EventArgs e)
        {
            newName.Text = name;


        }
        void addFood(object sender, EventArgs e)
        {
            newFood.Text = food;


        }

       private void OnSaveClicked(object sender, EventArgs e)
        {
            if (name != null && food != null)
            {
                string foodName = name + " Likes " + food;

                var foodItem = new foodItem
                {
                    nameItem = name,
                    fooditem = food
                };
            //    listString.Add(foodName);
                itemList.Add(foodItem);
            }
            else
            {
                name = "This is not a person";
                food = "Taco is not a food";
                string foodName = name + " Likes " + food;
                var foodItem = new foodItem
                {
                    nameItem = name,
                    fooditem = food
                   
                };
                itemList.Add(foodItem);
               // listString.Add(foodName);
            }
            listView.ItemsSource = itemList;
            
            }

    }


}






