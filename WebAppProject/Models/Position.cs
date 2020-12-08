
using System.Collections.Generic;

namespace WebAppProject.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public List<UserPosition> UserPosition { get; set; }

    }
}
