using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Models.DTOs
{
    public class FormDataToAddDto
    {
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerEmail { get; set; }
        [Required]
        public string customerMessage { get; set; }
        public string _formName { get; set; }
        public string _formDomainName { get; set; }
    }
}
