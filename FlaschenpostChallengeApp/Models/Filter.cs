using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public class Filter
  {
    private readonly IEnumerable<Product> AllProducts;

    public Filter(IEnumerable<Product> allProducts)
    {
      this.AllProducts = allProducts;
    }

    /// <summary>
    /// returns all products with articles, which are cheaper than 2€
    /// </summary>
    /// <returns></returns>
    public List<Product> FilterMoreExpensiveThanTwoEuros()
    {
      List<Product> filteredProducts = new List<Product>();
      foreach (var p in this.AllProducts)
      {
        foreach (var a in p.Articles)
        {
          if(a.ConvertPricePerUnitTextToDouble() < 2)
          filteredProducts.Add(new Product()
          {
            BrandName = p.BrandName,
            Name = p.Name,
            Id = p.Id,
            DescriptionText = p.DescriptionText,
            Articles = new List<Article>() { a },
          });
        }
      }
      return filteredProducts;
    }

    public List<Product> ShowAll()
    {
      return AllProducts.ToList();
    }
  }
}
