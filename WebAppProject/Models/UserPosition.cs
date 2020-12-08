
namespace WebAppProject.Models
{
    public class UserPosition
    {
        public int Id { get; set; }


        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
