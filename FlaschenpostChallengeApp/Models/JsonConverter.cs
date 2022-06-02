using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public static class JsonConverter
  {
    private static readonly string url = "https://flapotest.blob.core.windows.net/test/ProductData.json";

    public async static Task<IEnumerable<Product>> GetProductsFromJsonAsync()
    {
      try
      {
        var products = await HttpClientJsonExtensions.GetFromJsonAsync<IEnumerable<Product>>(new HttpClient(), url);
        return products;
      }
      catch (Exception ex)
      {
        throw new ArgumentException(ex.Message);
      }
    }
  }
}
