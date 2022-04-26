using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MemeGenerator.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmHelpers.Commands;
using MemeGenerator.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MemeGenerator.ViewModels;

namespace MemeGenerator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemeListViewPage : ContentPage
    {
        ObservableCollection<memeModel> obProducts;
        public MemeListViewPage()
        {
            InitializeComponent();

            FetchMemes();
        }

        private async Task FetchMemes()
        {
            var service = DependencyService.Get<IMemeWebClient>();

            var content = await service.GetString("https://api.imgflip.com/get_memes");

            var json = JObject.Parse(content);

            obProducts = new ObservableCollection<memeModel>();

            foreach ( var e in json["data"]["memes"])
            {
                try
                {
                    obProducts.Add(new memeModel
                    {
                        imageUrl = (string)e["url"],
                        memeText = (string)e["name"],
                        description = "$1099"
                    });
                }
                catch (Exception ex)
                {

                }
                //Console.WriteLine((string)e["url"]);
            }

            //Console.WriteLine(obProducts.Count);

            lstProducts.ItemsSource = obProducts;

        }

       

        private async void LstProducts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var selectedMeme = (memeModel)e.Item;

                //await DisplayAlert("You selected", selectedMeme.memeText, "Buy", "Cancel");

                await Shell.Current.GoToAsync($"{nameof(MemeEditPage)}?{nameof(MemeEditViewModel.GetData)}={selectedMeme.imageUrl}");


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
            lstProducts.SelectedItem = null;
        }
    }
}



