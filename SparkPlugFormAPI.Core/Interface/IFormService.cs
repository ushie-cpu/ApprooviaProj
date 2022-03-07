using SparkPlugFormAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Core.Interface
{
    public interface IFormService
    {
        Task<ResponseDto> AddFormData(FormDataToAddDto data);
    }
}
