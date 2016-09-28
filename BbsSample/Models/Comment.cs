using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BbsSample.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
}