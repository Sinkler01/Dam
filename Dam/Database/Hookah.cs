using System;
using System.Collections.Generic;

namespace Dam.Database
{
    public partial class Hookah
    {
        public int IdHookah { get; set; }
        public string Name { get; set; } = null!;
        public string? Zametki { get; set; }
        public byte[]? Image { get; set; }
    }
}
