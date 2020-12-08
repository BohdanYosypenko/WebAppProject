
using System.Collections.Generic;

namespace WebAppProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<UserPosition> UserPosition { get; set; }
    }
}
