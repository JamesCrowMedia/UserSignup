using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime Created { get; set; }
        public int UserId { get; private set; }
        private static int nextId = 1;

        public User()
        {
            Created = DateTime.Now;
            this.UserId = nextId;
            nextId++;
        }
    }
}
