using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateRepeaterControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        int clickTotal;

        public ScanPage()
        {
            InitializeComponent();
        }


        async void OnImageButtonClicked(object sender, EventArgs e)
        {

            //clickTotal += 1;
            //label.Text = $"{clickTotal} ImageButton click{(clickTotal == 1 ? "" : "s")}";

            string action = await DisplayActionSheet("OPTIONS", "CANCEL", null, "BACKUP", "DELEGATION", "SYNCHRONIZE", "LEGAL", "VERSION", "ABOUT", "CONTACT");
            Console.WriteLine("Action: " + action);



        }



        public void OnTapped(object sender, System.EventArgs e)
        {
            var isShowing = !Present.IsVisible;

            // Do a quick little animation to transition things
            if (isShowing)
            {
                // If it was originally hidden then now we're showing it

                Present.BackgroundColor = Color.FromHex("#CCCCCC");
            }
            else
            {
                // If it was originally showing then now we're hiding it

                Present.BackgroundColor = Color.FromHex("#DDDDDD");
            }
        }
    }
}

