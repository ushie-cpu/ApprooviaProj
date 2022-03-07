using MongoDB.Driver;
using SparkPlugFormAPI.Core.Interface;
using SparkPlugFormAPI.Models;
using SparkPlugFormAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugFormAPI.Core.Implementation
{
    public class FormService : IFormService
    {
        private readonly IMongoClient _mongoClient;

        public FormService(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }
        public async Task<ResponseDto> AddFormData(FormDataToAddDto data)
        {
            //Get database object or create one if not found
            var database = _mongoClient.GetDatabase(data._formDomainName);

            //Get collection object or create one if not found
            var collection = database.GetCollection<FormData>(data._formName);
            if(collection == null){
                await database.CreateCollectionAsync(data._formName);
            }

            //construct FormData object from FormDataToAddDto object
            var formData = new FormData{
                CustomerName = data.customerName,
                CustomerEmail = data.customerEmail,
                CustomerMessage = data.customerMessage
            };

            try{
                await collection.InsertOneAsync(formData);
                return new ResponseDto { success = true, message = "Form data successfully added"};
            }
            catch(Exception e){
                return new ResponseDto { success = false, message = "Form data failed to be added" };
            }

        }
    }
}
