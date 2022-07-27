using DBMongo.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Models
{
    public class RecordModel
    {
        [JsonProperty("IdRecord")]
        public string IdRecord { get; set; }
       
        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("PageId")]
        [Required(ErrorMessage = "Не указан PageId")]
        public string PageId { get; set; }
      
        [JsonProperty("Image")]
        public IFormFile File { get; set; }
        
        //[JsonProperty("RecordType")]
        //[Required(ErrorMessage = "Не указан RecordType")]
        //public RecordType RecordType { get; set; }

       

        //[JsonProperty("Image")]
        //public byte[] StrRecordByte { get; set; }

       
    }
}
