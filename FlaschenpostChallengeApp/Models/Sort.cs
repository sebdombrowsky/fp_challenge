using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public static class Sort
  {
    public static List<Product> SortAscending(List<Product> products)
    {
      return products = products.OrderBy(p => p.Articles.FirstOrDefault().Price).ToList();
    }

    public static List<Product> SortDescending(List<Product> products)
    {
      return products = products.OrderByDescending(p => p.Articles.FirstOrDefault().Price).ToList();
    }

    public static List<Product> SplitProductsWithMoreThanOneArticle(List<Product> products)
    {
      List<Product> newProductList = new List<Product>();

      foreach(var p in products)
      {
        if(p.Articles.Count == 1)
        {
          newProductList.Add(p);
        }
        else
        {
          foreach(var a in p.Articles)
          {
            newProductList.Add(new Product()
            {
              BrandName = p.BrandName,
              Name = p.Name,
              Id = p.Id,
              DescriptionText = p.DescriptionText,
              Articles = new List<Article>() { a },
            });
          }
        }
      }

      return newProductList;
    }
  }
}
