using System.Collections.ObjectModel;

namespace ContactListApplication.Models
{
    public class ContactGroup : ObservableCollection<AppContact>
    {
        public string Key { get; }

        public ContactGroup(string key, IEnumerable<AppContact> contacts) : base(contacts)
        {
            Key = key;
        }
    }
}
