
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateRepeaterControl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        //int count = 0;
        async void Button_Clicked(object sender, System.EventArgs e)
        {
            //count++;
            //((Button)sender).Text = $"You clicked {count} times.";
            ((Button)sender).Text = "Clicked";
            await Navigation.PushAsync(new ListViewItemsPage());

        }

    }
}


