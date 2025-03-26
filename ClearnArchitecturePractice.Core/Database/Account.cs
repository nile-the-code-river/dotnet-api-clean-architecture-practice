using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearnArchitecturePractice.Core.Database
{
    public class Account
    {
        public required int Id { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; } // hash
        public required string Name { get; set; }
        public required string Company { get; set; }
        public required string Country { get; set; }
        public required string PrimaryAddress { get; set; }
        public required string SecondaryAddress { get; set; }
        public required bool IsActive { get; set; }
        public required DateTimeOffset RegisteredDate { get; set; }

        // public required AccountRole Role {get;set;}
    }
}
