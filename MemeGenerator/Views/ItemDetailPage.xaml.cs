using System.ComponentModel;
using Xamarin.Forms;
using MemeGenerator.ViewModels;

namespace MemeGenerator.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
