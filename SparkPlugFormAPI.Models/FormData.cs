using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Models
{
    public class FormData : BaseEntity
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMessage { get; set; }

        public FormData()
        {
            Id = Guid.NewGuid().ToString();
            CreatedDate = DateTimeOffset.UtcNow; //UTC used here to avoid timezone confusion
            UpdatedDate = DateTimeOffset.UtcNow;
        }
    }
}
