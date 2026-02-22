using ContactListApplication.Models;

namespace ContactListApplication.Pages
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(AppContact contact)
        {
            InitializeComponent();
            BindingContext = contact;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}