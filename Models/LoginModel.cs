using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class LoginModel
    {
        [JsonProperty("Email")]
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [JsonProperty("Password")]
        [Required(ErrorMessage = "Не указан пароль")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
