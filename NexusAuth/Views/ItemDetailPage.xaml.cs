using NexusAuth.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NexusAuth.Views
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