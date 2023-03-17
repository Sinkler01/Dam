using System;
using System.Collections.Generic;

namespace Dam.Database
{
    public partial class Tabac
    {
        public int IdTabac { get; set; }
        public string Name { get; set; } = null!;
        public string Vid { get; set; } = null!;
        public string Zametki { get; set; } = null!;
        public byte[] Image { get; set; } = null!;
    }
}
