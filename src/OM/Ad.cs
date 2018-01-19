using System;

namespace OM
{
    public class Ad
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public uint PackageId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public uint CategoryId { get; set; }

        public string Url { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime PostedDate { get; set; }

        public uint StatusId { get; set; }
    }
}
