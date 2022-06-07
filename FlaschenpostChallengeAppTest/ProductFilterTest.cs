using FlaschenpostChallengeApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaschenpostChallengeAppTest
{
  [TestClass]
  public class ProductFilterTest
  {
    public Filter Filter;

    [TestInitialize]
    public void Init()
    {
      IEnumerable<Product> products = new List<Product>() 
      { 
        new Product() 
        { 
          Articles = 
          { 
            new Article()
            {
              Id = 1,
              PricePerUnitText = "(3,66 €/Liter)" 
            }, 
            new Article()
            {
              Id = 2,
              PricePerUnitText = "(1,66 €/Liter)" 
            } 
          } 
        },
        new Product()
        {
          Articles =
          {
            new Article()
            {
              Id = 3,
              PricePerUnitText = "(2,66 €/Liter)"
            }
          }
        }
      };
      this.Filter = new Filter(products);
    }

    [TestMethod]
    public void FilterProductsMoreExpensiveThanTwoEurosTest()
    {
      var products = this.Filter.FilterMoreExpensiveThanTwoEuros();

      Assert.IsTrue(products.Count == 1);
      Assert.AreEqual(2, products.FirstOrDefault().Articles.FirstOrDefault().Id);
    }
  }
}
