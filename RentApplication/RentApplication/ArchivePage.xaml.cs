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
	public partial class ArchivePage : ContentPage
	{

        ObservableCollection<RentObject> listViewDS = new ObservableCollection<RentObject> {
            new RentObject() { DisplayName = "test1", type = "Buch", RentalDate = DateTime.Now.AddDays(-19) },
            new RentObject() { DisplayName = "test2", type = "Buch", RentalDate = DateTime.Now.AddDays(-19) },
            new RentObject() { DisplayName = "test3", type = "Buch", RentalDate = DateTime.Now.AddDays(-19) }
        };
        public ArchivePage ()
		{
			InitializeComponent ();
            listView.ItemsSource = listViewDS;
        }
        
    }
}