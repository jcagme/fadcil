using System;

namespace OM
{
    public class Image
    {
        public Guid Id { get; set; }

        public Guid AdId { get; set; }

        public string Url { get; set; }

        public int Size { get; set; }

        public int DimensionX { get; set; }

        public int DimensionY { get; set; }
    }
}
