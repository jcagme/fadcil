using System;

namespace OM
{
    public class Payment
    {
        public Guid Id { get; set; }

        public Guid AdId { get; set; }

        public int Amount { get; set; }

        public DateTime ProcessedDate { get; set; }
    }
}
