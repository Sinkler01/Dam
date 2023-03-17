using System;
using System.Collections.Generic;

namespace Dam.Database
{
    public partial class Ychastniki
    {
        public int IdYchastniki { get; set; }
        public string Fio { get; set; } = null!;
        public string? Zametki { get; set; }
        public byte[]? Image { get; set; }
    }
}
