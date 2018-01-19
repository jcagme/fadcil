using System;

namespace OM
{
    public class User
    {
        public Guid UserId { get; set; }
        
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string ZipCode { get; set; }

        public string PreferredContact { get; set; }

        public string Token { get; set; }
    }
}
