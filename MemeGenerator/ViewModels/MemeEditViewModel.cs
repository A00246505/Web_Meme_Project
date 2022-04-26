using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MemeGenerator.ViewModels
{
    [QueryProperty(nameof(GetData), nameof(GetData))]
    public class MemeEditViewModel: BaseViewModel
    {
        private string data;
        private string url;

        public MemeEditViewModel()
        {
            Title = "Blah";
            ImageUrl = "https://i.imgflip.com/30b1gx.jpg";
        }

        public string ImageUrl
        {
            get => url;
            set => SetProperty(ref url, value);
        }

        public string GetData
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                LoadImage(value);
            }
        }

        public void LoadImage(string value)
        {
            try
            {
                ImageUrl = value;
                Console.WriteLine("Image url is "+ImageUrl);
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

    }
}
