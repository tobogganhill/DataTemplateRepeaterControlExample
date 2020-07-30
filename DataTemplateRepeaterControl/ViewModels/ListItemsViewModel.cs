using DataTemplateRepeaterControl.Models;
using MvvmHelpers; // need this for ObservableRangeCollection
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;  // need this
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTemplateRepeaterControl.ViewModels
{
    public class ListItemsViewModel : BaseViewModel
    {

        // New code for filtering credentials 

        public ObservableRangeCollection<Item> Items { get; set; }
        public ObservableRangeCollection<Item> AllItems { get; set; }
        public ObservableRangeCollection<string> FilterOptions { get; }
        public Command LoadItemsCommand { get; }

        string selectedFilter = "ALL";

        public string SelectedFilter
        {
            get => selectedFilter;
            set
            {
                if (SetProperty(ref selectedFilter, value))
                    FilterItems();
            }
        }


        public ListItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Item>();
            AllItems = new ObservableRangeCollection<Item>();


            FilterOptions = new ObservableRangeCollection<string>
            {
                "ALL",
                "EDUCATION",
                "FINANCIAL",
                "GOVERNMENT",
                "RETAIL",
                "TRANSPORTATION"

            };


            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        }

        void FilterItems()
        {
            Items.ReplaceRange(AllItems.Where(a => a.Role == SelectedFilter || SelectedFilter == "ALL"));
        }


        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                var items = await DataStore.GetItemsAsync(true);

                AllItems.ReplaceRange(items);
                FilterItems();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}