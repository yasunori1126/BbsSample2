using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BbsSample.Models
{
    public class BbsDbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}