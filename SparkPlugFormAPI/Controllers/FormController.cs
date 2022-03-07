using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SparkPlugFormAPI.Core.Interface;
using SparkPlugFormAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService; //Inject the FormService

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpPost("add-form-data")]
        public async Task<IActionResult> AddFormDataAsync([FromForm] FormDataToAddDto data)
        {
            //Check for model state error
            if (!ModelState.IsValid){
                ModelState.AddModelError("Error", "Bad Input");
                return BadRequest(ModelState);
            }
            var result = await _formService.AddFormData(data);
            if (result.success){
                return Ok(result);
            }else{
                return BadRequest(result);
            }
        }
    }
}
