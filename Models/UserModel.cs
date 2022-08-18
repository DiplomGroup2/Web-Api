
namespace MVC_2.Models
{
    public class UserModel
    {
       // [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
