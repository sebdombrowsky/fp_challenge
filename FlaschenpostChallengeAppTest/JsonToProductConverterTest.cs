using FlaschenpostChallengeApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlaschenpostChallengeAppTest
{
  [TestClass]
  public class JsonToProductConverterTest
  {
    public List<Product> ProductList;

    [TestInitialize]
    public async Task Init()
    {
      this.ProductList = (List<Product>) await JsonToProductConverter.GetProductsFromJsonAsync();
    }

    [TestMethod]
    public void ProductListIsNullTest()
    {
      Assert.IsFalse(this.ProductList == null);
    }

    [TestMethod]
    public void ConvertFirsProductTest()
    {
      Product firstProduct = this.ProductList[0];

      Assert.AreEqual((int)1138, firstProduct.Id);
      Assert.AreEqual("Büble", firstProduct.BrandName);
      Assert.AreEqual("Allgäuer Büble Bayrisch Hell", firstProduct.Name);
      Assert.AreEqual(null, firstProduct.DescriptionText);
      Assert.AreEqual(1, firstProduct.Articles.Count);
      Assert.AreEqual((int)1491, firstProduct.Articles[0].Id);
      Assert.AreEqual("20 x 0,5L (Glas)", firstProduct.Articles[0].ShortDescription);
      Assert.AreEqual((double)17.99, firstProduct.Articles[0].Price);
      Assert.AreEqual("Liter", firstProduct.Articles[0].Unit);
      Assert.AreEqual("(1,80 €/Liter)", firstProduct.Articles[0].PricePerUnitText);
      Assert.AreEqual("https://image.flaschenpost.de/articles/small/1491.png", firstProduct.Articles[0].Image);
    }

    [TestMethod]
    public void ConvertProductWithTwoArticlesTest()
    {
      Product productWithTwoArticles = this.ProductList.Find(p => p.Articles.Count > 1) ;

      Assert.AreEqual(2, productWithTwoArticles.Articles.Count);

      Assert.AreEqual((int)3006, productWithTwoArticles.Articles[0].Id);
      Assert.AreEqual((int)6224, productWithTwoArticles.Articles[1].Id);
    }
  }
}
