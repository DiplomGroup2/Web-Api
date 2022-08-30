using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom_webAPI_REST.Models
{
    public class GroupModel
    {
        [JsonProperty("Tag")]
        public string Tag { get; set; }
    }
}
