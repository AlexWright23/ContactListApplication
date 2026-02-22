using ContactListApplication.Data;
using ContactListApplication.Models;

namespace ContactListApplication.Pages
{
    public partial class ContactsPage : ContentPage
    {
        public IList<ContactGroup> ContactGroups { get; set; }

        public ContactsPage()
        {
            InitializeComponent();
            ContactGroups = ContactRepository.GetGroupedContacts();
            BindingContext = this;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection == null || e.CurrentSelection.Count == 0)
                return;

            var selected = e.CurrentSelection[0] as AppContact;
            if (selected == null)
                return;

            ((CollectionView)sender).SelectedItem = null;

            await Navigation.PushAsync(new ContactDetailsPage(selected));
        }
    }
}