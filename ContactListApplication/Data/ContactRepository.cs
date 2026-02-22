using System.Collections.ObjectModel;
using ContactListApplication.Models;

namespace ContactListApplication.Data
{
    public static class ContactRepository
    {
        public static ObservableCollection<ContactGroup> GetGroupedContacts()
        {

            var contacts = new List<AppContact>
            {
                // A
                new AppContact { Name="A+ Attendance",       Email="attendance.plus@example.com",    Phone="(513) 555-0101", Photo="pic1.png", Description="Never late. Already read the syllabus twice." },
                new AppContact { Name="Alexa Not Amazon",    Email="alexa.notamazon@example.com",   Phone="(513) 555-0102", Photo="pic2.png", Description="Gets asked to turn on lights. Does not control smart homes." },
                new AppContact { Name="Async Andy",          Email="async.andy@example.com",        Phone="(513) 555-0103", Photo="pic3.png", Description="Says 'I’ll do it later' and still delivers on time." },

                // B
                new AppContact { Name="Budget Brenda",       Email="budget.brenda@example.com",     Phone="(513) 555-0104", Photo="pic4.png", Description="Turns 'we’re out of money' into 'we’re under budget'." },
                new AppContact { Name="Bug Hunter Ben",      Email="bughunter.ben@example.com",     Phone="(513) 555-0105", Photo="pic1.png", Description="Finds bugs by opening the app and existing." },
                new AppContact { Name="Breakroom Boba",      Email="breakroom.boba@example.com",    Phone="(513) 555-0106", Photo="pic2.png", Description="Knows the best snacks. Has strong opinions on tea." },

                // C
                new AppContact { Name="Ctrl+C Carl",         Email="ctrlc.carl@example.com",        Phone="(513) 555-0107", Photo="pic3.png", Description="Copies best practices. Pastes productivity everywhere." },
                new AppContact { Name="Coffee Chloe",        Email="coffee.chloe@example.com",      Phone="(513) 555-0108", Photo="pic4.png", Description="Powered by caffeine and good documentation." },
                new AppContact { Name="Calendar Casey",      Email="calendar.casey@example.com",    Phone="(513) 555-0109", Photo="pic1.png", Description="If it’s not on the calendar… it didn’t happen." },

                // D
                new AppContact { Name="Deadline Dylan",      Email="deadline.dylan@example.com",    Phone="(513) 555-0110", Photo="pic2.png", Description="Thrives under pressure (pressure = due in 3 minutes)." },
                new AppContact { Name="Debug Daisy",         Email="debug.daisy@example.com",       Phone="(513) 555-0111", Photo="pic3.png", Description="Fixes issues by staring at the screen dramatically." },
                new AppContact { Name="Documentation Derek", Email="docs.derek@example.com",        Phone="(513) 555-0112", Photo="pic4.png", Description="Writes docs so clear it feels like magic." },

                // E
                new AppContact { Name="Email Ethan",         Email="email.ethan@example.com",       Phone="(513) 555-0113", Photo="pic1.png", Description="Replies fast. Always ends with 'Thanks!'" },
                new AppContact { Name="Error 404 Emma",      Email="error404.emma@example.com",     Phone="(513) 555-0114", Photo="pic2.png", Description="Sometimes unavailable, always iconic. Returns eventually." },
                new AppContact { Name="Extra Credit Elijah", Email="extracredit.elijah@example.com",Phone="(513) 555-0115", Photo="pic3.png", Description="Already did the optional part. Twice. For fun." },
            };

            var grouped = contacts
                .OrderBy(c => c.Name)
                .GroupBy(c => c.GroupKey)
                .OrderBy(g => g.Key)
                .Select(g => new ContactGroup(g.Key, g));

            return new ObservableCollection<ContactGroup>(grouped);
        }
    }
}