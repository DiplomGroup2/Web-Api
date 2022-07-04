using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class LoginModel
    {
        [JsonProperty("Login")]
        [Required(ErrorMessage = "Не указан Login")]
        public string Login { get; set; }

        [JsonProperty("Password")]
        [Required(ErrorMessage = "Не указан пароль")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
