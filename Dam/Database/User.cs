using System;
using System.Collections.Generic;

namespace Dam.Database
{
    public partial class User
    {
        public int IdUsers { get; set; }
        public string Roll { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
