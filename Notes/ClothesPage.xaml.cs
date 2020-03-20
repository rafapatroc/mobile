using System;
using Xamarin.Forms;
using Clothes.Models;

namespace Clothes
{
    public partial class ClothesPage : ContentPage
    {
        public ClothesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetClothesAsync();
        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ClotheEntryPage
                {
                    BindingContext = e.SelectedItem as Clothe
                });
            }
        }

        async void OnClotheAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClotheEntryPage
            {
                BindingContext = new Clothe()
            });
        }
    }
}
