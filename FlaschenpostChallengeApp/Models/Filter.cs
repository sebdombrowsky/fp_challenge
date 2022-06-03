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

    public List<Product> FilterMoreExpensiveThanTwoEuros()
    {
      var p = AllProducts.Where(p => p.Articles.FirstOrDefault().ConvertPricePerUnitTextToDouble() < 2.0).ToList();
      return p;
    }

    public List<Product> ShowAll()
    {
      return AllProducts.ToList();
    }
  }
}
