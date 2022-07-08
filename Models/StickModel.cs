using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class StickModel
    {
        [JsonProperty("IdStick")]
        public string IdStick { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("RecordIds")]
        public List<string> RecordIds { get; set; }
    }
}
