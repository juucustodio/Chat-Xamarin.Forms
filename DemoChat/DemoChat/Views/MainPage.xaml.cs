using DemoChat.ViewModels;
using Xamarin.Forms;

namespace DemoChat.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = vm = new MainPageViewModel();


            vm.ListMessages.CollectionChanged += (sender, e) =>
            {
                var target = vm.ListMessages[vm.ListMessages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };
        }
    }
}
