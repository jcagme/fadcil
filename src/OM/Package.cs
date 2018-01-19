using System;

namespace OM
{
    public class Package
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public uint ImageNumber { get; set; }

        public uint CharacterNumber { get; set; }

        public uint ExpiresIn { get; set; }
    }
}
