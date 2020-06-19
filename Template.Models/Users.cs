using System;

namespace Template.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool Available { get; set; }
    }
}