using DataTemplateRepeaterControl.ViewModels;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace DataTemplateRepeaterControl.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class ListViewItemsPage : ContentPage
    {
        ListItemsViewModel viewModel;


        public ListViewItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ListItemsViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel?.Items == null || !viewModel.Items.Any())
            {
                viewModel.LoadItemsCommand.Execute(null);
            }
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {


                await DisplayAlert("Alert", e.SelectedItem.ToString(), "OK");

            }
        }

    }
}