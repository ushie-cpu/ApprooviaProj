using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Models
{
    public class BaseEntity
    {
        public string Id { get; set; } 
        public DateTimeOffset CreatedDate { get; set; }  
        public DateTimeOffset UpdatedDate { get; set; } 
    }
}
