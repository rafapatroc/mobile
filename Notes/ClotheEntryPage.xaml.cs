using System;
using Xamarin.Forms;
using Clothes.Models;

namespace Clothes
{
    public partial class ClotheEntryPage : ContentPage
    {
        public ClotheEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var clothe = (Clothe)BindingContext;
            clothe.Date = DateTime.UtcNow;
            clothe.Margin = (Convert.ToInt32(clothe.PaidPrice) * 2).ToString();
            await App.Database.SaveClotheAsync(clothe);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var clothe = (Clothe)BindingContext;
            await App.Database.DeleteClotheAsync(clothe);
            await Navigation.PopAsync();
        }
    }
}
