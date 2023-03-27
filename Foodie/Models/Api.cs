using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Foodie.Models
{
    public class Api<T>
    { 
        public async Task<ApiResponse<T>> Send(T dataToSend, string endpoint) {
            ApiResponse<T> result = new ApiResponse<T>();
            try {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7181/api/");

                var json = System.Text.Json.JsonSerializer.Serialize(dataToSend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(endpoint, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    result = System.Text.Json.JsonSerializer.Deserialize<ApiResponse<T>>(responseContent, options);
                    return result;

                }
                else
                {
                    result.Success = false;
                    return result;
                }
            }
            catch (Exception ex) {
                result.Success = false;
                //result.Data = ex.Message;
                return result;
            }
            
        }
        public async Task<ApiResponse<T>> Get(string endpoint) {
            ApiResponse<T>? result = new ApiResponse<T>();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7181/api/");
            try
            {
                var response = client.GetAsync(endpoint).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    result = System.Text.Json.JsonSerializer.Deserialize<ApiResponse<T>>(responseContent, options);
                    return result;

                }
                else
                {
                    result.Success = false;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                //result.Data = ex.Message;
                return result;
            }
            
        }
    }
       
}
