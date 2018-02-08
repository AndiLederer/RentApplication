using RentApplication.logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RentalPage : ContentPage
	{
        ObservableCollection<RentObject> listViewDS = new ObservableCollection<RentObject>
        {

        };

        public RentalPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = listViewDS;

            listViewDS.Add(new RentObject() { DisplayName = "Buch Andrea1", RentalDate = DateTime.Now, type = "Buch" });
        }

        public void rentBook(Object sender, EventArgs args)
        {
            listViewDS.Add(new RentObject() { DisplayName = name.Text, RentalDate = DateTime.Now, type = "Buch" });
            name.Text = "";
        }
        public void rentDVD(Object sender, EventArgs args)
        {
            listViewDS.Add(new RentObject() { DisplayName = name.Text, RentalDate = DateTime.Now, type = "DVD" });
            name.Text = "";
        }
        public void rentGame(Object sender, EventArgs args)
        {
            listViewDS.Add(new RentObject() { DisplayName = name.Text, RentalDate = DateTime.Now, type = "Spiel" });
            name.Text = "";
        }
        public void OnRentEnding(Object sender, EventArgs args)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }
    }
}