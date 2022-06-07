using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlaschenpostChallengeApp.Models
{
  public class Article
  {
    public Article()
    {
    }

    public int Id { get; set; }

    public string ShortDescription { get; set; }

    public double Price { get; set; }

    public string Unit { get; set; }

    public string PricePerUnitText { get; set; }

    public string Image { get; set; }

    public double? ConvertPricePerUnitTextToDouble()
    {
      bool hasValidPrice = double.TryParse(PricePerUnitText.Split('(')[1].Substring(0, 4), out double p);
      if(hasValidPrice)
      {
        return p;
      }
      else
      {
        return null;
      }
    }
  }
}
