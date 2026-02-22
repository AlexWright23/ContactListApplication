namespace ContactListApplication.Models
{
    public class AppContact
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Description { get; set; } = "";
        public string Photo { get; set; } = "";

        public string GroupKey => string.IsNullOrWhiteSpace(Name)
            ? "#"
            : Name.Trim()[0].ToString().ToUpper();
    }
}

