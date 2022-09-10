using DBMongo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class PageTagModel
    {
        [JsonProperty("IdPage")]
        public string IdPage { get; set; }

        [JsonProperty("Group")]
        public string Group { get; set; }
        
    }
}
