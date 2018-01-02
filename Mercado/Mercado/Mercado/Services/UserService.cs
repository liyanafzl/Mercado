using Mercado.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Services
{
  public  class UserService
    {
                
              private const string BaseUrl = "https://mercadoapp.azurewebsites.net/";
                private HttpClient httpclient;
                public UserService()
                {
                    httpclient = new HttpClient();
                   httpclient.BaseAddress = new System.Uri(BaseUrl);
                }
                async public Task<ObservableCollection<Shop>> GetShopList()
                {
                  try
                    {
                        var result = await httpclient.GetAsync("Shop");
                        if (result.IsSuccessStatusCode)
                        {
                            var json = await result.Content.ReadAsStringAsync();
                           var shoplist = JsonConvert.DeserializeObject<ObservableCollection<Shop>>(json);
                            return shoplist;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }

                async public Task<ObservableCollection<Shop>> SearchShop(string item)
                {
                    try
                    {
                        var itemtosend = JsonConvert.SerializeObject(item);
                      var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                        var result = await httpclient.PostAsync("search/"+item, content);
                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var shoplist = JsonConvert.DeserializeObject<ObservableCollection<Shop>>(json);
                    return shoplist;
                }
                        return null;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
              }
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
