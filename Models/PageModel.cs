using DBMongo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class PageModel
    {
        [JsonProperty("IdPage")]
        public string IdPage { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
       
        [JsonProperty("Records")]
        public List<Record> Records { get; set; }

        [JsonProperty("Group")]
        public List<string> Group { get; set; }
        //[JsonProperty("RecordIds")]
        //public List<string> RecordIds { get; set; }
    }
}
