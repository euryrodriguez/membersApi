using System;
using System.Collections.Generic;

namespace ApiDbFirst.Models
{
    public partial class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
    }
}
