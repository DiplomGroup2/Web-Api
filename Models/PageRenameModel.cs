using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class PageRenameModel
    {
        [JsonProperty("IdPage")]
        public string IdPage { get; set; }

        [JsonProperty("NewName")]
        public string NewName { get; set; }
    }
}
