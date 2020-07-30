using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateRepeaterControl.Views.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ItemACell : ViewCell
    {
        public ItemACell()
        {
            InitializeComponent();
        }

        public void Handle_Tapped(object sender, System.EventArgs e)
        {
            var isShowing = !RowDesc.IsVisible;

            // Do a quick little animation to transition things
            if (isShowing)
            {
                // If it was originally hidden then now we're showing it
                RowDesc.IsVisible = true;
                RedLine.IsVisible = true;
                CredFrame.BackgroundColor = Color.FromHex("#E9F1FC");



            }
            else
            {
                // If it was originally showing then now we're hiding it

                RowDesc.IsVisible = false;
                RedLine.IsVisible = false;
                CredFrame.BackgroundColor = Color.FromHex("#FFFFFF");
            }
        }

    }
}
