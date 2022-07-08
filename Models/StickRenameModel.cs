using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class StickRenameModel
    {
        [JsonProperty("IdStick")]
        public string IdStick { get; set; }

        [JsonProperty("NewName")]
        public string NewName { get; set; }
    }
}
