using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Services
{
    public  class AiService
    {
        private const string BaseUrl = "https://todointern.azurewebsites.net/api/";
        private HttpClient httpclient;
        public AiService()
        {
            httpclient = new HttpClient();
            httpclient.BaseAddress = new System.Uri(BaseUrl);
        }
              

                //async public Task<string> PostPhoto(MultipartFormDataContent item)
                //{
                //   try
                //    {
                        
        //                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
        //                var result = await httpclient.PostAsync("Todo", content);
        //                if (result.IsSuccessStatusCode)
        //                    return true;
        //                return false;
        //            }
        //            catch (Exception e)
        //            {
        //                return false;
        //            }
        //        }
        //        async public Task<bool> UpdateTodo(TodoItem item)
        //        {
        //            try
        //            {
        //                var itemtosend = JsonConvert.SerializeObject(item);
        //                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
        //                var result = await httpclient.PutAsync("Todo/" + item.todoId, content);
        //                if (result.IsSuccessStatusCode)
        //                    return true;
        //                return false;
        //            }
        //            catch (Exception e)
        //            {
        //                return false;
        //            }
        //        }
        //        async public Task<bool> DeleteToDo(int id)
        //        {
        //            try
        //            {

        //                var result = await httpclient.DeleteAsync("Todo/" + id);
        //                if (result.IsSuccessStatusCode)
        //                    return true;
        //                return false;
        //            }
        //            catch (Exception e)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //}
    }
}
